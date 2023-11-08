namespace Lab_2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.photoCanvas = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.noiseRadio = new System.Windows.Forms.RadioButton();
			this.tintRadio = new System.Windows.Forms.RadioButton();
			this.bwRadio = new System.Windows.Forms.RadioButton();
			this.contrastRadio = new System.Windows.Forms.RadioButton();
			this.picLoadBtn = new System.Windows.Forms.Button();
			this.photoFinder = new System.Windows.Forms.OpenFileDialog();
			this.sliderVal = new System.Windows.Forms.TrackBar();
			this.transformPicBtn = new System.Windows.Forms.Button();
			this.valDispLabel = new System.Windows.Forms.Label();
			this.leftLabel = new System.Windows.Forms.Label();
			this.rightLabel = new System.Windows.Forms.Label();
			this.savePic = new System.Windows.Forms.Button();
			this.resetPic = new System.Windows.Forms.Button();
			this.imgProgress = new System.Windows.Forms.ProgressBar();
			this.saveImg = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.photoCanvas)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderVal)).BeginInit();
			this.SuspendLayout();
			// 
			// photoCanvas
			// 
			this.photoCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.photoCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.photoCanvas.Location = new System.Drawing.Point(12, 12);
			this.photoCanvas.Name = "photoCanvas";
			this.photoCanvas.Size = new System.Drawing.Size(655, 318);
			this.photoCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.photoCanvas.TabIndex = 0;
			this.photoCanvas.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.noiseRadio);
			this.groupBox1.Controls.Add(this.tintRadio);
			this.groupBox1.Controls.Add(this.bwRadio);
			this.groupBox1.Controls.Add(this.contrastRadio);
			this.groupBox1.Location = new System.Drawing.Point(114, 357);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(182, 78);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Modification Type";
			// 
			// noiseRadio
			// 
			this.noiseRadio.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.noiseRadio.AutoSize = true;
			this.noiseRadio.Location = new System.Drawing.Point(126, 53);
			this.noiseRadio.Name = "noiseRadio";
			this.noiseRadio.Size = new System.Drawing.Size(52, 17);
			this.noiseRadio.TabIndex = 3;
			this.noiseRadio.Text = "Noise";
			this.noiseRadio.UseVisualStyleBackColor = true;
			this.noiseRadio.CheckedChanged += new System.EventHandler(this.modChange);
			// 
			// tintRadio
			// 
			this.tintRadio.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.tintRadio.AutoSize = true;
			this.tintRadio.Location = new System.Drawing.Point(126, 19);
			this.tintRadio.Name = "tintRadio";
			this.tintRadio.Size = new System.Drawing.Size(43, 17);
			this.tintRadio.TabIndex = 2;
			this.tintRadio.Text = "Tint";
			this.tintRadio.UseVisualStyleBackColor = true;
			this.tintRadio.CheckedChanged += new System.EventHandler(this.modChange);
			// 
			// bwRadio
			// 
			this.bwRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.bwRadio.AutoSize = true;
			this.bwRadio.Location = new System.Drawing.Point(7, 53);
			this.bwRadio.Name = "bwRadio";
			this.bwRadio.Size = new System.Drawing.Size(92, 17);
			this.bwRadio.TabIndex = 1;
			this.bwRadio.Text = "Black && White";
			this.bwRadio.UseVisualStyleBackColor = true;
			this.bwRadio.CheckedChanged += new System.EventHandler(this.modChange);
			// 
			// contrastRadio
			// 
			this.contrastRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.contrastRadio.AutoSize = true;
			this.contrastRadio.Checked = true;
			this.contrastRadio.Location = new System.Drawing.Point(7, 20);
			this.contrastRadio.Name = "contrastRadio";
			this.contrastRadio.Size = new System.Drawing.Size(64, 17);
			this.contrastRadio.TabIndex = 0;
			this.contrastRadio.TabStop = true;
			this.contrastRadio.Text = "Contrast";
			this.contrastRadio.UseVisualStyleBackColor = true;
			this.contrastRadio.CheckedChanged += new System.EventHandler(this.modChange);
			// 
			// picLoadBtn
			// 
			this.picLoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picLoadBtn.Location = new System.Drawing.Point(12, 357);
			this.picLoadBtn.Name = "picLoadBtn";
			this.picLoadBtn.Size = new System.Drawing.Size(96, 23);
			this.picLoadBtn.TabIndex = 4;
			this.picLoadBtn.Text = "Load Picture";
			this.picLoadBtn.UseVisualStyleBackColor = true;
			this.picLoadBtn.Click += new System.EventHandler(this.LoadPicture);
			// 
			// sliderVal
			// 
			this.sliderVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sliderVal.Location = new System.Drawing.Point(302, 357);
			this.sliderVal.Maximum = 100;
			this.sliderVal.Name = "sliderVal";
			this.sliderVal.Size = new System.Drawing.Size(263, 45);
			this.sliderVal.SmallChange = 5;
			this.sliderVal.TabIndex = 5;
			this.sliderVal.TickFrequency = 10;
			this.sliderVal.Value = 50;
			this.sliderVal.ValueChanged += new System.EventHandler(this.sliderValChange);
			// 
			// transformPicBtn
			// 
			this.transformPicBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.transformPicBtn.Enabled = false;
			this.transformPicBtn.Location = new System.Drawing.Point(571, 357);
			this.transformPicBtn.Name = "transformPicBtn";
			this.transformPicBtn.Size = new System.Drawing.Size(96, 23);
			this.transformPicBtn.TabIndex = 6;
			this.transformPicBtn.Text = "Transform!";
			this.transformPicBtn.UseVisualStyleBackColor = true;
			this.transformPicBtn.Click += new System.EventHandler(this.TransformImage);
			// 
			// valDispLabel
			// 
			this.valDispLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.valDispLabel.ForeColor = System.Drawing.Color.Blue;
			this.valDispLabel.Location = new System.Drawing.Point(302, 394);
			this.valDispLabel.Name = "valDispLabel";
			this.valDispLabel.Size = new System.Drawing.Size(263, 16);
			this.valDispLabel.TabIndex = 7;
			this.valDispLabel.Text = "val";
			this.valDispLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// leftLabel
			// 
			this.leftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.leftLabel.Location = new System.Drawing.Point(302, 394);
			this.leftLabel.Name = "leftLabel";
			this.leftLabel.Size = new System.Drawing.Size(56, 16);
			this.leftLabel.TabIndex = 8;
			this.leftLabel.Text = "left";
			// 
			// rightLabel
			// 
			this.rightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.rightLabel.Location = new System.Drawing.Point(509, 394);
			this.rightLabel.Name = "rightLabel";
			this.rightLabel.Size = new System.Drawing.Size(56, 16);
			this.rightLabel.TabIndex = 9;
			this.rightLabel.Text = "right";
			this.rightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// savePic
			// 
			this.savePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.savePic.Enabled = false;
			this.savePic.Location = new System.Drawing.Point(12, 383);
			this.savePic.Name = "savePic";
			this.savePic.Size = new System.Drawing.Size(96, 23);
			this.savePic.TabIndex = 10;
			this.savePic.Text = "Save Picture";
			this.savePic.UseVisualStyleBackColor = true;
			this.savePic.Click += new System.EventHandler(this.savePicture);
			// 
			// resetPic
			// 
			this.resetPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.resetPic.Enabled = false;
			this.resetPic.Location = new System.Drawing.Point(12, 410);
			this.resetPic.Name = "resetPic";
			this.resetPic.Size = new System.Drawing.Size(96, 23);
			this.resetPic.TabIndex = 11;
			this.resetPic.Text = "Reset Picture";
			this.resetPic.UseVisualStyleBackColor = true;
			this.resetPic.Click += new System.EventHandler(this.resetImg);
			// 
			// imgProgress
			// 
			this.imgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imgProgress.Location = new System.Drawing.Point(12, 336);
			this.imgProgress.Name = "imgProgress";
			this.imgProgress.Size = new System.Drawing.Size(655, 15);
			this.imgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.imgProgress.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 445);
			this.Controls.Add(this.imgProgress);
			this.Controls.Add(this.resetPic);
			this.Controls.Add(this.savePic);
			this.Controls.Add(this.rightLabel);
			this.Controls.Add(this.leftLabel);
			this.Controls.Add(this.valDispLabel);
			this.Controls.Add(this.transformPicBtn);
			this.Controls.Add(this.sliderVal);
			this.Controls.Add(this.picLoadBtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.photoCanvas);
			this.MinimumSize = new System.Drawing.Size(611, 376);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PicBender";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.photoCanvas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderVal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox photoCanvas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton noiseRadio;
		private System.Windows.Forms.RadioButton tintRadio;
		private System.Windows.Forms.RadioButton bwRadio;
		private System.Windows.Forms.RadioButton contrastRadio;
		private System.Windows.Forms.OpenFileDialog photoFinder;
		private System.Windows.Forms.TrackBar sliderVal;
		private System.Windows.Forms.Button transformPicBtn;
		private System.Windows.Forms.Label valDispLabel;
		private System.Windows.Forms.Button picLoadBtn;
		private System.Windows.Forms.Label leftLabel;
		private System.Windows.Forms.Label rightLabel;
		private System.Windows.Forms.Button savePic;
		private System.Windows.Forms.Button resetPic;
		private System.Windows.Forms.ProgressBar imgProgress;
		private System.Windows.Forms.SaveFileDialog saveImg;
	}
}

