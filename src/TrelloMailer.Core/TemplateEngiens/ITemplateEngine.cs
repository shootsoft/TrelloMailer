using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloNet;

namespace TrelloMailer.Core.TemplateEngiens
{
    public interface ITemplateEngine
    {
        string Render(string template, List<Board> bords);
    }
}
