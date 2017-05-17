using Alicia.AliceService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Alicia.UserControls
{
    public sealed partial class News : UserControl
    {
        DispatcherTimer timer;
        SmartMirrorClient cliente;
        rss resultNews;
        int pivotIndex = 0;
        ObservableCollection<rssChannelItem> noticias;
        public News()
        {
            this.InitializeComponent();
            cliente = new SmartMirrorClient();
            cargarNoticias();
            cargarTimer();
        }
        private void cargarTimer()
        {
            if (timer == null)
            {
                timer = new DispatcherTimer();
                timer.Tick += Timer_Tick; 
                timer.Interval = new TimeSpan(0, 0, 10);
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, object e)
        {
            pivotIndex++;
            if(pivotIndex > PivotMain.Items.Count - 1)
            {
                pivotIndex = 0;
            }
            PivotMain.SelectedIndex = pivotIndex;

        }

        private async void cargarNoticias()
        {
            resultNews = await cliente.getTechNewsAsync();
            noticias = resultNews.channel.item;
            tBNew1.Text = noticias[0].title;
            tBNew2.Text = noticias[1].title;
            tBNew3.Text = noticias[2].title;
            tBNew4.Text = noticias[3].title;
            tBNew5.Text = noticias[4].title;
        }
    }
}
