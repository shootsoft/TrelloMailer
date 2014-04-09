using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrelloNet;

namespace TrelloMailer.Models
{
    public class BoardDb<T> : Dictionary<string, Board>
    {
        public Dictionary<string, T> IndexBoard { get; protected set; }

        public BoardDb()
        {
            IndexBoard = new Dictionary<string, T>();
        }

        public void Add(T n, Board b)
        {
            IndexBoard[b.Id] = n;
            this[b.Id] = b;
        }

        public T GetT(string key)
        {
            if (IndexBoard.ContainsKey(key))
            {
                return IndexBoard[key];
            }
            else 
            {
                return default(T);
            }
        }
    }
}
