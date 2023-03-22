using System.ComponentModel.DataAnnotations;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMSample008.ViewModels;

public class MainWindowViewModel : ObservableValidator
{
    private string _fullName;

    [Required(ErrorMessage = "{0} is a required field.")]
    [StringLength(20, ErrorMessage = "Character length is too long.")]
    public string FullName
    {
        get => _fullName;
        set => SetProperty(ref _fullName, value);
    }

    private int _age;

    public int Age
    {
        get => _age;
        set => SetProperty(ref _age, value);
    }

    private string _note;

    [RegularExpression("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$", ErrorMessage = "邮箱格式不正确")]
    [Required(ErrorMessage = "不能为空")]
    [DataType(DataType.EmailAddress)]
    public string Note
    {
        get => _note;
        set => SetProperty(ref _note, value);
    }

    public bool IsNormal => !HasErrors;

    public ICommand ValidateCommand { get; }
    public ICommand ClearErrorCommand { get; }

    /// <summary>
    ///     constructor
    /// </summary>
    public MainWindowViewModel()
    {
        ValidateCommand = new RelayCommand(ValidateAllProperties);

        ClearErrorCommand = new RelayCommand(() => { ClearErrors(); });
    }
}