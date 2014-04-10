using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrelloMailer.Businesses;
using TrelloMailer.Core.Controllers;
using TrelloMailer.Models;
using TrelloMailer.Win.Actions;
using TrelloNet;

namespace TrelloMailer.Win.Controllers
{

    public class MainController : IController
    {
        public FormMain View { get; set; }
        public TrelloService TrelloSerivce { get; set; }
        public ConfigService ConfigService { get; set; }
        public TemplateService TemplateService { get; set; }
        public MailService MailService { get; set; }

        public Config Config { get; set; }

        public Dictionary<string, AbstractAction<MainController>> Actions { get; set; }

        private AbstractAction<MainController> action;

        private BoardDb<TreeNode> boardDb;

        public MainController()
        {
            ConfigService = new ConfigService();
            TemplateService = new TemplateService();
            Config = ConfigService.Load();
            TrelloSerivce = new TrelloService(Config.Key);
            MailService = new MailService(Config.Mail);

            this.View = new FormMain(this);
            InitBoards();
            LoadActions();
            LoadView();

            Application.Run(this.View);
        }

        private void LoadActions()
        {
            Actions = new Dictionary<string, AbstractAction<MainController>>();
            Actions.Add(ActionRes.LoadBoard, new LoadBoardAction(this));
            Actions.Add(ActionRes.LoadCard, new LoadCardAction(this));
        }

        private void InitBoards()
        {
            boardDb = new BoardDb<TreeNode>();
            var boardList = TrelloSerivce.Load();
            if (boardList != null)
            {
                foreach (var item in boardList)
                {
                    AddBoard(item);
                }
            }
        }

        ~MainController()
        {
            ConfigService.Save(Config);
            TrelloSerivce.Save(boardDb.Values);
        }


        public void RunAction(string actionName, object arg = null)
        {
            if (Actions.ContainsKey(actionName) && (action == null || !action.IsBusy))
            {
                action = Actions[actionName];
                action.RunWorkerAsync(arg);

            }
            else
            {
                Debug.WriteLine("Empty Action Name: " + actionName);
            }
        }


        public void AddBoard(Board b)
        {
            TreeNode n = null;
            if (!boardDb.ContainsKey(b.Id))
            {
                n = new TreeNode(b.Name);
                View.TreeViewBoards.Nodes.Add(n);
            }
            else
            {
                n = boardDb.GetT(b.Id);
            }
            if (n != null)
            {
                n.Tag = b;
                n.Checked = b.Starred;
                n.Nodes.Clear();
                foreach (var list in b.Lists)
                {
                    TreeNode nl = new TreeNode(list.Name);
                    nl.Tag = list;
                    nl.Checked = b.Starred;
                    n.Nodes.Add(nl);

                }
                boardDb.Add(n, b);
            }

        }


        public void Lock()
        {
            View.toolStrip1.Enabled = false;
        }

        public void Unlock()
        {
            View.toolStrip1.Enabled = true;
        }



        internal void ShowCard()
        {
            string summary = string.Empty;
            if (View.ListViewCards.SelectedItems != null && View.ListViewCards.SelectedItems.Count > 0)
            {
                Card c = View.ListViewCards.SelectedItems[0].Tag as Card;
                if (c != null)
                {
                    summary = c.Summary();
                }
            }
            View.TextEditorCard.Text = summary;
        }

        internal void SendMail()
        {
            if(View.ComboBoxTemplates.SelectedIndex>=0 &&
                View.ComboBoxTemplates.SelectedIndex>=0)
            { 
                string tp = TemplateService.GetTemplate(View.ComboBoxTemplates.SelectedItem.ToString());
                List<Board> boards = GetSelectedBoard();
                if (boards.Count > 0)
                { 
                    string mail = TemplateService.Generate(tp, boards );
                    View.TextEditorSource.Text = mail;
                    View.webBrowserPreview.Navigate("about:blank");
                    //View.webBrowserPreview.Document.Write(mail);
                    View.tabControl1.SelectedIndex = 1;
                }
            }
            //
        }

        public List<Board> GetSelectedBoard()
        {
            List<Board> boards = new List<Board>();
            foreach (TreeNode tv in View.TreeViewBoards.Nodes)
            {
                Board b = tv.Tag as Board;

                if (tv.Checked && b != null)
                {
                    boards.Add(b);
                    b.Lists.Clear();
                    foreach (TreeNode tl in tv.Nodes)
                    {
                        List l = tl.Tag as List;
                        if (tl.Checked && l != null)
                        {
                            b.Lists.Add(l);
                        }
                    }
                }
            }
            return boards;
        }

        public void LoadView()
        {
            List<string> templates = TemplateService.ListTemplates();
            foreach (var item in templates)
            {
                View.ComboBoxTemplates.Items.Add(item);
            }
            View.ComboBoxTemplates.SelectedIndex = 0;
        }
    }
}
