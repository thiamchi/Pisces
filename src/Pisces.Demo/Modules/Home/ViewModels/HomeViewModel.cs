using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Windows;
using System.Windows.Media;
using Pisces.Framework;

namespace Pisces.Demo.Modules.Home.ViewModels
{
    [Export]
    public class HomeViewModel : Document
    {
        public HomeViewModel()
        {
            DisplayName = "Home";
        }

        public override bool ShouldReopenOnStart
        {
            get { return true; }
        }
    }
}
