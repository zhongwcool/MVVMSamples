using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace MVVMSample003.ViewModels;

internal class MainWindowViewModel : ObservableObject
{
    private string _rawText;

    public string RawText
    {
        get => _rawText;
        set
        {
            SetProperty(ref _rawText, value);
            SendCommand.NotifyCanExecuteChanged();
        }
    }

    private string _receiveMessage;

    public string ReceiveMessage
    {
        get => _receiveMessage;
        set => SetProperty(ref _receiveMessage, value);
    }

    public IRelayCommand SendCommand { get; }

    public MainWindowViewModel()
    {
        SendCommand = new RelayCommand(
            () => { WeakReferenceMessenger.Default.Send(RawText); },
            () => !string.IsNullOrEmpty(RawText)
        );
    }
}