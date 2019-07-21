using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;
using Pisces.Framework;
using Pisces.Modules.MarkdownEditor.ViewModels;

namespace Pisces.Modules.MarkdownEditor
{
    [Export(typeof(IModule))]
    public class Module : ModuleBase
    {
        public override IEnumerable<IDocument> DefaultDocuments
        {
            get
            {
                yield return IoC.Get<DemoViewModel>();
            }
        }

        public override void PostInitialize()
        {
            Shell.OpenDocument(IoC.Get<DemoViewModel>());
        }
    }
}
