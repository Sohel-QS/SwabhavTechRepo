using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemsLiib.Model;

namespace ShoppingCartClientApp.Model
{
    class HatAdapter :Item
    {
        private Hat _hat;

        public HatAdapter(Hat hat):base(hat.LongName, hat.Price)
        {
        }

    }
}
