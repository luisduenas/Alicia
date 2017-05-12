using System;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Alicia.UserControls
{
    public sealed partial class weather : UserControl
    {
        public weather()
        {
            this.InitializeComponent();
            inicializar();
        }
        private void inicializar()
        {
            try
            {
                obtenerClima();

            }
            catch (Exception ex)
            {

            }
        }
        private void obtenerClima()
        {
            tBTemperaturaActual.Text = "12";
            PivotMain.SelectedIndex = 0;
        }

        private void tBTemperaturaActual_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
