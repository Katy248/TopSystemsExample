using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using TopSystemsExample.Application.Models;
using TopSystemsExample.Application.Utilities;

namespace TopSystemsExample.Application.ViewModels;
public class CanvasViewModel : ViewModelBase
{
    public FrameworkElement? Figure { get; set; }
    public void UpdateFigure(FigureParameters parameters)
    {
        Figure = parameters.Type switch
        { 
            FigureType.Circle => new Ellipse() { Fill = new SolidColorBrush(parameters.Color), Width = 200, Height = 200 },
            FigureType.Square => new Rectangle() { Fill = new SolidColorBrush(parameters.Color), Width = 200, Height = 200 },
            FigureType.Triangle => new Polygon() 
            { 
                Fill = new SolidColorBrush(parameters.Color), 
                Height = 200, 
                Width = 100, 
                Points = new(new[] { new Point(50, 150), new Point(150, 50), new Point(250, 150) })},
        };
        RaisePropertyChanged(nameof(Figure));
    }
}
