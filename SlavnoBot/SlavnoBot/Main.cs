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

namespace SlavnoBot
{
    public partial class Main : Form
    {

        private Bot myBot;
        private User myUser;
        private Request lastRequest = null;
        private Result lastResult = null;
        string urlXml = @"http://api.openweathermap.org/data/2.5/weather?id=3085610&mode=xml&APPID=1477c81fde8d4a0269c3714b40a61d3a";

        public Main()
        {
            InitializeComponent();
            image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\herb.png");
            image_pb.SizeMode = PictureBoxSizeMode.Zoom;

            input_tb.Focus();
            myBot = new Bot();
            myBot.loadSettings();
            myUser = new User("DefaultUser", myBot);

            myBot.loadAIMLFromFiles();

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            processingAIML();
        }

        public string connectionXml()
        {
            try
            {
                using (var client = new WebClient())
                {
                    var data = client.DownloadString(urlXml);
                    return data;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string weatherTemperature()
        {
           try
           {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(connectionXml());

                string temp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;

                double tempB = double.Parse(temp, CultureInfo.InvariantCulture) - 273.16;

                double tempC = Math.Round(tempB, 2);


                return tempC.ToString();
                    
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public String weatherMain()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(connectionXml());

                string main = doc.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;

                return main;
            }
            catch
            {
                return null;
            }
        }
        private void processingAIML()
        {
            if (myBot.isAcceptingUserInput)
            {
                image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\herb.png");
                string patternPogoda = "pogod.*";
                string patternBaszta = @"basz.*|bram.*";
                Regex rgxWeather = new Regex(patternPogoda, RegexOptions.IgnoreCase);
                Regex rgxBasza = new Regex(patternBaszta, RegexOptions.IgnoreCase);
               // MessageBox.Show("zaakceptoowałem wejśćie");
                string inputText = input_tb.Text;
                input_tb.Text = string.Empty;
                output_lb.Items.Add("Ty: " + inputText);

                if (rgxWeather.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\sun.png");
                    output_lb.Items.Add("Bot: Aktualna temperatura to: " + weatherTemperature());
                    output_lb.Items.Add("       Aktualna pogoda to: " + weatherMain());
                    output_lb.TopIndex = output_lb.Items.Count - 2;

                }
                else if (rgxBasza.IsMatch(inputText) == true)
                {
                    image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\dsc_0185_kopia_t1.jpg");
                }
                else
                {
                    output_lb.TopIndex = output_lb.Items.Count - 1;
                    Request myRequest = new Request(inputText, myUser, myBot);
                    Result myResult = myBot.Chat(myRequest);
                    lastRequest = myRequest;
                    lastResult = myResult;
                    output_lb.Items.Add("Bot: " + myResult.Output);
                    output_lb.TopIndex = output_lb.Items.Count - 1;
                }
                


            }
            else
            {
                image_pb.Image = Image.FromFile(@"E:\GitHub\SlavnoBOT\SlavnoBot\SlavnoBot\Images\herb.png");
                // MessageBox.Show("nie zaakceptoowałem wejśćie");
                input_tb.Text = string.Empty;
                output_lb.Items.Add("Bot not accepting user input.");
                output_lb.TopIndex = output_lb.Items.Count - 1;
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
    }
}
