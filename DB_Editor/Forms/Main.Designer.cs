namespace DB_Editor.Forms
{
    partial class Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progress_pg = new System.Windows.Forms.ToolStripProgressBar();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.table_dg = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress_pg,
            this.status_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progress_pg
            // 
            this.progress_pg.Name = "progress_pg";
            this.progress_pg.Size = new System.Drawing.Size(100, 16);
            // 
            // status_lbl
            // 
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 17);
            // 
            // table_dg
            // 
            this.table_dg.AllowUserToAddRows = false;
            this.table_dg.AllowUserToDeleteRows = false;
            this.table_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.table_dg.Location = new System.Drawing.Point(291, 51);
            this.table_dg.Name = "table_dg";
            this.table_dg.ReadOnly = true;
            this.table_dg.Size = new System.Drawing.Size(497, 374);
            this.table_dg.TabIndex = 1;
            this.table_dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_dg_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "Table Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 450;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table_dg);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progress_pg;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl;
        private System.Windows.Forms.DataGridView table_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}