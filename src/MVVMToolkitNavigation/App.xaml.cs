using Common;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using ViewModel;

namespace MVVMToolkitNavigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow mainView = Services.GetRequiredService<MainWindow>();
            mainView.Show();
        }



        private IServiceProvider ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<CustomerViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindowViewModel>();

            services.AddSingleton(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainWindowViewModel>()
            });
            return services.BuildServiceProvider();

        }

        public App()
        {
            Services = ConfigureServices();
            ServiceProviderHolder.ServiceProvider = Services; // 여기서 설정

        }
    }

}
