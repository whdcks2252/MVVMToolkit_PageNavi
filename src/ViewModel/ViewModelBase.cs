using Common;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModel
{
    public abstract partial class ViewModelBase : ObservableObject, INavigationAware
    {
        [ObservableProperty]
        public string _title;

        [ObservableProperty]
        public string _message;

        /// <summary>
        /// 네비게이션 완료시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="navigatedEventArgs"></param>
        public virtual void OnNavigated(object sender, object navigatedEventArgs)
        {
        }
        /// <summary>
        /// 네비게이션 시작시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="navigationEventArgs"></param>
        public virtual void OnNavigating(object sender, object navigationEventArgs)
        {
        }
    }
}
