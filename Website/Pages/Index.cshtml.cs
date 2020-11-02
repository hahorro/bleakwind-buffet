using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public enum OrderType
        {
            Entree,
            Side,
            Drink,
            All
        }

        public List<String> GetItems(OrderType type)
        {
            IEnumerable<IOrderItem> list = null;
            var items = new List<String>();

            switch(type)
            {
                case OrderType.Entree:
                    list = Menu.Entrees();
                    break;
                case OrderType.Side:
                    list = Menu.Sides();
                    break;
                case OrderType.Drink:
                    list = Menu.Drinks();
                    break;
                case OrderType.All:
                    list = Menu.FullMenu();
                    break;
            }
            foreach (IOrderItem item in list)
            {
                items.Add($"{item}, ${item.Price}, {item.Calories} kcals");
            }
            return items;
        }

        public List<String> SailorSodaFlavors()
        {
            var list = new List<string>();
            foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
            {
                list.Add(flavor.ToString());
            }
            return list;
        }
    }
}
