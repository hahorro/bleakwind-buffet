/*
 * Author: Hans Ahorro
 * Class name: MenuSelectionComponent.xaml.cs
 * Purpose: Partial class for MenuSelectionComponent codebehind
 */

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
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        /// <summary>
        /// Initializes the MenuSelectionComponent element.
        /// </summary>
        public MenuSelectionComponent()
        {
            InitializeComponent();
            itemCustomizationWindow.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Enables/disables the selection interface.
        /// </summary>
        /// <param name="b">Whether to enable/disable the interface.</param>
        void EnableSelection(bool b)
        {
            menuSelectionGrid.IsEnabled = b;
        }

        /// <summary>
        /// Opens the item customization window.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The arguments provided.</param>
        void OpenItemCustomization(object sender, RoutedEventArgs e)
        {
            itemCustomizationWindow.Visibility = Visibility.Visible;
            EnableSelection(false);
        }

        /// <summary>
        /// Closes the item customization window.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The arguments provided.</param>
        void CloseItemCustomization(object sender, RoutedEventArgs e)
        {
            itemCustomizationWindow.Visibility = Visibility.Hidden;
            EnableSelection(true);
        }
    }
}
