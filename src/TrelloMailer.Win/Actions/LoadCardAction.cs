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
    public class LoadCardAction : AbstractAction<MainController>
    {

        public LoadCardAction(MainController mainController)
            : base(mainController)
        {

        }
        public override bool AutoLock
        {
            get { return true; }
        }



        protected override void BeforeRun(object arg)
        {
            base.BeforeRun(arg);
            controller.View.TreeViewBoards.Enabled = false;
            controller.View.toolStripStatusLabel1.Text = "Loading cards ...";
        }

        protected override void OnDoWork(System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnDoWork(e);
            List list = e.Argument as List;
            if (list != null)
            {
                if (list.Cards.Count == 0)
                {
                    this.controller.TrelloSerivce.LoadCards(this, list);
                }
                e.Result = list.Cards;
            }
        }

        protected override void OnRunWorkerCompleted(System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnRunWorkerCompleted(e);
            this.controller.View.ListViewCards.Items.Clear();
            if (e.Result != null)
            {

                List<Card> cards = e.Result as List<Card>;
                foreach (var c in cards)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        c.Name, 
                        c.Due.HasValue?c.Due.Value.ToString(): "-",
                        string.Join<Member>(",", c.Members),
                        string.Join<Card.Label>(",", c.Labels )
                    });
                    item.Tag = c;
                    controller.View.ListViewCards.Items.Add(item);

                }
                controller.View.ListViewCards.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            controller.View.TreeViewBoards.Enabled = true;
            controller.View.toolStripStatusLabel1.Text = "Done";

        }


    }
}
