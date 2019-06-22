using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisces.Framework.Menus
{
    public class MenuDefinition : MenuDefinitionBase
    {
        // Bar reference
        private readonly MenuBarDefinition _menuBar;
        // Arrangement
        private readonly int _sortOrder;
        // Display
        private readonly string _text;

        public MenuDefinition(MenuBarDefinition menuBar, int sortOrder, string text)
        {
            _menuBar = menuBar;
            _sortOrder = sortOrder;
            _text = text;
        }

        public MenuBarDefinition MenuBar
        {
            get { return _menuBar; }
        }

        public override int SortOrder
        {
            get { return _sortOrder; }
        }

        public override string Text
        {
            get { return _text; }
        }
    }
}
