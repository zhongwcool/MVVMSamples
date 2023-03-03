using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MVVMSample004.Models;

namespace MVVMSample004.ViewModels;

internal class MainWindowViewModel : ObservableObject
{
    private string _receiveMessage;

    public string ReceiveMessage
    {
        get => _receiveMessage;
        set => SetProperty(ref _receiveMessage, value);
    }

    public ICommand SendCommand { get; }

    public MainWindowViewModel()
    {
        WeakReferenceMessenger.Default.Register<Message>(this, OnReceive);

        SendCommand = new RelayCommand(() =>
        {
            WeakReferenceMessenger.Default.Send(new Message { Num = 123, Str = DateTime.Now.ToString() });
        });
    }

    private void OnReceive(object recipient, Message message)
    {
        ReceiveMessage = $"Num={message.Num}, Str={message.Str}";
    }
}