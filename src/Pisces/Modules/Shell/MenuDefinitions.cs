using System.ComponentModel.Composition;
using Pisces.Framework.Menus;
using Pisces.Properties;

namespace Pisces.Modules.Shell
{
    public static class MenuDefinitions
    {
        [Export]
        public static MenuItemDefinition FileNewMenuItem = new TextMenuItemDefinition(MainMenu.MenuDefinitions.FileNewOpenMenuGroup, 0, Resources.FileNewCommandText);
    }
}
