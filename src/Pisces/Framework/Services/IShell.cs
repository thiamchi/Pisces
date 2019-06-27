using System;
using Caliburn.Micro;
using Pisces.Modules.MainMenu;

namespace Pisces.Framework.Services
{
    public interface IShell : IGuardClose, IDeactivate
    {
        IMenu MainMenu { get; }

        ILayoutItem ActiveLayoutItem { get; set; }
        IDocument ActiveItem { get; }

        void OpenDocument(IDocument model);
        void CloseDocument(IDocument document);
        void Close();
    }
}