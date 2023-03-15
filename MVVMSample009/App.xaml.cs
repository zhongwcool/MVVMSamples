using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MVVMSample009.Models;
using MVVMSample009.Services;

namespace MVVMSample009;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App
{
    public App()
    {
        Ioc.Default.ConfigureServices(
            new ServiceCollection()
                .AddSingleton<IFoo, Foo>()
                .AddSingleton<IUserDialogService, UserDialogService>()
                .BuildServiceProvider()
        );

        //IServiceCollection sc = new ServiceCollection();
        //sc.AddSingleton<IFoo, Foo>();
        //System.IServiceProvider provider = sc.BuildServiceProvider();
        //IOC.Default.ConfigureServices(provider);
    }
}