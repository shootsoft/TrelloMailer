using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloMailer.Models
{
    public class MailConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string From { get; set; }
        public bool EnableSsl { get; set; }
    }

    public class MailReceiver
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
