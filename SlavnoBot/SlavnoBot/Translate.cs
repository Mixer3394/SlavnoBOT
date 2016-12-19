using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlavnoBot
{
    public class Translate
    {
        public static string futureTranslateWeater(String weather)
        {
            if (weather == "clear sky")
            {
                return "czyste niebo";
            }
            if (weather == "few clouds")
            {
                return "nieliczne chmury";
            }
            if (weather == "broken clouds")
            {
                return "porozrywane chmury";
            }
            if (weather == "overcast clouds")
            {
                return "zachmurzenie";
            }
            if (weather == "scattered clouds")
            {
                return "rozproszone chmury";
            }
            if (weather == "shower rain")
            {
                return "lekkie opady deszcz";
            }
            if (weather == "light intensity drizzle")
            {
                return "lekka intensywna mżawka";
            }
            if (weather == "drizzle")
            {
                return "mżawka";
            }
            if (weather == "heavy intensity drizzle")
            {
                return "mocna intensywna mżawka";
            }
            if (weather == "light intensity drizzle rain")
            {
                return "lekkie intensywne opady deszczu";
            }
            if (weather == "drizzle rain")
            {
                return "opady deszczu";
            }
            if (weather == "heavy intensity drizzle rain")
            {
                return "mocne intensywne opady deszczu";
            }
            if (weather == "shower rain and drizzle")
            {
                return "deszcz i mżawka";
            }
            if (weather == "heavy shower rain and drizzle")
            {
                return "mocny deszcz i mżawka";
            }
            if (weather == "shower drizzle")
            {
                return "lekka mżawka";
            }
            if (weather == "rain")
            {
                return "opady deszczu";
            }
            if (weather == "light rain")
            {
                return "lekkie opady deszczu";
            }
            if (weather == "moderate rain")
            {
                return "przelotne opady deszczu";
            }
            if (weather == "heavy intensity rain")
            {
                return "mocne intensywne opady deszczu";
            }
            if (weather == "very heavy rain")
            {
                return "bardzo mocne opady deszczu";
            }
            if (weather == "extreme rain")
            {
                return "ekstremalne opady deszczu";
            }
            if (weather == "freezing rain")
            {
                return "opady marznącego deszczu";
            }
            if (weather == "light intensity shower rain")
            {
                return "mało intensywne opady deszczu";
            }
            if (weather == "heavy intensity shower rain")
            {
                return "bardzo intensywne opady deszczu";
            }
            if (weather == "ragged shower rain")
            {
                return "nierówne opady deszczu";
            }
            if (weather == "thunderstorm")
            {
                return "burza z piorunami";
            }
            if (weather == "thunderstorm with light rain")
            {
                return "burza z lekkim deszczem";
            }
            if (weather == "thunderstorm with rain")
            {
                return "burza z deszczem";
            }
            if (weather == "light thunderstorm")
            {
                return "lekka burza";
            }

            if (weather == "thunderstorm with heavy rain")
            {
                return "burza z mocnym deszczem";
            }
            if (weather == "heavy thunderstorm")
            {
                return "mocna burza";
            }
            if (weather == "ragged thunderstorm")
            {
                return "burza z piorunami";
            }
            if (weather == "thunderstorm with light drizzle")
            {
                return "burza z lekką mżawką";
            }
            if (weather == "thunderstorm with drizzle")
            {
                return "burza z mżawką";
            }
            if (weather == "thunderstorm with heavy drizzle")
            {
                return "burza z mocną mżawką";
            }
            if (weather == "snow")
            {
                return "opady śniegu";
            }
            if (weather == "light snow")
            {
                return "lekkie opady śniegu";
            }
            if (weather == "heavy snow")
            {
                return "mocne opady śniegu";
            }
            if (weather == "sleet")
            {
                return "opady śniegu z deszczem";
            }
            if (weather == "shower sleet")
            {
                return "lekkie opady śniegu z deszczem";
            }
            if (weather == "light rain and snow")
            {
                return "lekkie opady śniegu i deszczu";
            }
            if (weather == "rain and snow")
            {
                return "opady śniegu i deszczu";
            }
            if (weather == "light shower snow")
            {
                return "lekkie opady śniegu";
            }
            if (weather == "shower snow")
            {
                return "lekkie opady śniegu";
            }
            if (weather == "heavy shower snow")
            {
                return "mocne opady śniegu";
            }
            if (weather == "mist")
            {
                return "mgła";
            }
            if (weather == "smoke")
            {
                return "intensywne zadymienie (smok)";
            }
            if (weather == "haze")
            {
                return "lekka mgła";
            }
            if (weather == "sand, dust whirls")
            {
                return "wiry pyłowe";
            }
            if (weather == "fog")
            {
                return "mgła";
            }
            if (weather == "sand")
            {
                return "wiry pyłowe";
            }
            if (weather == "squalls")
            {
                return "szkwał";
            }
            if (weather == "tornado")
            {
                return "tornado";
            }

            else
            {
                return "słoncznie";
            }
        }
    }
}
