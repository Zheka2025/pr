namespace DB_Editor.Forms
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
            this.text_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.db_login = new System.Windows.Forms.TextBox();
            this.db_pass = new System.Windows.Forms.TextBox();
            this.db_name = new System.Windows.Forms.TextBox();
            this.tryAuth = new System.Windows.Forms.Button();
            this.db_login_lbl = new System.Windows.Forms.Label();
            this.db_pass_lbl = new System.Windows.Forms.Label();
            this.db_name_lbl = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_lbl
            // 
            this.text_lbl.AutoSize = true;
            this.text_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_lbl.Location = new System.Drawing.Point(33, 42);
            this.text_lbl.Name = "text_lbl";
            this.text_lbl.Size = new System.Drawing.Size(202, 91);
            this.text_lbl.TabIndex = 0;
            this.text_lbl.Text = "Auth";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(191, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // db_login
            // 
            this.db_login.Location = new System.Drawing.Point(49, 202);
            this.db_login.Name = "db_login";
            this.db_login.Size = new System.Drawing.Size(164, 20);
            this.db_login.TabIndex = 2;
            // 
            // db_pass
            // 
            this.db_pass.Location = new System.Drawing.Point(49, 251);
            this.db_pass.Name = "db_pass";
            this.db_pass.Size = new System.Drawing.Size(164, 20);
            this.db_pass.TabIndex = 3;
            // 
            // db_name
            // 
            this.db_name.Location = new System.Drawing.Point(49, 298);
            this.db_name.Name = "db_name";
            this.db_name.Size = new System.Drawing.Size(164, 20);
            this.db_name.TabIndex = 4;
            // 
            // tryAuth
            // 
            this.tryAuth.Location = new System.Drawing.Point(49, 369);
            this.tryAuth.Name = "tryAuth";
            this.tryAuth.Size = new System.Drawing.Size(164, 23);
            this.tryAuth.TabIndex = 5;
            this.tryAuth.Text = "Go auth";
            this.tryAuth.UseVisualStyleBackColor = true;
            this.tryAuth.Click += new System.EventHandler(this.tryAuth_Click);
            // 
            // db_login_lbl
            // 
            this.db_login_lbl.AutoSize = true;
            this.db_login_lbl.Location = new System.Drawing.Point(46, 186);
            this.db_login_lbl.Name = "db_login_lbl";
            this.db_login_lbl.Size = new System.Drawing.Size(78, 13);
            this.db_login_lbl.TabIndex = 6;
            this.db_login_lbl.Text = "Database login";
            // 
            // db_pass_lbl
            // 
            this.db_pass_lbl.AutoSize = true;
            this.db_pass_lbl.Location = new System.Drawing.Point(46, 235);
            this.db_pass_lbl.Name = "db_pass_lbl";
            this.db_pass_lbl.Size = new System.Drawing.Size(101, 13);
            this.db_pass_lbl.TabIndex = 7;
            this.db_pass_lbl.Text = "Database password";
            // 
            // db_name_lbl
            // 
            this.db_name_lbl.AutoSize = true;
            this.db_name_lbl.Location = new System.Drawing.Point(46, 282);
            this.db_name_lbl.Name = "db_name_lbl";
            this.db_name_lbl.Size = new System.Drawing.Size(82, 13);
            this.db_name_lbl.TabIndex = 8;
            this.db_name_lbl.Text = "Database name";
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.status_lbl.Location = new System.Drawing.Point(46, 353);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 13);
            this.status_lbl.TabIndex = 9;
            // 
            // Auth
            // 
            this.AcceptButton = this.tryAuth;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 477);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.db_name_lbl);
            this.Controls.Add(this.db_pass_lbl);
            this.Controls.Add(this.db_login_lbl);
            this.Controls.Add(this.tryAuth);
            this.Controls.Add(this.db_name);
            this.Controls.Add(this.db_pass);
            this.Controls.Add(this.db_login);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.text_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_lbl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox db_login;
        private System.Windows.Forms.TextBox db_pass;
        private System.Windows.Forms.TextBox db_name;
        private System.Windows.Forms.Button tryAuth;
        private System.Windows.Forms.Label db_login_lbl;
        private System.Windows.Forms.Label db_pass_lbl;
        private System.Windows.Forms.Label db_name_lbl;
        private System.Windows.Forms.Label status_lbl;
    }
}