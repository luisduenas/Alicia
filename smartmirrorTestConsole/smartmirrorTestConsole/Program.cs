using smartmirrorTestConsole.localService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartmirrorTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartMirrorClient client = new SmartMirrorClient();
            rss element = client.getTechNews();
           // Usuario user = client.getUsuario("1");
            WeatherInfo forecast = client.getWeatherByWOEID(133475);
            rssChannelItem[] items = element.channel.item;
            Console.WriteLine(items[0].description);
            Console.ReadKey();
        }
    }
}
