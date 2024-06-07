namespace AppHotelV2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState activatioState)
        {
            var window = base.CreateWindow(activatioState);

            window.Width = 600;
            window.Height = 400;

            return window;
        }
    }
}
