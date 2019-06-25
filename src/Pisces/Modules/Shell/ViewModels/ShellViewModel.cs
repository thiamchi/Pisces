using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using Pisces.Framework;
using Pisces.Framework.Services;
using Pisces.Modules.MainMenu;

namespace Pisces.Modules.Shell.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<IDocument>.Collection.OneActive, IShell
    {
#pragma warning disable 649
        [ImportMany(typeof(IModule))]
        private IEnumerable<IModule> _modules;

        [Import]
        private IMenu _mainMenu;

#pragma warning restore 649

        public IMenu MainMenu
        {
            get { return _mainMenu; }
        }

        private ILayoutItem _activeLayoutItem;
        public ILayoutItem ActiveLayoutItem
        {
            get { return _activeLayoutItem; }
            set
            {
                if (ReferenceEquals(_activeLayoutItem, value))
                    return;

                _activeLayoutItem = value;

                if (value is IDocument)
                    ActivateItem((IDocument)value);

                NotifyOfPropertyChange(() => ActiveLayoutItem);
            }
        }

        public IDocument SelectedDocument => throw new NotImplementedException();

        public ShellViewModel()
        {
            ((IActivate)this).Activate();
        }

        protected override void OnViewLoaded(object view)
        {
            foreach (var module in _modules)
                module.PostInitialize();
            base.OnViewLoaded(view);
        }

        public override void ActivateItem(IDocument item)
        {
            try
            {
                if (ReferenceEquals(item, ActiveItem))
                    return;

                var currentActiveItem = ActiveItem;
                base.ActivateItem(item);

            }
            finally
            {
            }
        }

        public void OpenDocument(IDocument model)
        {
            ActivateItem(model);
        }

        public void CloseDocument(IDocument document)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
