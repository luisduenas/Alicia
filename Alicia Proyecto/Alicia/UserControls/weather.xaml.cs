using Alicia.AliceService;
using Alicia.Utilerias;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Alicia.UserControls
{
    public sealed partial class weather : UserControl
    {
        SmartMirrorClient client;
        WeatherInfo weatherInfo;
        DispatcherTimer dispatcherTimer;
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
            double temp = double.Parse(weatherInfo.temp);
            temp = Resource.Celcius(temp);
            tBTemperaturaActual.Text = string.Format("{0}°", temp);
            tB.Text = Resource.translateCondition((weatherInfo.text).ToLower());
            tBCiudad.Text = weatherInfo.location.city;
            PivotMain.SelectedIndex = 0;
        }

        public void TimerSetup()
        {
            if (dispatcherTimer == null)
            {
                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += dispatcherTimer_Tick;
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();
            }
        }
        async void dispatcherTimer_Tick(object sender, object e)
        {
            //tClock.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
        }
    }
}
