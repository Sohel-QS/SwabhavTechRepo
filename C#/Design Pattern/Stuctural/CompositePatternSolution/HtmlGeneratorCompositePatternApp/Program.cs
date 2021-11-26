using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlGeneratorCompositePatternApp.Tags;
using HtmlGeneratorCompositePatternApp.Model;

namespace HtmlGeneratorCompositePatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlGenerator generator = new HtmlGenerator();

            var root = new GroupTag("div");

            var label1 = new GroupTag("div");
            var labelText1 = new GroupTag("p","UserName :");
            labelText1.AddTag(new IndividualTag("input", "text"));
            label1.AddTag(labelText1);


            var label2 = new GroupTag("div");
            var labelText2 = new GroupTag("p", "Password :");
            labelText2.AddTag(new IndividualTag("input", "password"));
            label2.AddTag(labelText2);

            root.AddTag(label1);
            root.AddTag(label2);
            root.AddTag(new IndividualTag("input", "Submit"));

            Console.WriteLine(root.Render(0));

            generator.Generate(root.Render(0));
        }
    }
}
