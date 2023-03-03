﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMSample001.ViewModels;

internal class MainWindowViewModel : ObservableObject
{
    private string _value1;

    public string Value1
    {
        get => _value1;
        set
        {
            SetProperty(ref _value1, value);
            CalculateCommand?.NotifyCanExecuteChanged();
        }
    }

    private string _value2;

    public string Value2
    {
        get => _value2;
        set
        {
            SetProperty(ref _value2, value);
            CalculateCommand?.NotifyCanExecuteChanged();
        }
    }

    private string _result;

    public string Result
    {
        get => _result;
        set => SetProperty(ref _result, value);
    }

    public IRelayCommand CalculateCommand { get; }

    public MainWindowViewModel()
    {
        CalculateCommand = new RelayCommand(
            () =>
            {
                try
                {
                    Result = $"{Value1} + {Value2} = {int.Parse(Value1) + int.Parse(Value2)}";
                }
                catch
                {
                    Result = "Error!";
                }
            },
            () => !string.IsNullOrEmpty(Value1) && !string.IsNullOrEmpty(Value2)
        );
    }
}