using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloMailer.Models;

namespace TrelloMailer.Businesses
{
    public class MailService
    {
        private MailConfig cfg;
        private string path;
        public MailService(MailConfig cfg)
        {
            this.cfg = cfg;
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                "Data", "Icons");
        }

        public bool Send(string subject, string body, bool isHtml, IEnumerable<MailReceiver> receivers)
        {
            return false;
        }
    }
}
