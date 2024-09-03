using Common;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Model.Messages;
using System.ComponentModel;

namespace ViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _navigationSource;

        [RelayCommand]
        private void Navigate(string value)
        {
            if (value == "CustomerPage")
            {
                NavigationSource = EViewPage.CustomerPage.ToDescription();
            }

        }

        public MainViewModel()
        {
            NavigationSource = EViewPage.HomePage.ToDescription();
            Title = "Main View";
            WeakReferenceMessenger.Default.Register<NavigationMessage>(this, OnNavigationMessage);

        }

        /// <summary>
        /// 네비게이션 메시지 수신 처리
        /// </summary>
        /// <param name="recipient"></param>
        /// <param name="message"></param>
        private void OnNavigationMessage(object recipient, NavigationMessage message)
        {
            NavigationSource = message.Value;
        }
    }

    public enum EViewPage
    {
        NONE,
        [Description("View;component\\HomePage.xaml")]
        HomePage,
        [Description("View;component\\CustomerPage.xaml")]
        CustomerPage,
        Goback

    }

}
