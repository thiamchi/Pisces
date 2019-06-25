using System;
using System.Collections.Generic;
using System.Windows;

namespace Pisces.Framework
{
    public interface IModule
    {
        IEnumerable<IDocument> DefaultDocuments { get; }

        void PreInitialize();
        void Initialize();
        void PostInitialize();
    }
}
