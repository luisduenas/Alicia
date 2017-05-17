using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Alicia.UserControls
{
    public sealed partial class frases : UserControl
    {
        DispatcherTimer dispatcherTimer;

        public frases()
        {
            this.InitializeComponent();
            cargarFrases();
        }
        private void cargarFrases()
        {
            TimerSetup();

        }
        private void TimerSetup()
        {
            if (dispatcherTimer == null)
            {
                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += dispatcherTimer_Tick;
                dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
                dispatcherTimer.Start();
            }
        }
        async void dispatcherTimer_Tick(object sender, object e)
        {
            var fadeOut = mainGrid.Resources["FadeOutStoryboard"] as Storyboard;
            var fadeIn = mainGrid.Resources["FadeInStoryboard"] as Storyboard;

            if (fadeIn != null)
            {
                
            }
            if (fadeOut != null)
            {
                fadeOut.Begin();
            }

        }
    }
}
