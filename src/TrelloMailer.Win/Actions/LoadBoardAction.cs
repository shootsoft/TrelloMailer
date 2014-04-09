using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrelloMailer.Win.Controllers;
using TrelloNet;

namespace TrelloMailer.Win.Actions
{
    public class LoadBoardAction : AbstractAction<MainController>
    {
        public LoadBoardAction(MainController controller)
            : base(controller)
        {

        }

        public override bool AutoLock
        {
            get { return true; }
        }

        protected override void BeforeRun(object arg)
        {
            base.BeforeRun(arg);
            controller.View.toolStripStatusLabel1.Text = "Loading 0%";
        }

        protected override void OnDoWork(System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnDoWork(e);
            if (e.Argument == null)
            {
                List<Board> boards = controller.TrelloSerivce.GetStarredBoards(this);
            }
            else if(e.Argument.ToString() == "all")
            {
                List<Board> boards = controller.TrelloSerivce.GetBoards(this);
            }
        }
        protected override void OnProgressChanged(System.ComponentModel.ProgressChangedEventArgs e)
        {
            base.OnProgressChanged(e);
            controller.View.toolStripStatusLabel1.Text = string.Format("Loading {0}%", e.ProgressPercentage);
            if (e.UserState != null)
            {
                Board b = e.UserState as Board;
                if (b != null)
                {
                    controller.AddBoard(b);
                }
            }
        }

        protected override void OnRunWorkerCompleted(System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnRunWorkerCompleted(e);
            controller.View.toolStripStatusLabel1.Text = "Done";
        }


 

 
    }
}
