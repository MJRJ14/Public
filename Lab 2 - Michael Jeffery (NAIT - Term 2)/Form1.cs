using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
	public enum ModType
	{
		Contrast,
		BlackWhite,
		Tint,
		Noise
	}

	public partial class Form1 : Form
	{
		public ModType modType;
		public int contrast = 50;
		public int tint = 0;
		public int noise = 50;
		public int bw = 50;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CheckMod();
		}

		private void LoadPicture(object sender, EventArgs e)
		{
			photoFinder.ShowDialog();
			photoCanvas.ImageLocation = photoFinder.FileName;
			transformPicBtn.Enabled = true;
			savePic.Enabled = true;
			resetPic.Enabled = true;
		}

		private void sliderValChange(object sender, EventArgs e)
		{
			CheckMod();
		}

		private void modChange(object sender, EventArgs e)
		{
			SetValues();
			CheckMod();
			GetValues();
		}

		private void GetValues() 
		{
			switch (modType)
			{
				case ModType.Contrast:
					sliderVal.Value = contrast;
					break;
				case ModType.Tint:
					sliderVal.Value = tint + 50;
					break;
				case ModType.Noise:
					sliderVal.Value = noise;
					break;
				case ModType.BlackWhite:
					sliderVal.Value = bw;
					break;
			}
		}

		private void SetValues()
		{
			switch (modType)
			{
				case ModType.Contrast:
					contrast = sliderVal.Value;
					break;
				case ModType.Tint:
					tint = sliderVal.Value - 50;
					break;
				case ModType.Noise:
					noise = sliderVal.Value;
					break;
				case ModType.BlackWhite:
					bw = sliderVal.Value;
					break;
			}
		}

		private void CheckMod()
		{
			if (contrastRadio.Checked)
				modType = ModType.Contrast;
			if (bwRadio.Checked)
				modType = ModType.BlackWhite;
			if (tintRadio.Checked)
				modType = ModType.Tint;
			if (noiseRadio.Checked)
				modType = ModType.Noise;

			leftLabel.Text = string.Empty;
			rightLabel.Text = string.Empty;
			valDispLabel.Text = string.Empty;

			leftLabel.Visible = true;
			rightLabel.Visible = true;
			sliderVal.Visible = true;
			valDispLabel.Visible = true;

			switch (modType) {
				case (ModType.Contrast):
					leftLabel.Text = "Less";
					valDispLabel.Text = sliderVal.Value.ToString();
					rightLabel.Text = "More";
					break;
				case (ModType.BlackWhite):
					leftLabel.Text = "Less";
					valDispLabel.Text = sliderVal.Value.ToString();
					rightLabel.Text = "More";
					break;
				case (ModType.Tint):
					if (sliderVal.Value > 50) {
						valDispLabel.Text = "To green: " + (sliderVal.Value - 50).ToString();
					} else if (sliderVal.Value < 50) {
						valDispLabel.Text = "To red: " + ((sliderVal.Value - 50) * -1).ToString();
					} else {
						valDispLabel.Text = (sliderVal.Value - 50).ToString();
					}
					leftLabel.Text = "Red";
					rightLabel.Text = "Green";
					break;
				case (ModType.Noise):
					leftLabel.Text = "Min";
					valDispLabel.Text = sliderVal.Value.ToString();
					rightLabel.Text = "Max";
					break;
			}
		}

		private void TransformImage(object sender, EventArgs e)
		{
			SetValues();
			ModifyImage();
		}

		private void ModifyImage()
		{
			imgProgress.Maximum = photoCanvas.Image.Width * photoCanvas.Image.Height;
			Bitmap newImage = new Bitmap(photoCanvas.Image);

			Random rand = new Random();

			int x, y = 0;

			for (x = 0; x < newImage.Width; x++) {
				for (y = 0; y < newImage.Height; y++) {
					imgProgress.Increment(1);
					Color pxCol = newImage.GetPixel(x, y);
					int R = 0, G = 0, B = 0;
					switch (modType) {
						case ModType.Contrast:
							Contrast(pxCol, ref R, ref G, ref B);
							break;
						case ModType.BlackWhite:
							BlackWhite(pxCol, ref R, ref G, ref B);
							break;
						case ModType.Tint:
							Tint(pxCol, ref R, ref G, ref B);
							break;
						case ModType.Noise:
							Noise(pxCol, ref R, ref G, ref B , rand);
							break;
					}
					MinMax(ref R, ref G, ref B);
					Color pxNew = Color.FromArgb(R, G, B);
					newImage.SetPixel(x, y, pxNew);
				}
			}
			photoCanvas.Image = newImage;
			imgProgress.Value = 0;
		}

		private void Noise(Color pxCol, ref int R, ref int G, ref int B, Random rand)
		{
			int rRand = rand.Next(noise + 1), gRand = rand.Next(noise + 1), bRand = rand.Next(noise + 1);

			R = pxCol.R + (rRand - (noise / 2));
			G = pxCol.G + (gRand - (noise / 2));
			B = pxCol.B + (bRand - (noise / 2));
		}

		private void Tint(Color pxCol, ref int R, ref int G, ref int B)
		{
			R = pxCol.R - tint;
			G = pxCol.G + tint;
			B = pxCol.B;
		}

		private void BlackWhite(Color pxCol, ref int R, ref int G, ref int B)
		{
			int average = (pxCol.R + pxCol.G + pxCol.B) / 3;
			R = pxCol.R + (int)((average - pxCol.R) * ((double)bw / 100));
			G = pxCol.G + (int)((average - pxCol.G) * ((double)bw / 100));
			B = pxCol.B + (int)((average - pxCol.B) * ((double)bw / 100));
		}

		private void Contrast(Color pxCol, ref int R, ref int G, ref int B)
		{
			R = (pxCol.R < 128) ? pxCol.R - (contrast / 5) : pxCol.R + (contrast / 5);
			G = (pxCol.G < 128) ? pxCol.G - (contrast / 5) : pxCol.G + (contrast / 5);
			B = (pxCol.B < 128) ? pxCol.B - (contrast / 5) : pxCol.B + (contrast / 5);
		}

		private void MinMax(ref int R, ref int G, ref int B)
		{
			R = (R < 255) ? R : 255;
			G = (G < 255) ? G : 255;
			B = (B < 255) ? B : 255;
			R = (R > 0) ? R : 0;
			G = (G > 0) ? G : 0;
			B = (B > 0) ? B : 0;
		}

		private void savePicture(object sender, EventArgs e)
		{
			saveImg.Filter = "jpg file|*.jpg|png file|*.png|bmp file|*.bmp";
			saveImg.Title = "Save an Image File";
			saveImg.ShowDialog();

			if (saveImg.FileName != "")
			{
				System.IO.FileStream fs = (System.IO.FileStream)saveImg.OpenFile();

				switch (saveImg.FilterIndex)
				{
					case 1:
						this.photoCanvas.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg); break;
					case 2:
						this.photoCanvas.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png); break;
					case 3:
						this.photoCanvas.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp); break;
				}

				fs.Close();
			}
		}

		private void resetImg(object sender, EventArgs e)
		{
			photoCanvas.ImageLocation = photoFinder.FileName;
		}
	}
}
