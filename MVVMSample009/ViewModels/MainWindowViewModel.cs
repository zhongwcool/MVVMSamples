using Microsoft.Toolkit.Mvvm.ComponentModel;
using MVVMSample009.Models;
using IOC = Microsoft.Toolkit.Mvvm.DependencyInjection.Ioc;

namespace MVVMSample009.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private string _text1;

    public string Text1
    {
        get => _text1;
        set => SetProperty(ref _text1, value);
    }

    public MainWindowViewModel()
    {
        var foo = IOC.Default.GetService<IFoo>();
        if (null == foo) return;
        Text1 = foo.GetBar();
    }
}