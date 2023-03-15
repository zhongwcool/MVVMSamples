using System.Windows.Input;
using MVVMSample009.ViewModels;

namespace MVVMSample009.Dialogs;

public partial class NewUserWindow : IUserDialog
{
    public NewUserWindow()
    {
        InitializeComponent();
        DataContext = new NewUserViewModel(this);
    }

    private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    public NewUserViewModel ViewModel => (NewUserViewModel)DataContext;

    private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        XuNiBox.Focus();
    }

    public void CloseDialog(bool result)
    {
        DialogResult = result;
        Close();
    }
}