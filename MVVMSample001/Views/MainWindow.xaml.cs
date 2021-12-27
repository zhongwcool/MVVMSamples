using System.Windows;
using MVVMSample001.ViewModels;

namespace MVVMSample001.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}