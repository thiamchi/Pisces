using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliburn.Micro;

namespace Pisces.Framework
{
    public abstract class Document : LayoutItemBase, IDocument
    {
        public override ICommand CloseCommand { get; }
    }
}
