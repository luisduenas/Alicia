using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Alicia
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //string xmlText = File.ReadAllText("content.xml");
            //XmlDocument xmlContent = new XmlDocument();
            //xmlContent.LoadXml(xmlText);
            //ToastNotification notification = new ToastNotification(xmlContent);
            //ToastNotificationManager.CreateToastNotifier().Show(notification);
        }

    }
}
