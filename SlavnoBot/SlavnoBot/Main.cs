using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Xml;
using System.Globalization;
using System.IO;
using System.Diagnostics;

namespace SlavnoBot
{
    public partial class Main : Form
    {

        private Bot myBot;
        private User myUser;

        
        public string translateWeater(String weather)
        {
            if (weather == "clear sky")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/01d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie nad Sławnem jest czyste niebo";
            }
            if (weather == "few clouds")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/02d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie nad Sławnem są nieliczne chmury";
            }
            if (weather == "broken clouds")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/04d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie nad Sławnem są porozrywane chmury";
            }
            if (weather == "overcast clouds")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/04d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie nad Sławnem występuje zachmurzenie";
            }
            if (weather == "scattered clouds")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/03d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie nad Sławnem są rozproszone chmury";
            }
            if (weather == "shower rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie pada lekki deszcz";
            }
            if (weather == "light intensity drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie jest lekka intensywna mżawka";
            }
            if (weather == "drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie jest mżawka";
            }
            if (weather == "heavy intensity drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie jest mocna intensywna mżawka";
            }
            if (weather == "light intensity drizzle rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są lekkie intensywne opady deszczu";
            }
            if (weather == "drizzle rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie pada deszcz";
            }
            if (weather == "heavy intensity drizzle rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są mocne intensywne opady deszczu";
            }
            if (weather == "shower rain and drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie jest deszcz i mżawka";
            }
            if (weather == "heavy shower rain and drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie jest mocny deszcz i mżawka";
            }
            if (weather == "shower drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie jest lekka mżawka";
            }
            if (weather == "rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/10d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie pada deszcz";
            }
            if (weather == "light rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/10d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie lekko pada deszcz";
            }
            if (weather == "moderate rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/10d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są przelotne opady deszczu";
            }
            if (weather == "heavy intensity rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/10d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są mocne intensywne opady deszczu";
            }
            if (weather == "very heavy rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/10d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są bardzo mocne opady deszczu";
            }
            if (weather == "extreme rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/10d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są ekstremalne opady deszczu";
            }
            if (weather == "freezing rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są opady marznącego deszczu";
            }
            if (weather == "light intensity shower rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są mało intensywne opady deszczu";
            }
            if (weather == "heavy intensity shower rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są bardzo intensywne opady deszczu";
            }
            if (weather == "ragged shower rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/09d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "        Aktualnie w Sławnie są nierówne opady deszczu";
            }
            if (weather == "thunderstorm")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z piorunami";
            }
            if (weather == "thunderstorm with light rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z lekkim deszczem";
            }
            if (weather == "thunderstorm with rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z deszczem";
            }
            if (weather == "light thunderstorm")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest lekka burza";
            }
         
            if (weather == "thunderstorm with heavy rain")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z mocnym deszczem";
            }
            if (weather == "heavy thunderstorm")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest mocna burza";
            }
            if (weather == "ragged thunderstorm")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z piorunami";
            }
            if (weather == "thunderstorm with light drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z lekką mżawką";
            }
            if (weather == "thunderstorm with drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z mżawką";
            }
            if (weather == "thunderstorm with heavy drizzle")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/11d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest burza z mocną mżawką";
            }
            if (weather == "snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie pada śnieg";
            }
            if (weather == "light snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są lekkie opady śniegu";
            }
            if (weather == "heavy snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są mocne opady śniegu";
            }
            if (weather == "sleet")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie pada śnieg z deszczem";
            }
            if (weather == "shower sleet")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie lekko pada śnieg z deszczem";
            }
            if (weather == "light rain and snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie pada lekki deszcz i śnieg";
            }
            if (weather == "rain and snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie pada śnieg i deszcz";
            }
            if (weather == "light shower snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są lekkie opady śniegu";
            }
            if (weather == "shower snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są lekkie opady śniegu";
            }
            if (weather == "heavy shower snow")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/13d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są mocne opady śniegu";
            }
            if (weather == "mist")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest mgła";
            }
            if (weather == "smoke")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest intensywne zadymienie (smok)";
            }
            if (weather == "haze")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest lekka mgła";
            }
            if (weather == "sand, dust whirls")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są wiry pyłowe";
            }
            if (weather == "fog")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest mgła";
            }
            if (weather == "sand")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są wiry pyłowe";
            }
            if (weather == "squalls")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie są występuje szkwał";
            }
            if (weather == "tornado")
            {
                WebClient wc = new WebClient();
                byte[] imageData = wc.DownloadData("http://openweathermap.org/img/w/50d.png"); //DownloadData function from here
                MemoryStream stream = new MemoryStream(imageData);
                image_pb.Image = Image.FromStream(stream);
                stream.Close();
                return "       Aktualnie w Sławnie jest tornado";
            }
            
            else
            {
                return "       Aktualnie w Sławnie jest słoncznie";
            }






        }
      


        public Main()
        {
            InitializeComponent();
            image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\herb.png");
            image_pb.SizeMode = PictureBoxSizeMode.Zoom;
            timer1.Start();
            displayTime();
            input_tb.Focus();
            myBot = new Bot();
            myBot.loadSettings();
            myUser = new User("DefaultUser", myBot);

            myBot.loadAIMLFromFiles();

        }

        private void botModule(string tekst)
        {
            Request myRequest = new Request(Rgx.regexFunction(tekst), myUser, myBot);
            Result myResult = myBot.Chat(myRequest);
            output_lb.Items.Add("Bot: ");
            foreach (string s in Regex.Split(myResult.Output, "\n"))
                output_lb.Items.Add("          " + s);
                output_lb.TopIndex = output_lb.Items.Count - 1;
        }

        private void mapViewer(string nazwa, string plik)
        {
            if (plik != null)
            {
                if (placeView.functionPlaceView(nazwa) != null)
                {
                    image_pb.Image = Image.FromFile(plik);
                    output_lb.Items.Add("Bot:");
                    output_lb.Items.Add("           Wyświetliłem Ci mapę");
                    output_lb.TopIndex = output_lb.Items.Count - 2;
                    Maps maps = new Maps(placeView.functionPlaceView(nazwa));
                    maps.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Nie mogę otworzyć nowego okna");
                }
            }
            else
            {
                if (placeView.functionPlaceView(nazwa) != null)
                {
                    output_lb.Items.Add("Bot:");
                    output_lb.Items.Add("           Wyświetliłem Ci mapę");
                    output_lb.TopIndex = output_lb.Items.Count - 2;
                    Maps maps = new Maps(placeView.functionPlaceView(nazwa));
                    maps.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Nie mogę otworzyć nowego okna");
                }
            }
           
        }
        private void send_btn_Click(object sender, EventArgs e)
        {
            processingAIML();
        }


        private void processingAIML()
        {
            if (input_tb.Text != "")
            {
                image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\herb.png");
                string patternPogoda = "pogod.*";
                string patternIs = @"jest.*";
                string patternFuture = @"będzie|bedzie";
                string patternBaszta = @"basz.*|bram.*";
                string patternTemperatura = @"temperatur.*|Temperatur.*";
                string patternWhere = @"gdzie|Gdzie";
                string patternBasztaSlupska = "baszta Słupska|Baszta Słupska|baszta slupska|brama Słupska|brama Słupska|brama slupska";
                string patternSlawno = @"Slawno|Sławno|sławno|slawno";
                string patternBasztaKoszalinska = "baszta Koszalińska|Baszta Koszalińska|baszta koszalinska|brama Koszalińska|brama Koszalińska|brama koszalinska";
                string patternPoczta = @"pocz.*|Pocz.*";
                string patternFood = @"zjem|zjeść|zjesc|restauracj.*|napi.*";
                string patternShop = "sklep.*";
                string patternPetrolStation = "stacja benzynowa| stacj.* benzynow.*| benzyn.*| paliwo .*|zatank.*";
                string patternDworzecPKP = "dworzec|PKP|pkp|stacja|pociag.*|kolej.*";
                string patternKosciol = "kosciol|Kosciół|Kościół|Kościol|kosciół|kościół|kościol|kościele|kosciele|Kosciele|Kościele";
                string patternWNMP = "WNMP|Wniebowzięcia Najświętszej Marii Panny|Wniebowziecia Najswietszej Marii Panny|Wniebowzięcia NMP|wnmp";
                string patternAntoniego = "sw.|świetego|św.|swietego|Antoniego|Antonii";
                string patternRatusz = "urząd.*|urzad.*|ratusz.*";
                string patternApteka = "aptek.*|Aptek.*|lek.*";
                string patternSzpital = "szpital.*|Szpital.*|pomoc.*|medycyn.*";
                string patternPolicja = "policj.*|POLICJ.*|Policj.*";
                string patternStraz = "straz.*|straż.*|Straż.*|Straz.*|STRAŻ.*";
                string patternCmentarz = "cmentarz.*|Cmentarz.*|CMENTARZ.*";
                string patternKoniec = "dowidzenia|Dowidzenia|Zamknij.*|zamknij.*| Zamkn.*";



                Regex rgxWeather = new Regex(patternPogoda, RegexOptions.IgnoreCase);
                Regex rgxTempreature = new Regex(patternTemperatura, RegexOptions.IgnoreCase);
                Regex rgxBasza = new Regex(patternBaszta, RegexOptions.IgnoreCase);
                Regex rgxIs = new Regex(patternIs, RegexOptions.IgnoreCase);
                Regex rgxFuture = new Regex(patternFuture, RegexOptions.IgnoreCase);
                Regex rgxWhere = new Regex(patternWhere, RegexOptions.IgnoreCase);
                Regex rgxBasztaSlupska = new Regex(patternBasztaSlupska, RegexOptions.IgnoreCase);
                Regex rgxSlawno = new Regex(patternSlawno, RegexOptions.IgnoreCase);
                Regex rgxBasztaKoszalinska = new Regex(patternBasztaKoszalinska, RegexOptions.IgnoreCase);
                Regex rgxPoczta = new Regex(patternPoczta, RegexOptions.IgnoreCase);
                Regex rgxFood = new Regex(patternFood, RegexOptions.IgnoreCase);
                Regex rgxShop = new Regex(patternShop, RegexOptions.IgnoreCase);
                Regex rgxPetrolStation = new Regex(patternPetrolStation, RegexOptions.IgnoreCase);
                Regex rgxDworzecPKP = new Regex(patternDworzecPKP, RegexOptions.IgnoreCase);
                Regex rgxKosciol = new Regex(patternKosciol, RegexOptions.IgnoreCase);
                Regex rgxWNMP = new Regex(patternWNMP, RegexOptions.IgnoreCase);
                Regex rgxAntoni = new Regex(patternAntoniego, RegexOptions.IgnoreCase);
                Regex rgxRatusz = new Regex(patternRatusz, RegexOptions.IgnoreCase);
                Regex rgxApteka = new Regex(patternApteka, RegexOptions.IgnoreCase);
                Regex rgxPolicja = new Regex(patternPolicja, RegexOptions.IgnoreCase);
                Regex rgxStraz = new Regex(patternStraz, RegexOptions.IgnoreCase);
                Regex rgxSzpital = new Regex(patternSzpital, RegexOptions.IgnoreCase);
                Regex rgxKoniec = new Regex(patternKoniec, RegexOptions.IgnoreCase);
                Regex rgxCmentarz = new Regex(patternCmentarz, RegexOptions.IgnoreCase);


                string inputText = input_tb.Text;
                input_tb.Text = string.Empty;
               // output_lb.Items.Add(" ");
                output_lb.Items.Add("Ty: " + inputText);

                if (rgxWeather.IsMatch(inputText) == true && rgxIs.IsMatch(inputText) == true)
                {
                    output_lb.Items.Add("Bot: Aktualna temperatura to: " + Weather.weatherTemperature() + "°C");
                    output_lb.Items.Add(translateWeater(Weather.weatherMain()));
                    output_lb.TopIndex = output_lb.Items.Count - 2;

                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxSlawno.IsMatch(inputText) == true)
                {
                    mapViewer("Slawno",null);
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxBasztaSlupska.IsMatch(inputText) == true)
                {
                    mapViewer("Brama+Słupska", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\dsc_0185_kopia_t1.jpg");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxBasztaKoszalinska.IsMatch(inputText) == true)
                {
                    mapViewer("Brama+Koszalińska", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\zdjecie1398179239.jpg");

                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxBasza.IsMatch(inputText) == true)
                {
                    mapViewer("Brama", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\zdjecie1398179239.jpg");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxPoczta.IsMatch(inputText) == true)
                {
                    mapViewer("Poczta", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\P5314987.JPG");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxFood.IsMatch(inputText) == true)
                {
                    mapViewer("restauracja", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\pobrane.jpg");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxShop.IsMatch(inputText) == true)
                {
                    mapViewer("sklep",null);
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxPetrolStation.IsMatch(inputText) == true)
                {
                    mapViewer("stacja+benzynowa",null);
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxDworzecPKP.IsMatch(inputText) == true)
                {
                    mapViewer("Dworzec +PKP", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\dworzec_2.JPG");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxKosciol.IsMatch(inputText) == true && rgxWNMP.IsMatch(inputText) == true)
                {
                    mapViewer("Kosciół+WNMP", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\kosciol_4");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxKosciol.IsMatch(inputText) == true && rgxAntoni.IsMatch(inputText) == true)
                {
                    mapViewer("Kosciół+św+Antoniego", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\P6025323.JPG");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxKosciol.IsMatch(inputText) == true)
                {
                    mapViewer("Kościół", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\kosciol_4");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxRatusz.IsMatch(inputText) == true)
                {
                    mapViewer("Ratusz", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\RATUSZ 2.JPG");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxApteka.IsMatch(inputText) == true)
                {
                    mapViewer("Apteka", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\apteka.gif");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxPolicja.IsMatch(inputText) == true)
                {
                    mapViewer("Policja", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\policja_LOGO_1_0.jpg");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxSzpital.IsMatch(inputText) == true)
                {
                    mapViewer("Szpital", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\apteka.gif");

                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxStraz.IsMatch(inputText) == true)
                {
                    mapViewer("Straz", @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\straz.jpg");
                }
                else if (rgxWhere.IsMatch(inputText) == true && rgxCmentarz.IsMatch(inputText) == true)
                {
                    mapViewer("Cmentarz", null);
                }
                else if (rgxKosciol.IsMatch(inputText) == true && rgxWNMP.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\kosciol_4.jpg");
                    botModule(inputText);
                }
                else if (rgxRatusz.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\RATUSZ 2.JPG");
                    botModule(inputText);
                }
                else if (rgxApteka.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\apteka.gif");
                    botModule(inputText);
                }
                else if (rgxPolicja.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\policja_LOGO_1_0.jpg");
                    botModule(inputText);
                }

                else if (rgxKosciol.IsMatch(inputText) == true && rgxAntoni.IsMatch(inputText) == true)
                {
                    MessageBox.Show("wszedlem");
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\P6025323.JPG");
                    botModule(inputText);
                }
                else if (rgxPoczta.IsMatch(inputText) == true)
                {
                        image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\P5314987.JPG");
                        botModule(inputText);
                }
                else if (rgxDworzecPKP.IsMatch(inputText) == true)
                {
                    
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\dworzec_2.JPG");
                    botModule(inputText);
                }
                else if (rgxBasza.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\dsc_0185_kopia_t1.jpg");
                    botModule(inputText);
                }
                else if (rgxTempreature.IsMatch(inputText) == true && rgxIs.IsMatch(inputText) == true)
                {
                    output_lb.Items.Add("Bot: Aktualna temperatura to: " + Weather.weatherTemperature() + "°C");
                    output_lb.TopIndex = output_lb.Items.Count - 1;

                }
                else if ((rgxFuture.IsMatch(inputText) == true && rgxWeather.IsMatch(inputText) == true) || (rgxTempreature.IsMatch(inputText) == true && rgxFuture.IsMatch(inputText) == true))
                {
                    output_lb.Items.Add("Bot: Pogoda na kolejne dni:");
                    foreach (string s in Regex.Split(Weather.futureWeatherMain(), "\n"))
                        output_lb.Items.Add("          " + s);
                        output_lb.TopIndex = output_lb.Items.Count - 1;

                }
                else if (rgxStraz.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\straz.jpg");
                    botModule(inputText);
                }
                else if(rgxKoniec.IsMatch(inputText) == true)
                {
                    this.Close();
                }
                else
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\herb.png");
                    botModule(inputText);
                }
            }
            else
            {
                image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\herb.png");
                MessageBox.Show("Proszę zapytać o coś!");
                
            }
        }


       private void saveChat()
        {
            string sPath = @"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\File\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            try
            {
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                foreach (var item in output_lb.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }

                SaveFile.Close();

                MessageBox.Show("Rozmowa została zapisana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie mogę zapiać pliku " + ex);
            }
        }

        private void new_send_btn_Click(object sender, EventArgs e)
        {
            processingAIML();
        }

        private void input_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                processingAIML();
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zapiszPrzebiegRozmowyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveChat();
            
        }

        private void otwórzFolderZRozmowamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File|*.txt";
            openFileDialog1.Title = "Otwórz wybrany plik";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Process.Start("notepad.exe", openFileDialog1.FileName);
            }
        }

        private void dokończRozmoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File|*.txt";
            openFileDialog1.Title = "Otwórz wybrany plik";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                output_lb.Items.AddRange(lines);
            }
           
        }

        private void wyczyśćRozmoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać rozmowę, przed czyszczeniem ?", "Czyszczenie rozmowy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveChat();
            }
            else if (dialogResult == DialogResult.No)
            {
                output_lb.Items.Clear();
            }
        }

        private void time_label_Click(object sender, EventArgs e)
        {

        }
        private void displayTime()
        {
            time_label.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString();
            timer1.Start();
        }
    }
}
