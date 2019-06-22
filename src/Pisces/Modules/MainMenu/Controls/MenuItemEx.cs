using System.Windows;
using System.Windows.Controls;
using Pisces.Framework.Controls;
using Pisces.Modules.MainMenu.Models;

namespace Pisces.Modules.MainMenu.Controls
{
    public class MenuItemEx : System.Windows.Controls.MenuItem
    {
        private object _currentItem;

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            _currentItem = item;
            return base.IsItemItsOwnContainerOverride(item);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return GetContainer(this, _currentItem);
        }

        internal static DependencyObject GetContainer(FrameworkElement frameworkElement, object item)
        {
            //if (item is MenuItemSeparator)
            //    return new Separator();

            // Set styleKey as MenuItem and this will use Themes.
            const string styleKey = "MenuItem";

            var result = new MenuItemEx();
            result.SetResourceReference(DynamicStyle.BaseStyleProperty, typeof(MenuItem));
            result.SetResourceReference(DynamicStyle.DerivedStyleProperty, styleKey);
            return result;
        }
    }
}