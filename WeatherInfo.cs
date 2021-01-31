using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weather_API_Application
{
    public class WeatherInfo
    {

        // City Weather Data

        public class CurrentWeather
        {
            // Coordinate point properties
            public class coord
            {
                public double lon { get; set; }
                public double lat { get; set; }
            }
            // Weather object properties
            public class weather
            {
                public int id { get; set; }
                public string main { get; set; }
                public string description { get; set; }
            }
            // Main object properties for weather forecast
            public class main
            {
                public double temp { get; set; }
                public double feels_like { get; set; }
                public double temp_min { get; set; }
                public double temp_max { get; set; }
                public double pressure { get; set; }
                public double humidity { get; set; }
            }
            // Wind object property
            public class wind
            {
                public double speed { get; set; }
                public double deg { get; set; }
            }
            // System obect properties
            public class sys
            {
                public string country { get; set; }
                public long sunrise { get; set; }
                public long sunset { get; set; }
            }
            // Root object properties
            public class root
            {
                public string name { get; set; }
                public double dt { get; set; }
                public sys sys { get; set; }
                public wind wind { get; set; }
                public main main { get; set; }
                public List<weather> weather { get; set; }
                public coord coord { get; set; }
            }
        }


        // State Forecast API Data
        public class Forecast
        {
            public class WeatherForecast
            {
                public List<list> list { get; set; }
                public city city { get; set; }
                public weather weather { get; set; }
            }

            public class weather
            {
                public int id { get; set; }
                public string main { get; set; }
                public string description { get; set; }
            }

            public class city
            {
                public string name { get; set; }
            }

            public class list
            {
                public double dt { get; set; }
                public double pressure { get; set; }
                public double humidity { get; set; }
                public double speed { get; set; }
                public List<weather> weather { get; set; }
            }
        }
    }
}
