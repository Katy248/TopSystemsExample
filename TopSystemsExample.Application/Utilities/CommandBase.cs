using System;
using System.Windows.Input;

namespace TopSystemsExample.Application.Utilities;
public class CommandBase : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public virtual bool CanExecute(object? parameter) => true;

    public virtual void Execute(object? parameter) { }
}
