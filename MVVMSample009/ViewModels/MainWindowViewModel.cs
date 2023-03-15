using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMSample009.Models;
using MVVMSample009.Services;
using IOC = CommunityToolkit.Mvvm.DependencyInjection.Ioc;

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

        NewUserCommand = new RelayCommand(NewUserAction);
    }

    public ObservableCollection<User> Users { get; } = new();

    private void NewUserAction()
    {
        var service = IOC.Default.GetService<IUserDialogService>();
        if (null == service) return;
        var result = service.ShowNewUserDialog();
        if (result.IsSuccess)
        {
            Users.Add(new User { Name = result.Username, Age = result.Age });
        }
    }

    public ICommand NewUserCommand { get; }
}