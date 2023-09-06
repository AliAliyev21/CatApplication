using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ApplicationCat
{
    public partial class CatShopAndHouseOwner
    {
        public string Name { get; set; }
        public CatHouse House { get; set; }
        public CatShop Shop { get; set; }

        public CatShopAndHouseOwner(string name, CatHouse house, CatShop shop)
        {
            Name = name;
            House = house;
            Shop = shop;
        }
    }
}
