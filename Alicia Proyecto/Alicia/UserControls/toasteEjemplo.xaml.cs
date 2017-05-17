using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Alicia.UserControls
{
    public sealed partial class toasteEjemplo : UserControl
    {
        public toasteEjemplo()
        {
            this.InitializeComponent();
            toast();
        }
        private void toast()
        {
            ToastContent content = new ToastContent()
            {
                Launch = "app-defined-string",

                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "Photo Share"
                },

                new AdaptiveText()
                {
                    Text = "Andrew sent you a picture"
                },

                new AdaptiveText()
                {
                    Text = "See it in full size!"
                },

                new AdaptiveImage()
                {
                    Source = "https://unsplash.it/360/180?image=1043"
                }
            },

                        AppLogoOverride = new ToastGenericAppLogo()
                        {
                            Source = "https://unsplash.it/64?image=883",
                            HintCrop = ToastGenericAppLogoCrop.Circle
                        }
                    }
                }
            };
        }
    }
}
