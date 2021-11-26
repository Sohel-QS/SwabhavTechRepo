using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGeneratorCompositePatternApp.Tags
{
    class GroupTag : ITag
    {
        private string _tagName;
        private string _text;
        private List<ITag> _tags = new List<ITag>();
        public GroupTag(string tagName, string text="")
        {
            this._tagName = tagName;
            this._text = text;
        }
        public void AddTag(ITag tag)
        {
            _tags.Add(tag);
        }

        public string Render(int depth)
        {
            string htmlDiv = "\n" + new string('\t', depth) + "<" + _tagName + ">" + _text;
            foreach(ITag tag in _tags)
            {
                htmlDiv += tag.Render(depth+1);
            }
            htmlDiv += "\n" + new string('\t', depth) + "</" + _tagName + ">";
            return htmlDiv;
        }
    }
}
