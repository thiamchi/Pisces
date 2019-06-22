using System.ComponentModel.Composition;
using Pisces.Framework.Menus;
using Pisces.Properties;

namespace Pisces.Modules.MainMenu
{
    // This is where we build the MenuItems
    public static class MenuDefinitions
    {
        [Export]
        public static MenuBarDefinition MainMenuBar = new MenuBarDefinition();

        [Export]
        public static MenuDefinition FileMenu = new MenuDefinition(MainMenuBar, 0, Resources.FileMenuText);

        [Export]
        public static MenuItemGroupDefinition FileNewOpenMenuGroup = new MenuItemGroupDefinition(FileMenu, 0);
    }
}
