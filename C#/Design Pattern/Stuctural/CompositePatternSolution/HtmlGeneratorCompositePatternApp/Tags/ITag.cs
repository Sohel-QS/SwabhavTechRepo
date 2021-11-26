using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGeneratorCompositePatternApp.Tags
{
    interface ITag
    {
        string Render(int depth);
    }
}
