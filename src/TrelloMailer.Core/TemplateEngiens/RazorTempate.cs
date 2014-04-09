using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloMailer.Core.TemplateEngiens
{
    public class RazorTempate : ITemplateEngine
    {
        public string Render(string template, List<TrelloNet.Board> bords)
        {
            return string.Empty;
        }
    }
}
