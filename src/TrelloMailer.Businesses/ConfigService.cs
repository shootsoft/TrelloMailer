using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloMailer.Models;

namespace TrelloMailer.Businesses
{
    public class ConfigService
    {
        private string path;

        public ConfigService()
        {
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TrelloMailer.config");
        }

        /// <summary>
        /// Save config to path
        /// </summary>
        /// <param name="cfg"></param>
        public void Save(Config cfg)
        {
            if(cfg!=null)
            { 
                string str = JsonConvert.SerializeObject(cfg, Formatting.Indented);
                try
                {
                    File.WriteAllText(path, str, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex) ;
                }
            }
        }

        /// <summary>
        /// Load config
        /// </summary>
        /// <returns></returns>
        public Config Load()
        {
            Config cfg = new Config();
            if (File.Exists(path))
            {
                try
                {
                    string str = File.ReadAllText(path, Encoding.UTF8);
                    cfg = JsonConvert.DeserializeObject<Config>(str);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            return cfg;
        }
    }
}
