using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloMailer.Core.Controllers;
using TrelloMailer.Win.Controllers;

namespace TrelloMailer.Win.Actions
{


    public abstract class AbstractAction<T> : BackgroundWorker 
        where T : IController
    {
        protected T controller;

        public abstract bool AutoLock { get; }
        public AbstractAction(T controller)
        {
            this.controller = controller;
            this.WorkerSupportsCancellation = true;
            this.WorkerReportsProgress = true;
        }

        public new void RunWorkerAsync()
        {
            BeforeRun();
            base.RunWorkerAsync();
        }

        public new void RunWorkerAsync(object arg)
        {
            BeforeRun(arg);
            base.RunWorkerAsync(arg);
        }

        protected virtual void BeforeRun()
        {
            BeforeRun(null);
        }

        protected virtual void BeforeRun(object arg)
        {
            if (this.AutoLock)
            {
                controller.Lock();
            }
        }


        protected override void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            base.OnRunWorkerCompleted(e);
            if (AutoLock)
            {
                controller.Unlock();
            }
        }
    }
}
