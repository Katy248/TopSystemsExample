using System;

namespace TopSystemsExample.Application.Utilities;
public class Command : CommandBase
{
    private readonly Action<object?>? execute;
    private readonly Func<object?, bool>? canExecute;

    public Command() { }
    public Command(Action<object?> execute, Func<object?, bool>? canExecute = null)
	{
        this.execute = execute;
        this.canExecute = canExecute;
    }
    public override bool CanExecute(object? parameter)
    {
        return canExecute?.Invoke(parameter) ?? true;
    }
    public override void Execute(object? parameter)
    {
        execute?.Invoke(parameter);
    }
}
