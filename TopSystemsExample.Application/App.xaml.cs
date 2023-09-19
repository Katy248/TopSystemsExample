using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using TopSystemsExample.Application.ViewModels;

namespace TopSystemsExample.Application;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : System.Windows.Application
{
    private readonly IServiceProvider _serviceProvider;
    public App()
    {
        _serviceProvider = new ServiceCollection()
            .AddSingleton<MainWindow>()
            .AddSingleton<MainViewModel>()

            .AddTransient<FiguresViewModel>()
            .AddTransient<ParametersViewModel>()
            .AddTransient<CanvasViewModel>()


            .BuildServiceProvider();
    }
    protected override void OnStartup(StartupEventArgs e)
    {
        MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
        MainWindow.DataContext = _serviceProvider.GetRequiredService<MainViewModel>();
        MainWindow.Show();
        base.OnStartup(e);
    }
}
