using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alicia.Utilerias
{
    public class Traductor
    {
        public string traducirCondicion(string condicion)
        {
            string traduccion = string.Empty;
            switch (condicion)
            {
                case "tornado": return "Tornado";
                case "tropical storm": return "Tormenta tropical";
                case "hurricane": return "Huracan";
                case "severe thunderstorms": return "Tormentas electricas severas";
                case "thunderstorms": return "Tormenta electrica";
                case "mixed rain and snow": return "Lluvia y nieve";
                case "mixed rain and sleet": return "Lluvia y granizo";
                case "mixed snow and sleet": return "Nieve y granizo";
                case "freezing drizzle": return "Llovizna helada";
                case "drizzle": return "Llovizna";
                case "freezing rain": return "Lluvia helada";
                case "showers": return "Fuertes lluvias";
                case "snow flurries": return "Copos de nieve";
                case "light snow showers": return "Duchas de nieve liviana";
                case "blowing snow": return "Viento con nieve";
                case "snow": return "Nevado";
                case "hail": return "Granizo";
                case "sleet": return "Granizo";
                case "dust": return "Polvo";
                case "foggy": return "Brumoso";
                case "haze": return "Neblina";
                case "smoky": return "Ahumado";
                case "blustery": return "Tempestuoso";
                case "windy": return "Ventoso";
                case "cold": return "Frio";
                case "cloudy": return "Nublado";
                case "mostly cloudy (night)": return "Mayormene Nublado";
                case "mostly cloudy (day)": return "Mayormene Nublado";
                case "partly cloudy (night)": return "Parcialmente Nublado";
                case "partly cloudy (day)": return "Parcialmente Nublado";
                case "clear (night)": return "Despejado";
                case "sunny": return "Soleado";
                case "fair (night)": return "Buen tiempo";
                case "fair (day)": return "Buen tiempo";
                case "mixed rain and hail": return "Lluvia y granizo";
                case "hot": return "Caliente";
                case "isolated thunderstorms": return "Tormentas electrricas aisladas";
                case "scattered thunderstorms": return "Tormentas electricas dispersas";
                case "scattered showers": return "Fuertes lluvias dispersas";
                case "heavy snow": return "Fuertes nevadas";
                case "scattered snow showers": return "Nieve dispersa";
                case "partly cloudy": return "Parcialmente nublado";
                case "thundershowers": return "Tormentas electricas";
                case "snow showers": return "Duchas de nieve";
                case "isolated thundershowers": return "Tormentas electricas aisladas";
                default: return string.Empty;
                    
            }                       
        }
        public string traducirDia(string dia)
        {
            switch (dia)
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
