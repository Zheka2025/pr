namespace Lessons2206.Forms.Additional
{
    partial class creatorsForm
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
            this.creator1_lbl = new System.Windows.Forms.Label();
            this.creator2_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // creator1_lbl
            // 
            this.creator1_lbl.AutoSize = true;
            this.creator1_lbl.Location = new System.Drawing.Point(147, 9);
            this.creator1_lbl.Name = "creator1_lbl";
            this.creator1_lbl.Size = new System.Drawing.Size(83, 13);
            this.creator1_lbl.TabIndex = 0;
            this.creator1_lbl.Text = "Roman Odynets";
            // 
            // creator2_lbl
            // 
            this.creator2_lbl.AutoSize = true;
            this.creator2_lbl.Location = new System.Drawing.Point(147, 74);
            this.creator2_lbl.Name = "creator2_lbl";
            this.creator2_lbl.Size = new System.Drawing.Size(157, 13);
            this.creator2_lbl.TabIndex = 1;
            this.creator2_lbl.Text = "ITSTEP Students Group PV811";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Lessons2206.Properties.Resources.TreeOfLife;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // creatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 162);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creator2_lbl);
            this.Controls.Add(this.creator1_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "creatorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creators";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creator1_lbl;
        private System.Windows.Forms.Label creator2_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}