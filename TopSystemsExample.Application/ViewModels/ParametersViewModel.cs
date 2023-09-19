using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Forms;
using TopSystemsExample.Application.Models;
using System.Windows.Input;
using TopSystemsExample.Application.Utilities;

namespace TopSystemsExample.Application.ViewModels;
public class ParametersViewModel : ViewModelBase
{
    public ParametersViewModel()
    {
        SelectColorCommand = new Command(obj => SelectColor(), obj => true);
    }
    public FigureParameters Parameters => new()
    {
        Type = Enum.Parse<FigureType>(SelectedFigureType?.Text ?? FigureType.Square.ToString()),
        Color = SelectedColor,
    };

    public IEnumerable<TextBlock> FigureTypes => Enum.GetValues<FigureType>().Select(ft => new TextBlock {Text = ft.ToString() });
    public Color SelectedColor { get; set; } = Colors.Black;
    public TextBlock? SelectedFigureType { get; set; }

    public ICommand SelectColorCommand { get; set; }
    public void SelectColor()
    {
        var colorDialog = new ColorDialog();
        var result = colorDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            SelectedColor = Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            RaisePropertyChanged(nameof(SelectedColor));
        }
    }
}
