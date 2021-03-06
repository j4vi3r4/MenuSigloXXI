using Prism;
using Prism.Ioc;
using MenuSigloXXI.ViewModels;
using MenuSigloXXI.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MenuSigloXXI
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/NumeroMesaPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();           
            containerRegistry.RegisterForNavigation<NumeroMesaPage, NumeroMesaPageViewModel>();
            containerRegistry.RegisterForNavigation<CocinaPage, CocinaPageViewModel>();
        }
    }
}
