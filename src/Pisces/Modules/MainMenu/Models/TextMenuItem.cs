using System;
using System.Windows.Input;
using Pisces.Framework.Menus;

namespace Pisces.Modules.MainMenu.Models
{
    public class TextMenuItem : StandardMenuItem
    {
        private readonly MenuDefinitionBase _menuDefinition;

        public override string Text
        {
            get { return _menuDefinition.Text; }
        }

        public override bool IsChecked
        {
            get { return false; }
        }

        public override bool IsVisible
        {
            get { return true; }
        }

        public TextMenuItem(MenuDefinitionBase menuDefinition)
        {
            _menuDefinition = menuDefinition;
        }
    }
}
