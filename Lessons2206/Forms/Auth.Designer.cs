namespace Lessons2206.Forms
{
    partial class Auth
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
            this.login_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.auth_btn = new System.Windows.Forms.Button();
            this.savepass_cb = new System.Windows.Forms.CheckBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.quickauth_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(12, 23);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(163, 20);
            this.login_tb.TabIndex = 0;
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(181, 23);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(150, 20);
            this.pass_tb.TabIndex = 1;
            // 
            // auth_btn
            // 
            this.auth_btn.Location = new System.Drawing.Point(12, 49);
            this.auth_btn.Name = "auth_btn";
            this.auth_btn.Size = new System.Drawing.Size(319, 23);
            this.auth_btn.TabIndex = 2;
            this.auth_btn.Text = "Auth";
            this.auth_btn.UseVisualStyleBackColor = true;
            this.auth_btn.Click += new System.EventHandler(this.auth_btn_Click);
            // 
            // savepass_cb
            // 
            this.savepass_cb.AutoSize = true;
            this.savepass_cb.Location = new System.Drawing.Point(12, 78);
            this.savepass_cb.Name = "savepass_cb";
            this.savepass_cb.Size = new System.Drawing.Size(99, 17);
            this.savepass_cb.TabIndex = 3;
            this.savepass_cb.Text = "Save password";
            this.savepass_cb.UseVisualStyleBackColor = true;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(12, 7);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(55, 13);
            this.login_lbl.TabIndex = 4;
            this.login_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(178, 7);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_lbl.TabIndex = 5;
            this.password_lbl.Text = "Password";
            // 
            // quickauth_cb
            // 
            this.quickauth_cb.AutoSize = true;
            this.quickauth_cb.Location = new System.Drawing.Point(251, 78);
            this.quickauth_cb.Name = "quickauth_cb";
            this.quickauth_cb.Size = new System.Drawing.Size(79, 17);
            this.quickauth_cb.TabIndex = 6;
            this.quickauth_cb.Text = "Quick Auth";
            this.quickauth_cb.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            this.AcceptButton = this.auth_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 113);
            this.Controls.Add(this.quickauth_cb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.savepass_cb);
            this.Controls.Add(this.auth_btn);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.login_tb);
            this.Name = "Auth";
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.Shown += new System.EventHandler(this.Auth_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Button auth_btn;
        private System.Windows.Forms.CheckBox savepass_cb;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.CheckBox quickauth_cb;
    }
}