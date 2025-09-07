
namespace Grocery.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState) =>
            new Window(new AppShell())
            {
                Width = 1280,
                Height = 720
            };
    }
}
