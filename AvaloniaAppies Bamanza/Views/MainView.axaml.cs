using Avalonia.Controls;
using AvaloniaAppies_Bamanza.ViewModels;

namespace AvaloniaAppies_Bamanza.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia! This is my added text.";
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
    }
}
