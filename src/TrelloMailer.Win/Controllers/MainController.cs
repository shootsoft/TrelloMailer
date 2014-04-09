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
    public delegate void StartAction();
    public delegate void EndAction();

    public class MainController: IController
    {
        public FormMain View { get; set; }
        public TrelloService TrelloSerivce { get; set; }
        public ConfigService ConfigService { get; set; }
        public Config Config { get; set; }

        public Dictionary<string, AbstractAction<MainController>> Actions { get; set; }

        private AbstractAction<MainController> action;

        private BoardDb<TreeNode> boardDb;

        public MainController()
        {
            ConfigService = new ConfigService();
            Config = ConfigService.Load();
            TrelloSerivce = new TrelloService(Config.Key);
            
            this.View = new FormMain(this);
            InitBoards();
            LoadActions();
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
            if (boardList!=null)
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


        public void RunAction(string actionName, object arg=null)
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
                n.Checked = b.Starred ;
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
            if(View.ListViewCards.SelectedItems!=null && View.ListViewCards.SelectedItems.Count>0)
            {
                Card c= View.ListViewCards.SelectedItems[0].Tag as Card;
                if (c != null)
                {
                    summary = c.Summary();
                }
            }
            View.TextEditorCard.Text = summary;
        }
    }
}
