using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TopSystemsExample.Application.Utilities;

namespace TopSystemsExample.Application.ViewModels;
public class FiguresViewModel
{
    public FiguresViewModel(ParametersViewModel parameters, CanvasViewModel canvas)
    {
        Parameters = parameters;
        Canvas = canvas;
        UpdateFigureCommand = new Command(obj => Canvas.UpdateFigure(Parameters.Parameters));
    }
    public ICommand UpdateFigureCommand { get; set; }
    public ParametersViewModel Parameters { get; set; }
    public CanvasViewModel Canvas { get; set; }
}
