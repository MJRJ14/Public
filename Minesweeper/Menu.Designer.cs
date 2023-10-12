namespace Minesweeper
{
    partial class menuForm
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
            this.menuTitle = new System.Windows.Forms.Label();
            this.easyMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hardMode = new System.Windows.Forms.Button();
            this.medMode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuTitle
            // 
            this.menuTitle.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold);
            this.menuTitle.Location = new System.Drawing.Point(12, 9);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(360, 60);
            this.menuTitle.TabIndex = 0;
            this.menuTitle.Text = "Minesweeper";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // easyMode
            // 
            this.easyMode.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyMode.Location = new System.Drawing.Point(105, 158);
            this.easyMode.Name = "easyMode";
            this.easyMode.Size = new System.Drawing.Size(175, 28);
            this.easyMode.TabIndex = 1;
            this.easyMode.Text = "Easy";
            this.easyMode.UseVisualStyleBackColor = true;
            this.easyMode.Click += new System.EventHandler(this.easyPicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Difficulties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hardMode
            // 
            this.hardMode.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold);
            this.hardMode.Location = new System.Drawing.Point(105, 216);
            this.hardMode.Name = "hardMode";
            this.hardMode.Size = new System.Drawing.Size(175, 28);
            this.hardMode.TabIndex = 3;
            this.hardMode.Text = "Hard";
            this.hardMode.UseVisualStyleBackColor = true;
            this.hardMode.Click += new System.EventHandler(this.hardPicked);
            // 
            // medMode
            // 
            this.medMode.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold);
            this.medMode.Location = new System.Drawing.Point(105, 187);
            this.medMode.Name = "medMode";
            this.medMode.Size = new System.Drawing.Size(175, 28);
            this.medMode.TabIndex = 4;
            this.medMode.Text = "Medium";
            this.medMode.UseVisualStyleBackColor = true;
            this.medMode.Click += new System.EventHandler(this.mediumPicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ink Free", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curated by: MJRJ14\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Version: 0.1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medMode);
            this.Controls.Add(this.hardMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.easyMode);
            this.Controls.Add(this.menuTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "menuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Button easyMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hardMode;
        private System.Windows.Forms.Button medMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

