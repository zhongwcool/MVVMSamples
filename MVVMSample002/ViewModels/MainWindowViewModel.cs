﻿using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMSample002.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private bool _isFree;

    public bool IsFree
    {
        get => _isFree;
        set => SetProperty(ref _isFree, value);
    }

    private string _status;

    public string Status
    {
        get => _status;
        set => SetProperty(ref _status, value);
    }

    public ICommand ExecCommand { get; }

    public MainWindowViewModel()
    {
        IsFree = true;
        Status = "";
        ExecCommand = new AsyncRelayCommand(ExecAsync);
    }

    private async Task ExecAsync()
    {
        IsFree = false;
        Status = "Processing...";

        await Task.Delay(2000);

        IsFree = true;
        Status = "Complete";
    }
}