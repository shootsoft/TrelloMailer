using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrelloMailer.Win.Actions;
using TrelloMailer.Win.Controllers;

namespace TrelloMailer.Win
{
    public partial class FormMain : Form
    {
        private Controllers.MainController mainController;



        public FormMain(Controllers.MainController mainController)
        {
            // TODO: Complete member initialization
            this.mainController = mainController;

            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            mainController.RunAction(ActionRes.LoadBoard);
        }

        private void MenuItemRefreshFavorites_Click(object sender, EventArgs e)
        {
            mainController.RunAction(ActionRes.LoadBoard);
        }

        private void MenuItemRefreshAll_Click(object sender, EventArgs e)
        {
            mainController.RunAction(ActionRes.LoadBoard, "all");
        }

        private void TreeViewBoards_Click(object sender, EventArgs e)
        {
            //if(TreeViewBoards)
            
        }

        private void TreeViewBoards_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void TreeViewBoards_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != null)
            {
                mainController.RunAction(ActionRes.LoadCard, e.Node.Tag);
            }
        }

        private void ListViewCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainController.ShowCard();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            mainController.SendMail();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            webBrowserPreview.Navigate("about:blank");
        }

        private void webBrowserPreview_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowserPreview.Document.Write(TextEditorSource.Text);
        }


    }
}
