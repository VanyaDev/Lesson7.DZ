using System;
using System.Security.Cryptography.X509Certificates;

namespace WeatherInfo
{
	class Weather
	{
		public int Date { get; set; }
		public float min_Temperature { get; set; }
		public float max_Temperature { get; set; }
		public byte Overcast { get; set; }
		public byte Precipitation { get; set; }
		public float Humidity { get; set; }
		public float Winde_Power { get; set; }
		public byte Direction_of_the_wind { get; set; }
		public byte Moon_phase { get; set; }
	}
}

