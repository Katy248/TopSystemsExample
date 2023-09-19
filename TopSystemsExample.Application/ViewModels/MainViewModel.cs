using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TopSystemsExample.Application.ViewModels;
public class MainViewModel
{
    public MainViewModel(FiguresViewModel figuresViewModel)
    {
        ViewContent = figuresViewModel;
    }
    public object ViewContent { get; set; }
}
