namespace ViewModel
{
    public partial class HomeViewModel : ViewModelBase
    {
        public int Count { get; set; }

        public HomeViewModel()
        {
            Title = "Home";
        }

        /// <summary>
        /// 네비게이트 완료 - 네이게이트가 완료될 때 호출(백으로 돌아올 때도 호출됨)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="navigatedEventArgs"></param>
        public override void OnNavigated(object sender, object navigatedEventArgs)
        {
            Count++;
            Message = $"{Count} Navigated";

        }
    }
}
