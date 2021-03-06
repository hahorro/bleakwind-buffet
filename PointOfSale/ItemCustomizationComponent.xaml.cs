﻿/*
 * Author: Hans Ahorro
 * Class name: ItemCustomizationComponent.xaml.cs
 * Purpose: Partial class for ItemCustomizationComponent codebehind
 */

// TODO: Add functions for changing elements within the component
// TODO: Change title based on whether customizing a new item to add or changing an existing one in the ticket receipt

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
    /// Interaction logic for ItemCustomizationComponent.xaml
    /// </summary>
    public partial class ItemCustomizationComponent : UserControl
    {
        /// <summary>
        /// An event fired when exiting the customization window.
        /// </summary>
        public event RoutedEventHandler ExitCustomizationWindow;

        /// <summary>
        /// Initializes the ItemCustomizationComponent element.
        /// </summary>
        public ItemCustomizationComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invokes the exit customization window event.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The arguments provided.</param>
        void ExitWindow(object sender, RoutedEventArgs e)
        {
            // TODO: Clear all element control contents to be filled in next time
            ExitCustomizationWindow?.Invoke(this, e);
        }
    }
}
