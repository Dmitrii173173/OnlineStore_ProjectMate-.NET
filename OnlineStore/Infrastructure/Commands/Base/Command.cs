﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace OnlineStore.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);
    }
}
