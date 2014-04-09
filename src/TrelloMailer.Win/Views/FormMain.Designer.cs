namespace TrelloMailer.Win
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trelloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonRefresh = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuItemRefreshFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRefreshAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSend = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxTemplates = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxEmail = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeViewBoards = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageDetails = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ListViewCards = new System.Windows.Forms.ListView();
            this.columnHeaderCardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCardDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCardMembers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCardLabels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextEditorCard = new ICSharpCode.TextEditor.TextEditorControl();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trelloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trelloToolStripMenuItem
            // 
            this.trelloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.trelloToolStripMenuItem.Name = "trelloToolStripMenuItem";
            this.trelloToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.trelloToolStripMenuItem.Text = "Trello";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonRefresh,
            this.ButtonSend,
            this.toolStripLabel1,
            this.ComboBoxTemplates,
            this.toolStripLabel2,
            this.ComboBoxEmail});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRefreshFavorites,
            this.MenuItemRefreshAll});
            this.ButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.Image")));
            this.ButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(78, 22);
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.ButtonClick += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // MenuItemRefreshFavorites
            // 
            this.MenuItemRefreshFavorites.Name = "MenuItemRefreshFavorites";
            this.MenuItemRefreshFavorites.Size = new System.Drawing.Size(163, 22);
            this.MenuItemRefreshFavorites.Text = "Refresh Favorites";
            this.MenuItemRefreshFavorites.Click += new System.EventHandler(this.MenuItemRefreshFavorites_Click);
            // 
            // MenuItemRefreshAll
            // 
            this.MenuItemRefreshAll.Name = "MenuItemRefreshAll";
            this.MenuItemRefreshAll.Size = new System.Drawing.Size(163, 22);
            this.MenuItemRefreshAll.Text = "Refresh All";
            this.MenuItemRefreshAll.Click += new System.EventHandler(this.MenuItemRefreshAll_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSend.Image")));
            this.ButtonSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(53, 22);
            this.ButtonSend.Text = "Send";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel1.Text = "Email Template";
            // 
            // ComboBoxTemplates
            // 
            this.ComboBoxTemplates.Name = "ComboBoxTemplates";
            this.ComboBoxTemplates.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel2.Text = "Email List";
            // 
            // ComboBoxEmail
            // 
            this.ComboBoxEmail.Name = "ComboBoxEmail";
            this.ComboBoxEmail.Size = new System.Drawing.Size(121, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreeViewBoards);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(708, 275);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 3;
            // 
            // TreeViewBoards
            // 
            this.TreeViewBoards.CheckBoxes = true;
            this.TreeViewBoards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewBoards.FullRowSelect = true;
            this.TreeViewBoards.HideSelection = false;
            this.TreeViewBoards.Location = new System.Drawing.Point(0, 0);
            this.TreeViewBoards.Name = "TreeViewBoards";
            this.TreeViewBoards.Size = new System.Drawing.Size(236, 275);
            this.TreeViewBoards.TabIndex = 0;
            this.TreeViewBoards.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewBoards_BeforeSelect);
            this.TreeViewBoards.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewBoards_AfterSelect);
            this.TreeViewBoards.Click += new System.EventHandler(this.TreeViewBoards_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 275);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageDetails
            // 
            this.TabPageDetails.Controls.Add(this.splitContainer2);
            this.TabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.TabPageDetails.Name = "TabPageDetails";
            this.TabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDetails.Size = new System.Drawing.Size(460, 249);
            this.TabPageDetails.TabIndex = 0;
            this.TabPageDetails.Text = "Details";
            this.TabPageDetails.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ListViewCards);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TextEditorCard);
            this.splitContainer2.Size = new System.Drawing.Size(454, 243);
            this.splitContainer2.SplitterDistance = 158;
            this.splitContainer2.TabIndex = 0;
            // 
            // ListViewCards
            // 
            this.ListViewCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCardName,
            this.columnHeaderCardDue,
            this.columnHeaderCardMembers,
            this.columnHeaderCardLabels});
            this.ListViewCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewCards.FullRowSelect = true;
            this.ListViewCards.HideSelection = false;
            this.ListViewCards.Location = new System.Drawing.Point(0, 0);
            this.ListViewCards.Name = "ListViewCards";
            this.ListViewCards.Size = new System.Drawing.Size(454, 158);
            this.ListViewCards.TabIndex = 0;
            this.ListViewCards.UseCompatibleStateImageBehavior = false;
            this.ListViewCards.View = System.Windows.Forms.View.Details;
            this.ListViewCards.SelectedIndexChanged += new System.EventHandler(this.ListViewCards_SelectedIndexChanged);
            // 
            // columnHeaderCardName
            // 
            this.columnHeaderCardName.Text = "Name";
            this.columnHeaderCardName.Width = 200;
            // 
            // columnHeaderCardDue
            // 
            this.columnHeaderCardDue.Text = "Due Date";
            this.columnHeaderCardDue.Width = 100;
            // 
            // columnHeaderCardMembers
            // 
            this.columnHeaderCardMembers.Text = "Members";
            // 
            // columnHeaderCardLabels
            // 
            this.columnHeaderCardLabels.Text = "Labels";
            // 
            // TextEditorCard
            // 
            this.TextEditorCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditorCard.IsReadOnly = false;
            this.TextEditorCard.Location = new System.Drawing.Point(0, 0);
            this.TextEditorCard.Name = "TextEditorCard";
            this.TextEditorCard.Size = new System.Drawing.Size(454, 81);
            this.TextEditorCard.TabIndex = 0;
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.WorkerSupportsCancellation = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 346);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Trello Mailer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabPageDetails.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TreeView TreeViewBoards;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage TabPageDetails;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripComboBox ComboBoxTemplates;
        public System.Windows.Forms.ToolStripLabel toolStripLabel2;
        public System.Windows.Forms.ToolStripComboBox ComboBoxEmail;
        public System.Windows.Forms.ToolStripButton ButtonSend;
        public System.ComponentModel.BackgroundWorker Worker;
        public System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.ListView ListViewCards;
        private System.Windows.Forms.ToolStripMenuItem trelloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton ButtonRefresh;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRefreshFavorites;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRefreshAll;
        private System.Windows.Forms.ColumnHeader columnHeaderCardName;
        private System.Windows.Forms.ColumnHeader columnHeaderCardDue;
        private System.Windows.Forms.ColumnHeader columnHeaderCardMembers;
        private System.Windows.Forms.ColumnHeader columnHeaderCardLabels;
        public ICSharpCode.TextEditor.TextEditorControl TextEditorCard;
    }
}

