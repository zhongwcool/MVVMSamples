using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMSample009.Models;

public class User : ObservableObject
{
    private Guid _poolId;

    public Guid PoolId
    {
        get => _poolId;
        set => SetProperty(ref _poolId, value);
    }

    private string _name;

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    private string _note;

    public string Note
    {
        get => _note;
        set => SetProperty(ref _note, value);
    }

    private int _age;

    public int Age
    {
        get => _age;
        set => SetProperty(ref _age, value);
    }

    private DateTime? _addDate;

    public DateTime? AddDate
    {
        get => _addDate;
        set => SetProperty(ref _addDate, value);
    }
}