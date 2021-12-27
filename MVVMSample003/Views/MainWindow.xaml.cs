using System.Windows;
using Microsoft.Toolkit.Mvvm.Messaging;
using MVVMSample003.ViewModels;

namespace MVVMSample003.Views;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();

        WeakReferenceMessenger.Default.Register<string>(this, OnReceive);
    }

    private void OnReceive(object recipient, string message)
    {
        RecvText.Text = $"Received:{message}";
    }
}