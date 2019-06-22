using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisces.Framework.Menus
{
    public class MenuItemGroupDefinition
    {
        private readonly MenuDefinitionBase _parents;
        private readonly int _sortOrder;

        public MenuDefinitionBase Parent
        {
            get { return _parents; }
        }

        public int SortOrder
        {
            get { return _sortOrder; }
        }

        public MenuItemGroupDefinition(MenuDefinitionBase parent, int sortOrder)
        {
            _parents = parent;
            _sortOrder = sortOrder;
        }
    }
}
