using System.Windows;
using System.Windows.Input;

namespace Pisces.Modules.MainMenu.Controls
{
    // This is a customize MenuEx extends from Menu.
    public class MenuEx : System.Windows.Controls.Menu
    {
        private object _currentItem;

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            _currentItem = item;
            return base.IsItemItsOwnContainerOverride(item);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return MenuItemEx.GetContainer(this, _currentItem);
        }
    }
}