using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class CatShop
    {
        private Cat[] cats;
        private int catCount;

        public CatShop(Cat[] cats, int catCount)
        {
            this.cats = cats;
            this.catCount = catCount;
        }

        public CatShop()
        {
            cats = new Cat[5];
            catCount = 0;
        }
    }
}
