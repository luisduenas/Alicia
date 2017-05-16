using Alicia.AliceService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Alicia.UserControls
{
    public sealed partial class weather : UserControl
    {
        SmartMirrorClient client;
        WeatherInfo weatherInfo;
        public weather()
        {
            this.InitializeComponent();
            inicializar();
        }
        private void inicializar()
        {
            try
            {
                client = new SmartMirrorClient();
                obtenerClima();
            }
            catch (Exception ex)
            {

            }
        }
        private async void obtenerClima()
        {
            weatherInfo = await client.getWeatherByWOEIDAsync(133475);
            ObservableCollection<Forecast> pronosticos = weatherInfo.forecast;

            tBTemperaturaActual.Text = "12";
            PivotMain.SelectedIndex = 0;
        }
        private void tBTemperaturaActual_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
