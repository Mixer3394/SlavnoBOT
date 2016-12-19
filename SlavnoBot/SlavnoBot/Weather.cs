using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace SlavnoBot
{
    public class Weather
    {
        public static String futureWeatherMain()
        {
            try
            {
                string urlXml = @"http://api.openweathermap.org/data/2.5/forecast?id=3085610&mode=xml&APPID=1477c81fde8d4a0269c3714b40a61d3a";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Connection.connectionXml(urlXml));
                string pogoda = "";

                XmlNodeList time = doc.GetElementsByTagName("time");

                XmlNodeList nodes1 = doc.DocumentElement.SelectSingleNode("forecast").ChildNodes;
                string patternHour = @"15:00";
                Regex rgxHour = new Regex(patternHour, RegexOptions.IgnoreCase);
                foreach (XmlNode times in nodes1)
                {
                    string timer = times.Attributes["from"].Value;
                    if (rgxHour.IsMatch(timer) == true)
                    {
                        string weather = times.SelectSingleNode("symbol").Attributes["name"].Value;
                        string temperature = times.SelectSingleNode("temperature").Attributes["value"].Value;
                        pogoda = pogoda + "\nData: " + timer + "\n" + "Pogoda: " + Translate.futureTranslateWeater(weather) + "\n" + "Temperatura: " + temperature + "°C\n ";
                    }

                }

                return pogoda;
            }
            catch
            {
                return null;
            }
        }
        public static String weatherMain()
        {
            try
            {
                string urlXml = @"http://api.openweathermap.org/data/2.5/weather?id=3085610&mode=xml&APPID=1477c81fde8d4a0269c3714b40a61d3a";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Connection.connectionXml(urlXml));

                string main = doc.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;

                return main;
            }
            catch
            {
                return null;
            }
        }
        public static string weatherTemperature()
        {
            try
            {
                string urlXml = @"http://api.openweathermap.org/data/2.5/weather?id=3085610&mode=xml&APPID=1477c81fde8d4a0269c3714b40a61d3a";
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Connection.connectionXml(urlXml));

                string temp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;

                double tempB = double.Parse(temp, CultureInfo.InvariantCulture) - 273.16;

                double tempC = Math.Round(tempB, 2);


                return tempC.ToString();

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
