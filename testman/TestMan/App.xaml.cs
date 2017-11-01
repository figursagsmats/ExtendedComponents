using Prism.Unity;
using TestMan.Views;
using Xamarin.Forms;

namespace TestMan
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("TheMasterDetailPage/NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<TheMasterDetailPage>();
            Container.RegisterTypeForNavigation<EntryPage>();
            Container.RegisterTypeForNavigation<ButtonPage>();
        }
    }
}
