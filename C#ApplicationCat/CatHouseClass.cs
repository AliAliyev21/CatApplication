using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class CatHouse
    {
        private Cat[] cats;
        private int catCount;

        public CatHouse(Cat[] cats, int catCount)
        {
            this.cats = cats;
            this.catCount = catCount;
        }

        public CatHouse()
        {
            cats = new Cat[5];
            catCount = 0;
        }
    }
}
