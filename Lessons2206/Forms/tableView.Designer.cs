namespace Lessons2206.Forms
{
    partial class TableView
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
            this.tabTable_tabs = new System.Windows.Forms.TabControl();
            this.tableData_tab = new System.Windows.Forms.TabPage();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.quite_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.tableData_dg = new System.Windows.Forms.DataGridView();
            this.tableSignature_tab = new System.Windows.Forms.TabPage();
            this.tabTable_tabs.SuspendLayout();
            this.tableData_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTable_tabs
            // 
            this.tabTable_tabs.Controls.Add(this.tableData_tab);
            this.tabTable_tabs.Controls.Add(this.tableSignature_tab);
            this.tabTable_tabs.Location = new System.Drawing.Point(0, 0);
            this.tabTable_tabs.Name = "tabTable_tabs";
            this.tabTable_tabs.SelectedIndex = 0;
            this.tabTable_tabs.Size = new System.Drawing.Size(542, 448);
            this.tabTable_tabs.TabIndex = 0;
            // 
            // tableData_tab
            // 
            this.tableData_tab.Controls.Add(this.add_btn);
            this.tableData_tab.Controls.Add(this.delete_btn);
            this.tableData_tab.Controls.Add(this.quite_btn);
            this.tableData_tab.Controls.Add(this.save_btn);
            this.tableData_tab.Controls.Add(this.tableData_dg);
            this.tableData_tab.Location = new System.Drawing.Point(4, 22);
            this.tableData_tab.Name = "tableData_tab";
            this.tableData_tab.Padding = new System.Windows.Forms.Padding(3);
            this.tableData_tab.Size = new System.Drawing.Size(534, 422);
            this.tableData_tab.TabIndex = 0;
            this.tableData_tab.Text = "Data";
            this.tableData_tab.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(127, 383);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(139, 33);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(272, 383);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(121, 33);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // quite_btn
            // 
            this.quite_btn.Location = new System.Drawing.Point(399, 383);
            this.quite_btn.Name = "quite_btn";
            this.quite_btn.Size = new System.Drawing.Size(127, 33);
            this.quite_btn.TabIndex = 3;
            this.quite_btn.Text = "Exit";
            this.quite_btn.UseVisualStyleBackColor = true;
            this.quite_btn.Click += new System.EventHandler(this.quite_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(8, 383);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(113, 33);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // tableData_dg
            // 
            this.tableData_dg.AllowUserToAddRows = false;
            this.tableData_dg.AllowUserToDeleteRows = false;
            this.tableData_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData_dg.Location = new System.Drawing.Point(0, 0);
            this.tableData_dg.Name = "tableData_dg";
            this.tableData_dg.Size = new System.Drawing.Size(534, 377);
            this.tableData_dg.TabIndex = 0;
            this.tableData_dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableData_dg_CellContentClick);
            // 
            // tableSignature_tab
            // 
            this.tableSignature_tab.Location = new System.Drawing.Point(4, 22);
            this.tableSignature_tab.Name = "tableSignature_tab";
            this.tableSignature_tab.Padding = new System.Windows.Forms.Padding(3);
            this.tableSignature_tab.Size = new System.Drawing.Size(534, 422);
            this.tableSignature_tab.TabIndex = 1;
            this.tableSignature_tab.Text = "Signature";
            this.tableSignature_tab.UseVisualStyleBackColor = true;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.tabTable_tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TableView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "tableView";
            this.Load += new System.EventHandler(this.tableView_Load);
            this.tabTable_tabs.ResumeLayout(false);
            this.tableData_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableData_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTable_tabs;
        private System.Windows.Forms.TabPage tableData_tab;
        private System.Windows.Forms.DataGridView tableData_dg;
        private System.Windows.Forms.TabPage tableSignature_tab;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button quite_btn;
        private System.Windows.Forms.Button save_btn;
    }
}