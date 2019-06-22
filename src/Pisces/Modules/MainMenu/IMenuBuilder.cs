using Pisces.Framework.Menus;
using Pisces.Modules.MainMenu.Models;

namespace Pisces.Modules.MainMenu
{
    public interface IMenuBuilder
    {
        void BuildMenuBar(MenuBarDefinition menuBarDefinition, MenuModel result);
    }
}
