using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloMailer.Models
{
    public class Config
    {
        public string Key { get; set; }
        public MailConfig Mail { get; set; }
        public List<MailReceiver> MailList { get; set; }
        public List<KeyValuePair<string, string>> LabelIcons { get; set; }

        public Config()
        {
            Mail = new MailConfig();
            MailList = new List<MailReceiver>();
        }
    }
}
