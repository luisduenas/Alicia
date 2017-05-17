using Alicia.AliceService;
using Alicia.Utilerias;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

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
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("ms-appx://../Assets/img/" + App.linkImage + ".png", UriKind.Absolute));
            btnImagen.Background = brush;
            PivotMain.SelectedIndex = 0;
            cargarPronosticos();
            TimerSetup();
        }
        private void cargarPronosticos()
        {
            lDia1.Text = Resource.translateDay(weatherInfo.forecast[1].day);
            tBMinDia1.Text = string.Format("{0}°",Resource.Celcius(double.Parse(weatherInfo.forecast[1].low.ToString())));
            tBMaxDia1.Text = string.Format("{0}°", Resource.Celcius(double.Parse(weatherInfo.forecast[1].high.ToString())));
            Resource.translateCondition(weatherInfo.forecast[1].text);
            imgDia1.Source = new BitmapImage(new Uri("ms-appx://../Assets/img/" + App.linkImage + ".png", UriKind.Absolute));
            lDia2.Text = Resource.translateDay(weatherInfo.forecast[2].day);
            tBMinDia2.Text = string.Format("{0}°", Resource.Celcius(double.Parse(weatherInfo.forecast[2].low.ToString())));
            tBMaxDia2.Text = string.Format("{0}°", Resource.Celcius(double.Parse(weatherInfo.forecast[2].high.ToString())));
            Resource.translateCondition(weatherInfo.forecast[2].text);
            imgDia2.Source = new BitmapImage(new Uri("ms-appx://../Assets/img/" + App.linkImage + ".png", UriKind.Absolute));
            lDia3.Text = Resource.translateDay(weatherInfo.forecast[3].day);
            tBMinDia3.Text = string.Format("{0}°", Resource.Celcius(double.Parse(weatherInfo.forecast[3].low.ToString())));
            tBMaxDia3.Text = string.Format("{0}°", Resource.Celcius(double.Parse(weatherInfo.forecast[3].high.ToString())));
            Resource.translateCondition(weatherInfo.forecast[3].text);
            imgDia3.Source = new BitmapImage(new Uri("ms-appx://../Assets/img/" + App.linkImage + ".png", UriKind.Absolute));

        }

        private void TimerSetup()
        {
            if (dispatcherTimer == null)
            {
                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += dispatcherTimer_Tick;
                dispatcherTimer.Interval = new TimeSpan(0, 0, 6);
                dispatcherTimer.Start();
            }
        }
        async void dispatcherTimer_Tick(object sender, object e)
        {
            PivotMain.SelectedIndex = PivotMain.SelectedIndex == 0 ? 1 : 0;
        }
    }
}
