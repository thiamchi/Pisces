using System;
using Caliburn.Micro;
using Pisces.Modules.MainMenu;

namespace Pisces.Framework.Services
{
    public interface IShell : IGuardClose, IDeactivate
    {
        IMenu MainMenu { get; }
    }
}