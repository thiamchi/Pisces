using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Input;
using Caliburn.Micro;

namespace Pisces.Framework
{
    public abstract class LayoutItemBase : Screen, ILayoutItem
    {
        public abstract ICommand CloseCommand { get; }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
        }

        public virtual bool ShouldReopenOnStart
        {
            get { return false; }
        }
    }
}
