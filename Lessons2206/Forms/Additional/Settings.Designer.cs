namespace Lessons2206.Forms.Additional
{
    partial class Settings
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
            this.deauth_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deauth_btn
            // 
            this.deauth_btn.BackColor = System.Drawing.Color.Maroon;
            this.deauth_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deauth_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deauth_btn.Location = new System.Drawing.Point(224, 347);
            this.deauth_btn.Name = "deauth_btn";
            this.deauth_btn.Size = new System.Drawing.Size(75, 23);
            this.deauth_btn.TabIndex = 0;
            this.deauth_btn.Text = "Выйти";
            this.deauth_btn.UseVisualStyleBackColor = false;
            this.deauth_btn.Click += new System.EventHandler(this.deauth_btn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 382);
            this.Controls.Add(this.deauth_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deauth_btn;
    }
}