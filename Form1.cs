using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherForecast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void City_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            getWeather();
            ShowingCityValues_lbl.Text = City_txtbox.Text;
        }

        private void SunriseValue_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Sunrise_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string APIKey = "a1bfa82a47aef7debc3de87394d2b7e3";

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",City_txtbox.Text,APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                Condition_lbl.Text = Info.weather[0].main;
                Details_lbl.Text = Info.weather[0].description;
                Temp_lbl.Text = convertToCelcius(Info.main.temp).ToString() + "°C";
                SunsetValues_lbl.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                SunriseValue_lbl.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                WindSpeedValues_lbl.Text = Info.wind.speed.ToString();
                PressureValues_Lbl.Text = Info.main.pressure.ToString();

            }

            DateTime convertDateTime(long sec)
            {
                DateTime day = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc).ToLocalTime();
                day = day.AddSeconds(sec).ToLocalTime();

                return day;
            }

            double convertToCelcius(double kelvin)
            {
                double celcius = kelvin - 273.15;
                return celcius;
            }
        }

        private void Temp_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
