using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloMailer.Core;
using TrelloNet;

namespace TrelloMailer.Businesses
{
    public class TrelloService
    {
        private TrelloClient client;
        private string path;


        public TrelloService(string key)
        {
            client = new TrelloClient(key);
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TrelloMailer.db");

        }

        public List<Board> Load()
        {
            List<Board> boards = new List<Board>();
            if (File.Exists(path))
            {
                try
                {
                    string str = File.ReadAllText(path, Encoding.UTF8);
                    boards = JsonConvert.DeserializeObject<List<Board>>(str);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            return boards;
        }

        public void Save(IEnumerable<Board> boards)
        {
            if (boards != null)
            {
                string str = JsonConvert.SerializeObject(boards, Formatting.Indented);
                try
                {
                    File.WriteAllText(path, str, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }

        }

        public List<Board> GetStarredBoards(BackgroundWorker worker)
        {
            return client.GetAllBoards(worker, BoardFilter.Starred, ListFilter.Open);

        }

        public List<Board> GetBoards(BackgroundWorker worker)
        {
            return client.GetAllBoards(worker);
        }



        public void LoadCards(BackgroundWorker worker, List list)
        {
            client.RefreshList(worker, new List[]{ list });
        }
    }
}
