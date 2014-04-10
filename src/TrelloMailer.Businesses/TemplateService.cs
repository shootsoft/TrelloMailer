using RazorEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloMailer.Businesses
{
    public class TemplateService
    {
        private string path;
        public TemplateService() 
        {
            
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "Data", "Templates");
        }

        public List<string> ListTemplates()
        {
            string[] files = Directory.GetFiles(path, "*.razor");
            List<string> list = new List<string>();
            foreach (var item in files)
            {
                list.Add(Path.GetFileNameWithoutExtension(item));
            }
            return list;
        }

        public string GetTemplate(string fileName)
        {
            string file = Path.Combine(path, fileName + ".razor");
            return File.ReadAllText(file, System.Text.Encoding.UTF8);
        }

        public string Generate(string tp, List<TrelloNet.Board> boards)
        {
            string rx =string.Empty;
            try
            {
                rx = Razor.Parse(tp, boards);
            }
            catch (Exception ex)
            {
                rx = ex.ToString();
            }
            return rx;
        }
    }
}
