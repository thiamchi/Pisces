using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using Pisces.Framework.Services;
using Pisces.Modules.MainMenu;

namespace Pisces.Modules.Shell.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {
#pragma warning disable 649
        [Import]
        private IMenu _mainMenu;

#pragma warning restore 649

        public IMenu MainMenu
        {
            get { return _mainMenu; }
        }

        public ShellViewModel()
        {
            ((IActivate)this).Activate();
        }
    }
}
