using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Data = BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public int MaxCalories = 1000;
        public double MaxPrice = 10.0;

        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<Data.IOrderItem> MenuItems { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered order types
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Types { get; set; }

        /// <summary>
        /// The filtered minimum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int CaloriesMin { get; set; } = 0;

        /// <summary>
        /// The filtered maximum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int CaloriesMax { get; set; } = 1000;

        /// <summary>
        /// The filtered minimum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; } = 0.0;

        /// <summary>
        /// The filtered maximum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; } = 10.0;

        /// <summary>
        /// GET request
        /// </summary>
        public void OnGet()
        {
            MenuItems = Data.Menu.Search(Data.Menu.FullMenu(), SearchTerms);
            MenuItems = Data.Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
            MenuItems = Data.Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }

        /// <summary>
        /// Order types from menu
        /// </summary>
        public enum OrderType
        {
            Entree,
            Side,
            Drink,
            All
        }

        /// <summary>
        /// Returns a list of items by order type
        /// </summary>
        /// <param name="type">The order type</param>
        /// <returns>The string list of items</returns>
        public List<String> GetItems(OrderType type)
        {
            var items = new List<String>();

            foreach(Data.IOrderItem item in MenuItems)
            {
                if ((type == OrderType.Entree) && (item is Data.Entrees.Entree) ||
                    (type == OrderType.Side) && (item is Data.Sides.Side) ||
                    (type == OrderType.Drink) && (item is Data.Drinks.Drink) ||
                    (type == OrderType.All)
                    )
                {
                    items.Add($"{item}, ${item.Price}, {item.Calories} kcals");
                }
            }
            return items;
        }

        /// <summary>
        /// Returns a list of available Sailor Soda flavors
        /// </summary>
        /// <returns>The string list of soda flavors</returns>
        public List<String> SailorSodaFlavors()
        {
            var list = new List<string>();
            foreach(Data.Enums.SodaFlavor flavor in Enum.GetValues(typeof(Data.Enums.SodaFlavor)))
            {
                list.Add(flavor.ToString());
            }
            return list;
        }
    }
}
