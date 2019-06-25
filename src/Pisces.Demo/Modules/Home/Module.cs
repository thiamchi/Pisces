using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using Pisces.Demo.Modules.Home.ViewModels;
using Pisces.Framework;

namespace Pisces.Demo.Modules.Home
{
    [Export(typeof(IModule))]
    public class Module : ModuleBase
    {
        public override IEnumerable<IDocument> DefaultDocuments
        {
            get
            {
                yield return IoC.Get<HomeViewModel>();
            }
        }

        public override void PostInitialize()
        {
            Shell.OpenDocument(IoC.Get<HomeViewModel>());
        }
    }
}
