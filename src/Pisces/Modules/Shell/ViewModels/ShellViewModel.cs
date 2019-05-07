using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using Pisces.Framework.Services;

namespace Pisces.Modules.Shell.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {
        public ShellViewModel()
        {
            ((IActivate)this).Activate();
        }
    }
}
