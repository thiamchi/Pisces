using System;
using System.IO;
using System.Windows.Input;
using Caliburn.Micro;

namespace Pisces.Framework
{
    public interface ILayoutItem : IScreen
    {
        ICommand CloseCommand { get; }
        bool IsSelected { get; }
        bool ShouldReopenOnStart { get; }
    }
}
