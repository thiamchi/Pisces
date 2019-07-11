using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Input;
using Caliburn.Micro;
using Pisces.Framework.Commands;

namespace Pisces.Modules.MainMenu.Models
{
    public class CommandMenuItem : StandardMenuItem, ICommandUiItem
    {
        private readonly Command _command;
        private readonly StandardMenuItem _parent;
        private readonly List<StandardMenuItem> _listItems;

        public override string Text
        {
            get { return _command.Text; }
        }

        public override bool IsChecked => throw new NotImplementedException();

        public override bool IsVisible => throw new NotImplementedException();

        public CommandDefinitionBase CommandDefinition => throw new NotImplementedException();

        //public void Update(CommandHandlerWrapper commandHandler)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
