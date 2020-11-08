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
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

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
        [BindProperty]
        public string[] Types { get; set; }

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

        public void OnGet()
        {
            MenuItems = Data.Menu.Search(Data.Menu.FullMenu(), SearchTerms);
        }

        /// <summary>
        /// Returns a list of items by order type
        /// </summary>
        /// <param name="type">The order type</param>
        /// <returns>The string list of items</returns>
        public List<String> GetItems(OrderType type)
        {
            IEnumerable<Data.IOrderItem> list = null;
            var items = new List<String>();

            switch(type)
            {
                case OrderType.Entree:
                    list = Data.Menu.Entrees();
                    break;
                case OrderType.Side:
                    list = Data.Menu.Sides();
                    break;
                case OrderType.Drink:
                    list = Data.Menu.Drinks();
                    break;
                case OrderType.All:
                    list = Data.Menu.FullMenu();
                    break;
            }

            foreach(Data.IOrderItem item in list)
            {
                items.Add($"{item}, ${item.Price}, {item.Calories} kcals");
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
