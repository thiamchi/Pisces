using System.ComponentModel.Composition;
using Pisces.Framework.Services;
using Pisces.Modules.MainMenu.Models;

namespace Pisces.Modules.MainMenu.ViewModels
{
    [Export(typeof(IMenu))]
    public class MainMenuViewModel : MenuModel, IPartImportsSatisfiedNotification
    {
        private readonly IMenuBuilder _menuBuilder;

        [ImportingConstructor]
        public MainMenuViewModel(IMenuBuilder menuBuilder)
        {
            _menuBuilder = menuBuilder;
        }

        public void OnImportsSatisfied()
        {
            _menuBuilder.BuildMenuBar(MenuDefinitions.MainMenuBar, this);
        }
    }
}
