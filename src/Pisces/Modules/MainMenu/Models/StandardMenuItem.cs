using System;
using System.Windows.Input;

namespace Pisces.Modules.MainMenu.Models
{
    public abstract class StandardMenuItem : MenuItemBase
    {
        public abstract string Text { get; }
        public abstract bool IsChecked { get; }
        public abstract bool IsVisible { get; }
    }
}
