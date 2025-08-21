using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item { Name = "Sulfuras", SellIn = 0, Quality = 80 },
                new Item { Name = "Backstage passes", SellIn = 15, Quality = 20 }
            };

            var app = new GildedRose(items);

            for (int day = 0; day < 5; day++)
            {
                Console.WriteLine($"-------- Day {day} --------");
                Console.WriteLine("Name, SellIn, Quality");

                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
                }

                app.UpdateQuality();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
