using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloMailer.Core.Controllers;

namespace TrelloMailer.Core.Plugins
{
    public interface IPlugin
    {
        void OnLoad(IController controller);
    }
}
