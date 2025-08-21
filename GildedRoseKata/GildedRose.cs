using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes")
                {
                    if (item.Quality > 0)
                    {
                        item.Quality--; // Decrease quality by 1
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++; // Increase quality by 1

                        if (item.Name == "Backstage passes")
                        {
                            if (item.SellIn < 11 && item.Quality < 50)
                                item.Quality++;
                            if (item.SellIn < 6 && item.Quality < 50)
                                item.Quality++;
                        }
                    }
                }

                item.SellIn--; // Decrease sell by date

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes")
                        {
                            if (item.Quality > 0)
                                item.Quality--;
                        }
                        else
                        {
                            item.Quality = 0; // Backstage passes drop to 0
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                            item.Quality++; // Aged Brie gets better
                    }
                }
            }
        }
    }
}
