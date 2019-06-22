using System.Collections;
using System.Collections.Generic;
using Caliburn.Micro;

namespace Pisces.Modules.MainMenu.Models
{
    public class MenuItemBase : PropertyChangedBase, IEnumerable<MenuItemBase>
    {
        #region Static Stuff

        #endregion

        #region Properties
        // This works as a container to collect all the menuItem and nested menuItem
        public IObservableCollection<MenuItemBase> Children { get; private set; }
        #endregion

        #region Constructors
        protected MenuItemBase()
        {
            Children = new BindableCollection<MenuItemBase>();
        }
        #endregion

        public void Add(params MenuItemBase[] menuItems)
        {
            menuItems.Apply(Children.Add);
        }

        public IEnumerator<MenuItemBase> GetEnumerator()
        {
            return Children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
