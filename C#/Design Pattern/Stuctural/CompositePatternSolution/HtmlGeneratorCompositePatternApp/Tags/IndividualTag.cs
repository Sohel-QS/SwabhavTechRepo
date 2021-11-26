using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGeneratorCompositePatternApp.Tags
{
    class IndividualTag : ITag
    {
        private string _tagName;
        private string _text;
        public IndividualTag(string tagName, string text="")
        {
            this._tagName = tagName;
            this._text = text;
        }
        public string Render(int depth)
        {
            string htmlLine;
            if(_tagName!="input")
            {
                htmlLine = "\n" + new string('\t', depth) + "<" + _tagName + ">" + _text + " :  </" + _tagName + ">";
                return htmlLine;
            }
            htmlLine = "\n" + new string('\t', depth) + "<" + _tagName + " type="+_text+" >";
            return htmlLine;
        }
    }
}
