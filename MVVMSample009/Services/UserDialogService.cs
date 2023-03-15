using System.Threading.Tasks;
using System.Windows;
using MVVMSample009.Dialogs;
using MVVMSample009.ViewModels;

namespace MVVMSample009.Services;

public class UserDialogService : IUserDialogService
{
    public async Task<NewUserDialogResult> ShowNewUserDialogAsync(string defaultUsername = null, int defaultAge = 0)
    {
        return await Application.Current.Dispatcher.InvokeAsync(() => ShowNewUserDialog(defaultUsername, defaultAge));
    }

    public NewUserDialogResult ShowNewUserDialog(string defaultUsername = null, int defaultAge = 0)
    {
        var window = new NewUserWindow
        {
            ViewModel = { Name = defaultUsername, Age = defaultAge }
        };
        var result = window.ShowDialog() == true;

        if (!result)
        {
            // DialogResult failed, so return an empty result with a failure state
            return new NewUserDialogResult { IsSuccess = false };
        }

        if (window.DataContext is not NewUserViewModel vm)
        {
            // DialogResult failed, so return an empty result with a failure state
            return new NewUserDialogResult { IsSuccess = false };
        }

        return new NewUserDialogResult { IsSuccess = true, Age = vm.Age, Username = vm.Name, Note = vm.Note };
    }
}