/*
 * Author: Hans Ahorro
 * Class name: OrderComponent.xaml.cs
 * Purpose: Partial class for OrderComponent codebehind
 */

// TODO: Set vertical scrollbar margins

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        private const string orderString = "Order #";
        private const string subtotalString = "Subtotal:";
        private const string taxString = "Tax:";
        private const string totalString = "Total:";

        /// <summary>The ticket number of an order.</summary>
        /// <value>The current ticket number for the order.</value>
        public int OrderNumber { get; set; } = 1;

        /// <summary>
        /// Initializes the Order component element.
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            ResetTicket();
            // this.ExitCustomizationHandler.
        }

        /// <summary>
        /// Enables/disables the ticket interface.
        /// </summary>
        /// <param name="b">Whether to enable/disable the interface.</param>
        public void EnableTicket(bool b)
        {
            orderTicket.IsEnabled = b;
        }

        /// <summary>
        /// Clears the order ticket.
        /// </summary>
        void ResetTicket()
        {
            /* Remove comment block later when implementing functionality
            orderTicketNumber.Content = $"{orderString}{OrderNumber}";
            orderSubtotal.Content = $"{subtotalString} $0.00";
            orderTax.Content = $"{taxString} $0.00";
            orderTotal.Content = $"{totalString} $0.00";
            orderProcess.IsEnabled = false;
            orderCancel.IsEnabled = false;
            orderList.Items.Clear();
            */
        }

        /// <summary>
        /// Adds an item to the order list.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The arguments provided.</param>
        void AddItemToOrderList(object sender, RoutedEventArgs e)
        { 
        }

        /// <summary>
        /// Deselects everything when clicking in an empty space within the list.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The arguments provided.</param>
        void orderList_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // TODO: Remove customization screen from MenuSelectionComponent
            HitTestResult r = VisualTreeHelper.HitTest(this, e.GetPosition(this));
            if (r.VisualHit.GetType() != typeof(ListBoxItem))
            {
                orderList.UnselectAll();
            }
        }
    }
}
