using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Alicia.UserControls
{
    public sealed partial class Clock : UserControl
    {
        DispatcherTimer dispatcherTimer;
        public Clock()
        {
            this.InitializeComponent();
            inicializaReloj();
        }
        private void inicializaReloj()
        {
            TimerSetup();
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
            tClock.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
        }
    }
}
