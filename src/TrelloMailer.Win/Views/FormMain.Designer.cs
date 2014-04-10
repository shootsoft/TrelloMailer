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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.TextEditorSource = new ICSharpCode.TextEditor.TextEditorControl();
            this.webBrowserPreview = new System.Windows.Forms.WebBrowser();
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
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonRefresh,
            this.ButtonSend,
            this.toolStripLabel1,
            this.ComboBoxTemplates,
            this.toolStripLabel2,
            this.ComboBoxEmail});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 31);
            this.toolStrip1.TabIndex = 2;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRefreshFavorites,
            this.MenuItemRefreshAll});
            this.ButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.Image")));
            this.ButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(86, 28);
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.ButtonClick += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // MenuItemRefreshFavorites
            // 
            this.MenuItemRefreshFavorites.Name = "MenuItemRefreshFavorites";
            this.MenuItemRefreshFavorites.Size = new System.Drawing.Size(153, 22);
            this.MenuItemRefreshFavorites.Text = "Refresh Starred";
            this.MenuItemRefreshFavorites.Click += new System.EventHandler(this.MenuItemRefreshFavorites_Click);
            // 
            // MenuItemRefreshAll
            // 
            this.MenuItemRefreshAll.Name = "MenuItemRefreshAll";
            this.MenuItemRefreshAll.Size = new System.Drawing.Size(153, 22);
            this.MenuItemRefreshAll.Text = "Refresh All";
            this.MenuItemRefreshAll.Click += new System.EventHandler(this.MenuItemRefreshAll_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSend.Image")));
            this.ButtonSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(61, 28);
            this.ButtonSend.Text = "Send";
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 28);
            this.toolStripLabel1.Text = "Email Template";
            // 
            // ComboBoxTemplates
            // 
            this.ComboBoxTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTemplates.Name = "ComboBoxTemplates";
            this.ComboBoxTemplates.Size = new System.Drawing.Size(121, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 28);
            this.toolStripLabel2.Text = "Email List";
            // 
            // ComboBoxEmail
            // 
            this.ComboBoxEmail.Name = "ComboBoxEmail";
            this.ComboBoxEmail.Size = new System.Drawing.Size(121, 31);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreeViewBoards);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(708, 269);
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
            this.TreeViewBoards.Size = new System.Drawing.Size(236, 269);
            this.TreeViewBoards.TabIndex = 0;
            this.TreeViewBoards.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewBoards_BeforeSelect);
            this.TreeViewBoards.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewBoards_AfterSelect);
            this.TreeViewBoards.Click += new System.EventHandler(this.TreeViewBoards_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageDetails);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageDetails
            // 
            this.TabPageDetails.Controls.Add(this.splitContainer2);
            this.TabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.TabPageDetails.Name = "TabPageDetails";
            this.TabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDetails.Size = new System.Drawing.Size(460, 243);
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
            this.splitContainer2.Size = new System.Drawing.Size(454, 237);
            this.splitContainer2.SplitterDistance = 154;
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
            this.ListViewCards.Size = new System.Drawing.Size(454, 154);
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
            this.TextEditorCard.Size = new System.Drawing.Size(454, 79);
            this.TextEditorCard.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 243);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Preview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.TextEditorSource);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.webBrowserPreview);
            this.splitContainer3.Size = new System.Drawing.Size(454, 237);
            this.splitContainer3.SplitterDistance = 190;
            this.splitContainer3.TabIndex = 0;
            // 
            // TextEditorSource
            // 
            this.TextEditorSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditorSource.IsReadOnly = false;
            this.TextEditorSource.Location = new System.Drawing.Point(0, 0);
            this.TextEditorSource.Name = "TextEditorSource";
            this.TextEditorSource.Size = new System.Drawing.Size(190, 237);
            this.TextEditorSource.TabIndex = 0;
            // 
            // webBrowserPreview
            // 
            this.webBrowserPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPreview.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPreview.Name = "webBrowserPreview";
            this.webBrowserPreview.Size = new System.Drawing.Size(260, 237);
            this.webBrowserPreview.TabIndex = 0;
            this.webBrowserPreview.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserPreview_DocumentCompleted);
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
            this.Load += new System.EventHandler(this.FormMain_Load);
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
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
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
        public System.Windows.Forms.ToolStripMenuItem trelloToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripSplitButton ButtonRefresh;
        public System.Windows.Forms.ToolStripMenuItem MenuItemRefreshFavorites;
        public System.Windows.Forms.ToolStripMenuItem MenuItemRefreshAll;
        public System.Windows.Forms.ColumnHeader columnHeaderCardName;
        public System.Windows.Forms.ColumnHeader columnHeaderCardDue;
        public System.Windows.Forms.ColumnHeader columnHeaderCardMembers;
        public System.Windows.Forms.ColumnHeader columnHeaderCardLabels;
        public ICSharpCode.TextEditor.TextEditorControl TextEditorCard;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.SplitContainer splitContainer3;
        public ICSharpCode.TextEditor.TextEditorControl TextEditorSource;
        public System.Windows.Forms.WebBrowser webBrowserPreview;
    }
}

