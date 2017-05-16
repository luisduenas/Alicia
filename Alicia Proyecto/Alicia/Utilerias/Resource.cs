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
                    App.linkImage = 0;
                    return "Tornado";
                case "tropical storm":
                    App.linkImage = 0;
                    return "Tormenta tropical";
                case "hurricane":
                    App.linkImage = 0;
                    return "Huracan";
                case "severe thunderstorms":
                    App.linkImage = 0;
                    return "Tormentas electricas severas";
                case "thunderstorms":
                    App.linkImage = 0;
                    return "Tormenta electrica";
                case "mixed rain and snow":
                    App.linkImage = 0;
                    return "Lluvia y nieve";
                case "mixed rain and sleet":
                    App.linkImage = 0;
                    return "Lluvia y granizo";
                case "mixed snow and sleet":
                    App.linkImage = 0;
                    return "Nieve y granizo";
                case "freezing drizzle":
                    App.linkImage = 0;
                    return "Llovizna helada";
                case "drizzle":
                    App.linkImage = 0;
                    return "Llovizna";
                case "freezing rain":
                    App.linkImage = 0;
                    return "Lluvia helada";
                case "showers":
                    App.linkImage = 0;
                    return "Fuertes lluvias";
                case "snow flurries":
                    App.linkImage = 0;
                    return "Copos de nieve";
                case "light snow showers":
                    App.linkImage = 0;
                    return "Duchas de nieve liviana";
                case "blowing snow":
                    App.linkImage = 0;
                    return "Viento con nieve";
                case "snow":
                    App.linkImage = 0;
                    return "Nevado";
                case "hail":
                    App.linkImage = 0;
                    return "Granizo";
                case "sleet":
                    App.linkImage = 0;
                    return "Granizo";
                case "dust":
                    App.linkImage = 0;
                    return "Polvo";
                case "foggy":
                    App.linkImage = 0;
                    return "Brumoso";
                case "haze":
                    App.linkImage = 0;
                    return "Neblina";
                case "smoky":
                    App.linkImage = 0;
                    return "Ahumado";
                case "blustery":
                    App.linkImage = 0;
                    return "Tempestuoso";
                case "windy":
                    App.linkImage = 0;
                    return "Ventoso";
                case "cold":
                    App.linkImage = 0;
                    return "Frio";
                case "cloudy":
                    App.linkImage = 0;
                    return "Nublado";
                case "mostly cloudy (night)":
                    App.linkImage = 0;
                    return "Mayormene Nublado";
                case "mostly cloudy (day)":
                    App.linkImage = 0;
                    return "Mayormene Nublado";
                case "partly cloudy (night)":
                    App.linkImage = 0;
                    return "Parcialmente Nublado";
                case "partly cloudy (day)":
                    App.linkImage = 0;
                    return "Parcialmente Nublado";
                case "clear (night)":
                    App.linkImage = 0;
                    return "Despejado";
                case "sunny":
                    App.linkImage = 1;
                    return "Soleado";
                case "fair (night)":
                    App.linkImage = 0;
                    return "Buen tiempo";
                case "fair (day)":
                    App.linkImage = 0;
                    return "Buen tiempo";
                case "mixed rain and hail":
                    App.linkImage = 0;
                    return "Lluvia y granizo";
                case "hot":
                    App.linkImage = 0;
                    return "Caliente";
                case "isolated thunderstorms":
                    App.linkImage = 0;
                    return "Tormentas electrricas aisladas";
                case "scattered thunderstorms":
                    App.linkImage = 0;
                    return "Tormentas electricas dispersas";
                case "scattered showers":
                    App.linkImage = 0;
                    return "Fuertes lluvias dispersas";
                case "heavy snow":
                    App.linkImage = 0;
                    return "Fuertes nevadas";
                case "scattered snow showers":
                    App.linkImage = 0;
                    return "Nieve dispersa";
                case "partly cloudy":
                    App.linkImage = 0;
                    return "Parcialmente nublado";
                case "thundershowers":
                    App.linkImage = 0;
                    return "Tormentas electricas";
                case "snow showers":
                    App.linkImage = 0;
                    return "Duchas de nieve";
                case "isolated thundershowers":
                    App.linkImage = 0;
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
