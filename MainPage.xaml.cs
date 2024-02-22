namespace EngineMasterCalculatorApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void InjectorSizeCalculator_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InjectorCalculator());

        }
        private async void CarburetorCalculator_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarburetorCalculator());

        }
        private async void FuelPumpSizeCalculator_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FuelPumpCalculator());

        }
        private async void CompressionRatioCalculator_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CompressionRatioCalculator());

        }
    }

}
