//using TrelloMailer.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using TrelloNet;

namespace TrelloMailer.Core
{
    public class TrelloClient: Trello
    {
        Dictionary<string, Member> members;

        const string TOKEN_FILE = "token.pwd";

        //public Trello trello = null;

        public TrelloClient(string key):base(key)
        {
            if ((key + "").Length == 0)
            {
                throw new Exception("Empty key");
            }
            //trello = new Trello(key);
            GetAuthorize();
            members = new Dictionary<string, Member>();
        }

        /// <summary>
        /// 获取授权
        /// </summary>
        /// <returns></returns>
        public bool GetAuthorize()
        {
            string token = string.Empty;
            FileInfo fi = new FileInfo(TOKEN_FILE);
            if (fi.Exists && (DateTime.Now - fi.LastWriteTime).TotalDays<30)
            {
                token = File.ReadAllText(TOKEN_FILE, Encoding.UTF8);
            }
            else
            {
                string url = this.GetAuthorizationUrl("Trello Mailer", Scope.ReadWrite).ToString();
                TrelloAuthorizeForm frm = new TrelloAuthorizeForm(url);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    token = frm.GetToken();
                    File.WriteAllText(TOKEN_FILE, token, Encoding.UTF8);
                }

            }
            this.Authorize(token);
            return true;
            
        }

        /// <summary>
        /// 创建新的List
        /// </summary>
        /// <param name="board"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CreateListWithName(Board board, string name)
        {
            bool r = false;
            List list = null;
            if (board != null)
            {
                bool exist = false;
                var lists= this.Lists.ForBoard(board, ListFilter.Open);
                foreach (var item in lists)
                {
                    if (item.Name == name)
                    {
                        list = item;
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    list = this.Lists.Add(name, board);
                    r = list != null;
                }

                if(exist || r)
                {
                    this.Lists.ChangePos(list, Position.Bottom);
                }
            }
            return r;
        }

        /// <summary>
        /// Get all borads for me
        /// </summary>
        /// <returns></returns>
        public List<Board> GetAllBoards(BackgroundWorker worker)
        {

            return GetAllBoards(worker, BoardFilter.Open, ListFilter.Open);
        }

        /// <summary>
        /// Get all borads for me
        /// </summary>
        /// <returns></returns>
        public List<Board> GetAllBoards(BackgroundWorker worker, BoardFilter boardFilter, ListFilter listFilter)
        {
            List<Board> boards = new List<Board>();
            var blist = this.Boards.ForMe(boardFilter);
            boards.AddRange(blist);
            for (int i = 0; i < boards.Count; i++)
			{
                //if(boards[i].)
                var llist = this.Lists.ForBoard(boards[i], listFilter);
                boards[i].Lists.AddRange(llist);
                if (worker != null && worker.WorkerReportsProgress)
                {
                    worker.ReportProgress((i+1) * 100 / boards.Count, boards[i]);
                }
               
			}
           
            return boards;
        }

        /// <summary>
        /// Refresh list with cards & cards' members updated
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public void RefreshList(BackgroundWorker worker, IEnumerable<List> lists)
        {
            if (lists == null) return;

            int i = 0;
            int count = lists.Count();
            foreach (var l in lists)
            {
                i++;
                if (worker != null)
                {
                    worker.ReportProgress(i * 100 / count, l);
                }
                var clist = this.Cards.ForList(l, CardFilter.Open);
                if (clist != null)
                {
                    l.Cards.AddRange(clist);
                    foreach (var c in clist)
                    {
                        RefreshCard(c);
                    }
                }
            }
          
        }

        /// <summary>
        /// Refresh card's member information
        /// </summary>
        /// <param name="c"></param>
        public void RefreshCard(Card c)
        {
            #region Load card
            if (c.IdMembers != null)
            {
                foreach (var id in c.IdMembers)
                {
                    if (members.ContainsKey(id))
                    {
                        c.Members.Add(members[id]);
                    }
                    else
                    {
                        Member m = this.Members.WithId(id);
                        if (m != null)
                        {
                            members.Add(id, m);
                            c.Members.Add(m);
                        }
                        else
                        {
                            members.Add(id, new Member());
                        }
                    }
                }
            }
            #endregion
        }

        public object RefreshList(BackgroundWorker worker, List list)
        {
            throw new NotImplementedException();
        }
    }
}
