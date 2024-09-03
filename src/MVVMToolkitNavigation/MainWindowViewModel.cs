using CommunityToolkit.Mvvm.ComponentModel;
using ViewModel;

namespace MVVMToolkitNavigation
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _navigationSource;

        public MainWindowViewModel()
        {
            Init();
        }

        private void Init()
        {
            NavigationSource = "View;component/MainPage.xaml";
        }

    }
}
