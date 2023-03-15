using MVVMSample009.ViewModels;

namespace MVVMSample009.Views;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}