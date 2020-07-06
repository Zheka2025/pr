namespace Lessons2206.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.status_pn = new System.Windows.Forms.StatusStrip();
            this.status_pb = new System.Windows.Forms.ToolStripProgressBar();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_st = new System.Windows.Forms.MenuStrip();
            this.settings_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHeader_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.publicInformation_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.creators_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabNameWindow = new System.Windows.Forms.TabControl();
            this.tablesList_tab = new System.Windows.Forms.TabPage();
            this.tables_dg = new System.Windows.Forms.DataGridView();
            this.queryTB_tab = new System.Windows.Forms.TabPage();
            this.send_query_btn = new System.Windows.Forms.Button();
            this.result_dg = new System.Windows.Forms.DataGridView();
            this.query_tb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.databaseInfo_tab = new System.Windows.Forms.TabPage();
            this.CreateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.status_pn.SuspendLayout();
            this.menu_st.SuspendLayout();
            this.tabNameWindow.SuspendLayout();
            this.tablesList_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tables_dg)).BeginInit();
            this.queryTB_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // status_pn
            // 
            this.status_pn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_pb,
            this.status_lbl});
            this.status_pn.Location = new System.Drawing.Point(0, 535);
            this.status_pn.Name = "status_pn";
            this.status_pn.Size = new System.Drawing.Size(733, 22);
            this.status_pn.TabIndex = 0;
            this.status_pn.Text = "statusStrip1";
            // 
            // status_pb
            // 
            this.status_pb.Name = "status_pb";
            this.status_pb.Size = new System.Drawing.Size(100, 16);
            // 
            // status_lbl
            // 
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 17);
            // 
            // menu_st
            // 
            this.menu_st.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings_btn,
            this.aboutHeader_btn,
            this.CreateTable});
            this.menu_st.Location = new System.Drawing.Point(0, 0);
            this.menu_st.Name = "menu_st";
            this.menu_st.Size = new System.Drawing.Size(733, 24);
            this.menu_st.TabIndex = 1;
            this.menu_st.Text = "menuStrip1";
            this.menu_st.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_st_ItemClicked);
            // 
            // settings_btn
            // 
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(79, 20);
            this.settings_btn.Text = "Настройки";
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // aboutHeader_btn
            // 
            this.aboutHeader_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicInformation_btn,
            this.creators_btn,
            this.about_btn});
            this.aboutHeader_btn.Name = "aboutHeader_btn";
            this.aboutHeader_btn.Size = new System.Drawing.Size(65, 20);
            this.aboutHeader_btn.Text = "Справка";
            // 
            // publicInformation_btn
            // 
            this.publicInformation_btn.Name = "publicInformation_btn";
            this.publicInformation_btn.Size = new System.Drawing.Size(211, 22);
            this.publicInformation_btn.Text = "Публичная информация";
            this.publicInformation_btn.Click += new System.EventHandler(this.publicInformation_btn_Click);
            // 
            // creators_btn
            // 
            this.creators_btn.Name = "creators_btn";
            this.creators_btn.Size = new System.Drawing.Size(211, 22);
            this.creators_btn.Text = "Создатели";
            this.creators_btn.Click += new System.EventHandler(this.creators_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(211, 22);
            this.about_btn.Text = "О программе";
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // tabNameWindow
            // 
            this.tabNameWindow.Controls.Add(this.tablesList_tab);
            this.tabNameWindow.Controls.Add(this.queryTB_tab);
            this.tabNameWindow.Controls.Add(this.databaseInfo_tab);
            this.tabNameWindow.Location = new System.Drawing.Point(0, 41);
            this.tabNameWindow.Name = "tabNameWindow";
            this.tabNameWindow.SelectedIndex = 0;
            this.tabNameWindow.Size = new System.Drawing.Size(733, 491);
            this.tabNameWindow.TabIndex = 2;
            this.tabNameWindow.SelectedIndexChanged += new System.EventHandler(this.tabNameWindow_SelectedIndexChanged);
            // 
            // tablesList_tab
            // 
            this.tablesList_tab.Controls.Add(this.tables_dg);
            this.tablesList_tab.Location = new System.Drawing.Point(4, 22);
            this.tablesList_tab.Name = "tablesList_tab";
            this.tablesList_tab.Padding = new System.Windows.Forms.Padding(3);
            this.tablesList_tab.Size = new System.Drawing.Size(725, 465);
            this.tablesList_tab.TabIndex = 0;
            this.tablesList_tab.Text = "Таблицы";
            this.tablesList_tab.UseVisualStyleBackColor = true;
            // 
            // tables_dg
            // 
            this.tables_dg.AllowUserToAddRows = false;
            this.tables_dg.AllowUserToDeleteRows = false;
            this.tables_dg.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.tables_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tables_dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tables_dg.Location = new System.Drawing.Point(3, 3);
            this.tables_dg.Name = "tables_dg";
            this.tables_dg.Size = new System.Drawing.Size(719, 459);
            this.tables_dg.TabIndex = 0;
            this.tables_dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tables_dg_CellContentClick);
            this.tables_dg.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tables_dg_CellClick);
            // 
            // queryTB_tab
            // 
            this.queryTB_tab.Controls.Add(this.send_query_btn);
            this.queryTB_tab.Controls.Add(this.result_dg);
            this.queryTB_tab.Controls.Add(this.query_tb);
            this.queryTB_tab.Location = new System.Drawing.Point(4, 22);
            this.queryTB_tab.Name = "queryTB_tab";
            this.queryTB_tab.Padding = new System.Windows.Forms.Padding(3);
            this.queryTB_tab.Size = new System.Drawing.Size(725, 465);
            this.queryTB_tab.TabIndex = 1;
            this.queryTB_tab.Text = "Запрос";
            this.queryTB_tab.UseVisualStyleBackColor = true;
            this.queryTB_tab.Click += new System.EventHandler(this.queryTB_tab_Click);
            // 
            // send_query_btn
            // 
            this.send_query_btn.Location = new System.Drawing.Point(603, 275);
            this.send_query_btn.Name = "send_query_btn";
            this.send_query_btn.Size = new System.Drawing.Size(121, 189);
            this.send_query_btn.TabIndex = 2;
            this.send_query_btn.Text = "Выполнить";
            this.send_query_btn.UseVisualStyleBackColor = true;
            this.send_query_btn.Click += new System.EventHandler(this.send_query_btn_Click);
            // 
            // result_dg
            // 
            this.result_dg.AllowUserToAddRows = false;
            this.result_dg.AllowUserToDeleteRows = false;
            this.result_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dg.Location = new System.Drawing.Point(0, 272);
            this.result_dg.Name = "result_dg";
            this.result_dg.ReadOnly = true;
            this.result_dg.Size = new System.Drawing.Size(591, 193);
            this.result_dg.TabIndex = 1;
            // 
            // query_tb
            // 
            this.query_tb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.query_tb.AutoScrollMinSize = new System.Drawing.Size(51, 14);
            this.query_tb.BackBrush = null;
            this.query_tb.CharHeight = 14;
            this.query_tb.CharWidth = 8;
            this.query_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.query_tb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.query_tb.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.query_tb.IsReplaceMode = false;
            this.query_tb.Location = new System.Drawing.Point(-4, 0);
            this.query_tb.Name = "query_tb";
            this.query_tb.Paddings = new System.Windows.Forms.Padding(0);
            this.query_tb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.query_tb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("query_tb.ServiceColors")));
            this.query_tb.Size = new System.Drawing.Size(729, 331);
            this.query_tb.TabIndex = 0;
            this.query_tb.Text = "USE";
            this.query_tb.Zoom = 100;
            this.query_tb.Load += new System.EventHandler(this.query_tb_Load);
            // 
            // databaseInfo_tab
            // 
            this.databaseInfo_tab.Location = new System.Drawing.Point(4, 22);
            this.databaseInfo_tab.Name = "databaseInfo_tab";
            this.databaseInfo_tab.Size = new System.Drawing.Size(725, 465);
            this.databaseInfo_tab.TabIndex = 2;
            this.databaseInfo_tab.Text = "Информация";
            this.databaseInfo_tab.UseVisualStyleBackColor = true;
            // 
            // CreateTable
            // 
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(110, 20);
            this.CreateTable.Text = "Создать таблицу";
            this.CreateTable.Click += new System.EventHandler(this.CreateTable_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 557);
            this.Controls.Add(this.tabNameWindow);
            this.Controls.Add(this.status_pn);
            this.Controls.Add(this.menu_st);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu_st;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel | Data Base Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.status_pn.ResumeLayout(false);
            this.status_pn.PerformLayout();
            this.menu_st.ResumeLayout(false);
            this.menu_st.PerformLayout();
            this.tabNameWindow.ResumeLayout(false);
            this.tablesList_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tables_dg)).EndInit();
            this.queryTB_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status_pn;
        private System.Windows.Forms.MenuStrip menu_st;
        private System.Windows.Forms.ToolStripMenuItem aboutHeader_btn;
        private System.Windows.Forms.ToolStripMenuItem publicInformation_btn;
        private System.Windows.Forms.ToolStripMenuItem creators_btn;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
        private System.Windows.Forms.ToolStripProgressBar status_pb;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl;
        private System.Windows.Forms.ToolStripMenuItem settings_btn;
        private System.Windows.Forms.TabControl tabNameWindow;
        private System.Windows.Forms.TabPage tablesList_tab;
        private System.Windows.Forms.DataGridView tables_dg;
        private System.Windows.Forms.TabPage queryTB_tab;
        private System.Windows.Forms.TabPage databaseInfo_tab;
        private FastColoredTextBoxNS.FastColoredTextBox query_tb;
        private System.Windows.Forms.Button send_query_btn;
        private System.Windows.Forms.DataGridView result_dg;
        private System.Windows.Forms.ToolStripMenuItem CreateTable;
    }
}

