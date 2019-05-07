using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using Caliburn.Micro;
using Pisces.Framework.Services;

namespace Pisces.Modules.MainWindow.ViewModels
{
    [Export(typeof(IMainWindow))]
    public class MainWindowViewModel : Conductor<IShell>, IMainWindow, IPartImportsSatisfiedNotification
    {
#pragma warning disable 649
        [Import]
        private IShell _shell;
#pragma warning restore 649

        private WindowState _windowState = WindowState.Normal;
        public WindowState WindowState
        {
            get { return _windowState; }
            set
            {
                _windowState = value;
                NotifyOfPropertyChange(() => WindowState);
            }
        }

        private double _width = 1000.0;
        public double Width
        {
            get { return _width; }
            set
            {
                _width = value;
                NotifyOfPropertyChange(() => Width);
            }
        }

        private double _height = 800.0;
        public double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                NotifyOfPropertyChange(() => Height);
            }
        }

        private string _title = "Default";
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                NotifyOfPropertyChange(() => Title);
            }
        }

        private ImageSource _icon;
        public ImageSource Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                NotifyOfPropertyChange(() => Icon);
            }
        }

        public IShell Shell
        {
            get { return _shell; }
        }

        void IPartImportsSatisfiedNotification.OnImportsSatisfied()
        {
            ActivateItem(_shell);
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
        }
    }
}