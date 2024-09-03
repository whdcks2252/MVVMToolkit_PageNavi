using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Model.Messages;

namespace ViewModel
{
    public partial class CustomerViewModel : ViewModelBase
    {
        [RelayCommand]
        private void Back()
        {
            WeakReferenceMessenger.Default.Send(new NavigationMessage("GoBack"));
        }

        public CustomerViewModel()
        {
            Title = "Customer";
        }

        public override void OnNavigated(object sender, object navigatedEventArgs)
        {
            Message = "Navigated";
        }

    }
}
