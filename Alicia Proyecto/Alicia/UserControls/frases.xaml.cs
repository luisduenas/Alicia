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
        Storyboard fadeOut, fadeIn;


        public frases()
        {
            this.InitializeComponent();
            fadeIn = mainGrid.Resources["FadeInStoryboard"] as Storyboard;
            fadeOut = mainGrid.Resources["FadeOutStoryboard"] as Storyboard;
            cargarFrases();
            tbFrase.SelectionChanged += TbFrase_SelectionChanged;
        }

        private void TbFrase_SelectionChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cargarFrases()
        {
            TimerSetup();
            tbFrase.Text = "FRASES";

            if (fadeIn != null)
            {
                fadeIn.Begin();
            }
        }
        private void TimerSetup()
        {
            if (dispatcherTimer == null)
            {
                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += dispatcherTimer_Tick;
                dispatcherTimer.Interval = new TimeSpan(0, 0, 50);
                dispatcherTimer.Start();
            }
        }
        async void dispatcherTimer_Tick(object sender, object e)
        {
            if (fadeOut != null)
            {
                fadeOut.Completed += FadeOut_Completed;
                fadeOut.Begin();
            }
        }

        private void FadeOut_Completed(object sender, object e)
        {
            tbFrase.Opacity = 0;
            actualizaFrase();
        }
        private void actualizaFrase()
        {
            tbFrase.Text = "NUEVO TEXTO";
            fadeIn.Begin();
            fadeIn.Completed += FadeIn_Completed;
        }

        private void FadeIn_Completed(object sender, object e)
        {
            tbFrase.Opacity = 1;
        }
    }
}
