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
        DispatcherTimer dispatcherTimerCollapsed;
        DispatcherTimer dispatcherTimerVisible;
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
            if (dispatcherTimerCollapsed == null)
            {
                dispatcherTimerCollapsed = new DispatcherTimer();
                dispatcherTimerCollapsed.Tick += dispatcherTimerCollapsed_Tick;
                dispatcherTimerCollapsed.Interval = new TimeSpan(0, 0, 20);
            }
            if (dispatcherTimerVisible == null)
            {
                dispatcherTimerVisible = new DispatcherTimer();
                dispatcherTimerVisible.Tick += dispatcherTimerVisible_Tick;
                dispatcherTimerVisible.Interval = new TimeSpan(0, 0, 10);
                dispatcherTimerVisible.Start();
            }
        }
        async void dispatcherTimerCollapsed_Tick(object sender, object e)
        {
            if (fadeIn != null)
            {
                fadeIn.Begin();
                fadeIn.Completed += FadeIn_Completed;
            }
        }
        async void dispatcherTimerVisible_Tick(object sender, object e)
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
            dispatcherTimerCollapsed.Start();
            dispatcherTimerVisible.Stop();
            actualizaFrase();
        }
        private void actualizaFrase()
        {
            tbFrase.Text = "NUEVO TEXTO";
        }

        private void FadeIn_Completed(object sender, object e)
        {
            tbFrase.Opacity = 1;
            dispatcherTimerVisible.Start();
            dispatcherTimerCollapsed.Stop();
        }
    }
}
