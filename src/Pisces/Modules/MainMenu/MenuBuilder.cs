using System.ComponentModel.Composition;
using System.Linq;
// using Pisces.Framework.Commands;
using Pisces.Framework.Menus;
using Pisces.Modules.MainMenu.Models;

namespace Pisces.Modules.MainMenu
{
    [Export(typeof(IMenuBuilder))]
    public class MenuBuilder : IMenuBuilder
    {
        private readonly MenuBarDefinition[] _menuBars;
        private readonly MenuDefinition[] _menus;
        private readonly MenuItemGroupDefinition[] _menuItemGroups;
        private readonly MenuItemDefinition[] _menuItems;

        [ImportingConstructor]
        public MenuBuilder(
            [ImportMany] MenuBarDefinition[] menuBars,
            [ImportMany] MenuDefinition[] menus,
            [ImportMany] MenuItemGroupDefinition[] menuItemGroups,
            [ImportMany] MenuItemDefinition[] menuItems)
        {
            _menuBars = menuBars;
            _menus = menus;
            _menuItemGroups = menuItemGroups;
            _menuItems = menuItems;
        }

        public void BuildMenuBar(MenuBarDefinition menuBarDefinition, MenuModel result)
        {
            // Build the MenuBar with the same menuBarDefinition
            // If building MainMenu (which is using MenuBarDefinition), find all menus with the same MenuBarDefinition type.
            var menus = _menus
                .Where(x => x.MenuBar == menuBarDefinition)
                .OrderBy(x => x.SortOrder);

            // Structure overview
            // MenuBar (MenuBarDefinition)
            // +->File (MenuDefinition)
            // | +->New (MenuItemGroupDefinition)
            // | +->Close
            // | +->Save
            // |   ...
            // +->Edit (MenuDefinition)
            // +->View (MenuDefinition)

            // Loop through MenuDefinition enumerables
            foreach (var menu in menus)
            {
                var menuModel = new TextMenuItem(menu); // This can be changed to another model?
                AddGroupsRecursive(menu, menuModel);
                if (menuModel.Children.Any())
                    result.Add(menuModel);
            }
        }

        private void AddGroupsRecursive(MenuDefinitionBase menu, StandardMenuItem menuModel)
        {
            var groups = _menuItemGroups
                .Where(x => x.Parent == menu)
                .OrderBy(x => x.SortOrder)
                .ToList();

            // Loop through MenuItemGroupDefinition
            for (int i = 0; i < groups.Count; i++)
            {
                var group = groups[i];
                var menuItems = _menuItems
                    .Where(x => x.Group == group)
                    .OrderBy(x => x.SortOrder);

                // Loop through MenuItemDefinition
                foreach (var menuItem in menuItems)
                {
                    var menuItemModel = (StandardMenuItem)new TextMenuItem(menuItem);
                    AddGroupsRecursive(menuItem, menuItemModel);
                    menuModel.Add(menuItemModel);
                }

                if (i < groups.Count - 1 && menuItems.Any())
                    menuModel.Add(new MenuItemSeparator());
            }
        }
    }
}
