using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;
using System.Windows;
using System.Globalization;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Weather_API_Application
{
    public partial class Form1 : Form
    {
        const string API_KEY = "1729401ae78b17b9b80f632348bafd11";
        const string API_MAP_KEY = "cc7f7c5e96348550b72e4ead64627d9f";
        const string City = "Auburn";
        public string imagePath = "";
        public Form1()
        {
            InitializeComponent();
            // Calling the API using Local City with Imperial Metrics
            GetWeather(City);
        }
        // Pulling API from openweathermap.org
        public void GetWeather(string City)
        {
            using (WebClient Web = new WebClient())
            {

                // Open weather Current data
                string CurrentWeatherUrl = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=imperial&APPID={1}", City, API_KEY);
                var CurrentWeatherJson = Web.DownloadString(CurrentWeatherUrl);
                var CurrentWeatherAPI = JsonConvert.DeserializeObject<WeatherInfo.CurrentWeather.root>(CurrentWeatherJson);
                WeatherInfo.CurrentWeather.root WeatherInfo = CurrentWeatherAPI;

                // Latitude, Longitude
                var lat = WeatherInfo.coord.lat;
                var lon = WeatherInfo.coord.lon;

                // Open weather Forecast Data
                string WeatherForecasatUrl = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}", City, API_KEY);
                var WeatherForecastJson = Web.DownloadString(WeatherForecasatUrl);
                var WeatherForecastAPI = JsonConvert.DeserializeObject<WeatherInfo.Forecast.WeatherForecast>(WeatherForecastJson);
                WeatherInfo.Forecast.WeatherForecast WeatherForecast = WeatherForecastAPI;

                /* Importing Map
                string xlat = Convert.ToString(lat);
                string ylon = Convert.ToString(lon);
                string MapUrl = string.Format("http://maps.openweathermap.org/maps/2.0/weather/TA2/{0}/{1}/{2}?date={3}&opacity=0.9&fill_bound=true&appid={4}", 2, xlat, ylon, WeatherForecast.list[1].dt, API_MAP_KEY);
                byte[] MapData = Web.DownloadData(MapUrl);
                using (MemoryStream mem = new MemoryStream(MapData))
                {
                    using (var img = Image.FromStream(mem))
                    {
                        Picture_Map.Image = img;
                    }
                }*/
                
                // Format United States North America Country Code
                string country = WeatherInfo.sys.country;
                if (country.ToUpper() == "US")
                {
                    country = "United States, America";
                }

                // Format the temperature
                int Weather_Temperature = Convert.ToInt32(Math.Floor(WeatherInfo.main.temp));
                // formatting temperatures
                double temp_min = Math.Floor(WeatherInfo.main.temp_min);
                double temp_max = Math.Floor(WeatherInfo.main.temp_max);

                // Description string
                var description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(WeatherForecast.list[1].weather[0].description);

                // Epoch Date Time
                var Date = getDate();
                var Time = getDate(WeatherForecast.list[1].dt);
                string.Format("{0:MM/dd/yy}", Date);

                // Measure Degrees for Direction
                var degrees = WeatherInfo.wind.deg;
                var direction = "";
                if (degrees >= 30 && degrees <= 60) direction = "Northeast";
                if (degrees >= 60 && degrees <= 120) direction = "North";
                if (degrees >= 120 && degrees <= 150) direction = "Northwest";
                if (degrees >= 150 && degrees <= 210) direction = "West";
                if (degrees >= 210 && degrees <= 240) direction = "Southwest";
                if (degrees >= 240 && degrees <= 300) direction = "South";
                if (degrees >= 300 && degrees <= 330) direction = "Southeast";
                if ((degrees >= 0 && degrees <= 30) || (degrees >= 330 && degrees <= 360)) direction = "East";


                // City, State Forecast for weather
                Label_City.Text = string.Format("{0}", WeatherInfo.name + " Weather");
                Label_Country.Text = string.Format("{0}", country);
                Temperature.Text = string.Format("{0} \u00B0" + "F", Weather_Temperature);
                Label_Forecast.Text = string.Format("{0} Forecast", City);
                Label_Conditions.Text = string.Format("{0} with", WeatherForecast.list[1].weather[0].main);
                Label_Description.Text = string.Format("{0}", description);
                Label_Temp_Min.Text = string.Format("Low: {0}\u00b0F", temp_min);
                Label_Temp_Max.Text = string.Format("High: {0}\u00B0F", temp_max);
                Label_Feels_Like.Text = string.Format("Feels Like: {0}\u00b0F", Math.Floor(WeatherInfo.main.feels_like));
                Label_Pressure.Text = string.Format("Pressure: {0} hPa", WeatherInfo.main.pressure);
                Label_Humidity.Text = string.Format("Humidity: {0}%", WeatherInfo.main.humidity);
                Label_Wind_Speed.Text = string.Format("Winds: {0} mph", Math.Floor(WeatherInfo.wind.speed));
                Label_Degrees.Text = string.Format("Degrees: {0} {1}", degrees, direction);
                Label_City_Coordinates.Text = string.Format("({0}, {1})", Math.Floor(lat), Math.Floor(lon));
                Label_Day.Text = string.Format("{0}", getDateFormat());
                Label_Sunrise_Time.Text = string.Format("{0}", getTimeFormatSS_SR(WeatherInfo.sys.sunrise, WeatherInfo.sys.sunset)[0]);
                Label_Sunset_Time.Text = string.Format("{0}", getTimeFormatSS_SR(WeatherInfo.sys.sunrise, WeatherInfo.sys.sunset)[1]);
                // Set Images
                Picture_City.Image = setIconCity(WeatherInfo.weather[0].id, WeatherForecast.list[1].dt);
                Picture_City.Location = new Point(13, 113);
                Picture_City.Size = new Size(175, 160);
                Picture_City.Image = resizeImage(Picture_City.Image, new Size(175, 160));
            }
        }
        DateTime getDate()
        {
            var Date_Time = DateTime.Now;
            var Date = Date_Time.Date;
            return Date;
        }
        DateTime getDate(double milliseconds)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milliseconds).ToLocalTime();
            return day;
        }
        public bool getTimeOfDay(double milliseconds)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milliseconds).ToLocalTime();
            var Hour = day.Hour;
            var Am_Pm = day.ToString("tt", CultureInfo.InvariantCulture);

            bool dayTime = false;
            if (Hour >= 6 && Hour <= 18)
            {
                dayTime = true;
            } else if (Hour < 6 || Hour > 18)
            {
                dayTime = false;
            }
            return dayTime;
        }
        public string getDateFormat()
        {
            var Date_Time = DateTime.Now;
            var Date = Date_Time.ToString("MMMM dd, yyyy");
            return Date;
        }
        public string[] getTimeFormatSS_SR(long ss, long sr)
        {
            string[] times = new string[2];
            // Sunset
            DateTime ss_day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            ss_day = ss_day.AddSeconds(ss).ToLocalTime();
            var ss_time = ss_day.ToString("HH:mm tt");
            // Sunrise
            DateTime sr_day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            sr_day = sr_day.AddSeconds(sr).ToLocalTime();
            var sr_time = sr_day.ToString("HH:mm tt");
            times[0] = ss_time;
            times[1] = sr_time;
            return times;
        }
        
        Image setIconCity(int id, double milliseconds)
        {
            string[] thunderstorms = {"200","201","202","210", "211", "212", "221", "230", "231", "232", "781", "900", "901", "902", "960", "961" };
            string[] drizzle = { "300", "301", "302", "310", "311", "312", "313", "314", "321", "701" };
            string[] rain = { "501", "520", "521", "522", "531" };
            string[] lightrain = { "500" };
            string[] heavyrain = { "502", "503", "504" };
            string[] hail = { "511", "906" };
            string[] snow = { "600", "601", "602", "620", "621", "622", "903" };
            string[] sleet = { "611", "612" };
            string[] rain_snow = { "615", "616" };
            string[] fog = { "711", "721", "741", "762" };
            string[] windy = { "731", "751", "761", "771", "905", "952", "953", "954", "955", "956", "957", "958", "959", "962" };
            string[] cloudy = { "803", "804" };
            // If time is before noon , use day
            string[] clear_day = { "800", "904", "951" };
            string[] partly_cloudy_day = { "801", "802" };
            // If time is after noon , use night
            string[] clear_night = { "800", "904", "951" };
            string[] partly_cloudy_night = { "801", "802" };

            
            foreach(string x in thunderstorms)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Thunder.gif";
                }
            }
            foreach (string x in drizzle)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Drizzle.gif";
                }
            }
            foreach (string x in rain)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Rain.gif";
                }
            }
            foreach (string x in lightrain)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Light_Rain.gif";
                }
            }
            foreach (string x in heavyrain)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Heavy_Rain.gif";
                }
            }
            foreach (string x in hail)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Hail.gif";
                }
            }
            foreach (string x in snow)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Snow.gif";
                }
            }
            foreach (string x in sleet)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Sleet.gif";
                }
            }
            foreach (string x in rain_snow)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Rain_Snow.gif";
                }
            }
            foreach (string x in fog)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Fog.gif";
                }
            }
            foreach (string x in windy)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Windy.gif";
                }
            }
            foreach (string x in cloudy)
            {
                if (Convert.ToInt32(x) == id)
                {
                    imagePath = "Cloudy.gif";
                }
            }
            // Get if Day or Night
            // true == day time
            // false == night time
            if (getTimeOfDay(milliseconds))
            {
                foreach (string x in clear_day)
                {
                    if (Convert.ToInt32(x) == id)
                    {
                        imagePath = "Clear_Day.gif";
                    }
                }
                foreach (string x in partly_cloudy_day)
                {
                    if (Convert.ToInt32(x) == id)
                    {
                        imagePath = "Partly_Cloudy_Day.gif";
                    }
                }
            } else
            {
                foreach (string x in clear_night)
                {
                    if (Convert.ToInt32(x) == id)
                    {
                        imagePath = "Clear_Night.gif";
                    }
                }
                foreach (string x in partly_cloudy_night)
                {
                    if (Convert.ToInt32(x) == id)
                    {
                        imagePath = "Partly_Cloudy_Night.gif";
                    }
                }
            }
            
            string IconsDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Weather_Icons");
            string filePath = IconsDirectory +  "/" + imagePath;
            Image WeatherIcon = Image.FromFile(filePath);
            return WeatherIcon;
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void Form_Button_Click(object sender, EventArgs e)
        {
            string city = Form_Search.Text;
            try
            {
                if (city != "")
                {
                    GetWeather(city);
                }
            } catch
            {
                Form_Search.Text = "Wrong City Name";
            }
            finally { }
        }
        private void Form_Search_Enter(object sender, EventArgs e)
        {
            if (Form_Search.Text != "")
            {
                Form_Search.Text = String.Format("");
            }
        }
    }
}