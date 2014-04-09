using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloMailer.Core.Controllers
{
    public interface IController
    {
        void Lock();
        void Unlock();
    }
}
