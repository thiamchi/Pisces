using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using Pisces.Framework;

namespace Pisces.Demo.Modules.Startup
{
    [Export(typeof(IModule))]
    public class Module : ModuleBase
    {
        [ImportingConstructor]
        public Module()
        {
        }

        public override void Initialize()
        {
            MainWindow.Title = "Pisces Demo";
        }
    }
}
