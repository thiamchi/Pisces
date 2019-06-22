using System;
using System.Windows.Input;

namespace Pisces.Framework.Menus
{
    public class TextMenuItemDefinition :  MenuItemDefinition
    {
        private readonly string _text;
        
        public override string Text
        {
            get { return _text; }
        }

        public TextMenuItemDefinition(MenuItemGroupDefinition group, int sortOrder, string text)
            : base(group, sortOrder)
        {
            _text = text;
        }
    }
}
