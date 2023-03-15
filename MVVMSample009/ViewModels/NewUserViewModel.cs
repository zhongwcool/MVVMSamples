using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMSample009.Dialogs;

namespace MVVMSample009.ViewModels;

public class NewUserViewModel : ObservableValidator
{
    private readonly IUserDialog _dialog;

    public NewUserViewModel(IUserDialog dialog)
    {
        _dialog = dialog;

        CommandAddUser = new RelayCommand(DoAddPool);
        CommandCancel = new RelayCommand(DoCancel);
    }

    public IRelayCommand CommandAddUser { get; set; }
    public IRelayCommand CommandCancel { get; set; }

    private void DoAddPool()
    {
        ValidateAllProperties();
        if (!HasErrors)
        {
            _dialog.CloseDialog(true);
        }
    }

    private void DoCancel()
    {
        _dialog.CloseDialog(false);
    }

    private string _name;

    [Required(ErrorMessage = "不能为空！")]
    [StringLength(16, ErrorMessage = "长度不超过16！")]
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    private string _note;

    [MaxLength(100, ErrorMessage = "长度不超过100！")]
    public string Note
    {
        get => _note;
        set => SetProperty(ref _note, value);
    }

    private int _age;

    [Range(0, 80, ErrorMessage = "年龄范围 0-80！")]
    public int Age
    {
        get => _age;
        set => SetProperty(ref _age, value);
    }
}