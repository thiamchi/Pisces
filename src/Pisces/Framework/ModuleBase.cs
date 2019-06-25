using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using Pisces.Modules.MainMenu;
using Pisces.Framework.Services;

namespace Pisces.Framework
{
    public abstract class ModuleBase : IModule
    {
#pragma warning disable 649
        [Import]
        private IMainWindow _mainWindow;

        [Import]
        private IShell _shell;

#pragma warning restore 649

        protected IMainWindow MainWindow
        {
            get { return _mainWindow; }
        }

        protected IShell Shell
        {
            get { return _shell; }
        }

        protected IMenu MainMenu
        {
            get { return _shell.MainMenu; }
        }

        public virtual IEnumerable<IDocument> DefaultDocuments
        {
            get { yield break; }
        }

        public virtual void PreInitialize()
        {
        }

        public virtual void Initialize()
        {
        }

        public virtual void PostInitialize()
        {
        }

    }
}
