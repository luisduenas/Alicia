using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alicia.Utilerias
{
    public class Resource
    {
        public static double Celcius(double f)
        {
            double c = 5.0 / 9.0 * (f - 32.0);

            return Math.Round(c);
        }
        public static string translateCondition(string condition)
        {
            string traduccion = string.Empty;
            switch (condition)
            {
                case "tornado":
                    App.linkImage = 3;
                    return "Tornado";
                case "tropical storm":
                    App.linkImage = 5;
                    return "Tormenta tropical";
                case "hurricane":
                    App.linkImage = 3;
                    return "Huracan";
                case "severe thunderstorms":
                    App.linkImage = 6;
                    return "Tormentas electricas severas";
                case "thunderstorms":
                    App.linkImage = 6;
                    return "Tormenta electrica";
                case "mixed rain and snow":
                    App.linkImage = 7;
                    return "Lluvia y nieve";
                case "mixed rain and sleet":
                    App.linkImage = 7;
                    return "Lluvia y granizo";
                case "mixed snow and sleet":
                    App.linkImage = 7;
                    return "Nieve y granizo";
                case "freezing drizzle":
                    App.linkImage = 7;
                    return "Llovizna helada";
                case "drizzle":
                    App.linkImage = 5;
                    return "Llovizna";
                case "freezing rain":
                    App.linkImage = 5;
                    return "Lluvia helada";
                case "showers":
                    App.linkImage = 5;
                    return "Fuertes lluvias";
                case "snow flurries":
                    App.linkImage = 5;
                    return "Copos de nieve";
                case "light snow showers":
                    App.linkImage = 7;
                    return "Duchas de nieve liviana";
                case "blowing snow":
                    App.linkImage = 7;
                    return "Viento con nieve";
                case "snow":
                    App.linkImage = 7;
                    return "Nevado";
                case "hail":
                    App.linkImage = 7;
                    return "Granizo";
                case "sleet":
                    App.linkImage = 7;
                    return "Granizo";
                case "dust":
                    App.linkImage = 3;
                    return "Polvo";
                case "foggy":
                    App.linkImage = 3;
                    return "Brumoso";
                case "haze":
                    App.linkImage = 3;
                    return "Neblina";
                case "smoky":
                    App.linkImage = 3;
                    return "Ahumado";
                case "blustery":
                    App.linkImage = 3;
                    return "Tempestuoso";
                case "windy":
                    App.linkImage = 3;
                    return "Ventoso";
                case "cold":
                    App.linkImage = 7;
                    return "Frio";
                case "cloudy":
                    App.linkImage = 4;
                    return "Nublado";
                case "mostly cloudy (night)":
                    App.linkImage = 4;
                    return "Mayormene Nublado";
                case "mostly cloudy (day)":
                    App.linkImage = 4;
                    return "Mayormene Nublado";
                case "partly cloudy (night)":
                    App.linkImage = 4;
                    return "Parcialmente Nublado";
                case "partly cloudy (day)":
                    App.linkImage = 4;
                    return "Parcialmente Nublado";
                case "clear":
                    App.linkImage = 8;
                    return "Despejado";
                case "sunny":
                    App.linkImage = 1;
                    return "Soleado";
                case "fair (night)":
                    App.linkImage = 1;
                    return "Buen tiempo";
                case "fair (day)":
                    App.linkImage = 1;
                    return "Buen tiempo";
                case "mixed rain and hail":
                    App.linkImage = 5;
                    return "Lluvia y granizo";
                case "hot":
                    App.linkImage = 1;
                    return "Caliente";
                case "isolated thunderstorms":
                    App.linkImage = 6;
                    return "Tormentas electrricas aisladas";
                case "scattered thunderstorms":
                    App.linkImage = 6;
                    return "Tormentas electricas dispersas";
                case "scattered showers":
                    App.linkImage = 5;
                    return "Fuertes lluvias dispersas";
                case "heavy snow":
                    App.linkImage = 7;
                    return "Fuertes nevadas";
                case "scattered snow showers":
                    App.linkImage = 7;
                    return "Nieve dispersa";
                case "partly cloudy":
                    App.linkImage = 4;
                    return "Parcialmente nublado";
                case "thundershowers":
                    App.linkImage = 6;
                    return "Tormentas electricas";
                case "snow showers":
                    App.linkImage = 7;
                    return "Duchas de nieve";
                case "isolated thundershowers":
                    App.linkImage = 6;
                    return "Tormentas electricas aisladas";
                default: return condition;
            }
        }
        public static string translateDay(string day)
        {
            switch (day)
            {
                case "Mon": return "Lunes";
                case "Tue": return "Martes";
                case "Wed": return "Miercoles";
                case "Thu": return "Jueves";
                case "Fri": return "Viernes";
                case "Sat": return "Sabado";
                case "Sun": return "Domingo";
                default: return string.Empty;
            }
        }
    }
}
