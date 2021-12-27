using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using MVVMSample005.Models;

namespace MVVMSample005.ViewModels;

internal class MainWindowViewModel : ObservableRecipient, IRecipient<Message>
{
    private int _sendCount;

    private string _receiveMessage;

    public string ReceiveMessage
    {
        get => _receiveMessage;
        set => SetProperty(ref _receiveMessage, value);
    }

    public ICommand SendCommand { get; }

    public MainWindowViewModel()
    {
        // Enable reception(Properties of ObservableRecipient)
        IsActive = true;

        _sendCount = 0;

        SendCommand = new RelayCommand(() =>
        {
            _sendCount++;

            WeakReferenceMessenger.Default.Send(new Message { Num = _sendCount, Str = "abc" });
        });
    }

    #region Implementation of IRecipient<T>

    public void Receive(Message message)
    {
        ReceiveMessage = $"Num={message.Num}, Str={message.Str}";
    }

    #endregion
}