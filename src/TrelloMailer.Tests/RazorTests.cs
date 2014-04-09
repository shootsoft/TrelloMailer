using NUnit.Framework;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloMailer.Tests
{
    [TestFixture]
    public class RazorTests
    {
        public class Model
        {
            public string Name { get; set; }
        }

        public void ArrayTest()
        {
            string tp = @"@{int i=0;}
            @foreach(var a in Model){i++;<label>@i</label> <span>@a.Name</span>
for(int x=0;x<2;x++){
    <label>@x</label>
}
}";
            string result = Razor.Parse(tp, new Model[]
            {
                new Model(){ Name= "Name1"},
                new Model(){ Name= "Name2"},

            });
            Debug.WriteLine(result);

        }
    }
}
