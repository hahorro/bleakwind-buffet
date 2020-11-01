using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

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

        public List<IOrderItem> GetItems(OrderType type)
        {
            IEnumerable<IOrderItem> items = null;
            switch(type)
            {
                case OrderType.Entree:
                    items = Menu.Entrees();
                    break;
                case OrderType.Side:
                    items = Menu.Sides();
                    break;
                case OrderType.Drink:
                    items = Menu.Drinks();
                    break;
            }
            return items as List<IOrderItem>;
        }
    }
}
