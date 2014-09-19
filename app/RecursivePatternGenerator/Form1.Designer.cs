namespace RecursivePatternGenerator
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
            this.mainDisplayBox = new System.Windows.Forms.PictureBox();
            this.pixelDensity = new System.Windows.Forms.NumericUpDown();
            this.lblFeedBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDisplayBox
            // 
            this.mainDisplayBox.Location = new System.Drawing.Point(12, 12);
            this.mainDisplayBox.Name = "mainDisplayBox";
            this.mainDisplayBox.Size = new System.Drawing.Size(630, 630);
            this.mainDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainDisplayBox.TabIndex = 0;
            this.mainDisplayBox.TabStop = false;
            this.mainDisplayBox.Click += new System.EventHandler(this.mainDisplayBox_Click);
            // 
            // pixelDensity
            // 
            this.pixelDensity.Location = new System.Drawing.Point(740, 161);
            this.pixelDensity.Name = "pixelDensity";
            this.pixelDensity.Size = new System.Drawing.Size(54, 20);
            this.pixelDensity.TabIndex = 1;
            this.pixelDensity.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.AutoSize = true;
            this.lblFeedBack.Location = new System.Drawing.Point(660, 485);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(81, 13);
            this.lblFeedBack.TabIndex = 2;
            this.lblFeedBack.Text = "feedback labek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 651);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.pixelDensity);
            this.Controls.Add(this.mainDisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelDensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainDisplayBox;
        private System.Windows.Forms.NumericUpDown pixelDensity;
        private System.Windows.Forms.Label lblFeedBack;
    }
}

