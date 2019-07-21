using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Windows;
using System.Windows.Media;
using Pisces.Framework;

namespace Pisces.Modules.MarkdownEditor.ViewModels
{
    [Export]
    public class DemoViewModel : Document, INotifyPropertyChanged
    {
        private string _DemoMD;
        public string DemoMd
        {
            get { return _DemoMD; }
            set
            {
                _DemoMD = value;
                NotifyOfPropertyChange(() => DemoMd);
            }
        }

        public DemoViewModel()
        {
            DisplayName = "Demonstration Document Viewer";
            DemoMd = File.ReadAllText("Sample.md");
        }

        public override bool ShouldReopenOnStart
        {
            get { return true; }
        }

    }
}