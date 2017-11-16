using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站2
{
	public class WeatherData : Observable
	{
		List<IObserver> observerList;
		public long temperature { get; set; }
		public long humidity { get; set; }
		public long pressure { get; set; }
		

		public void mesurmentChange() {
			setChange();
			notifyObserver();
		}

		public void setMesurment(long temperature, long humidity, long pressure) {
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;
			mesurmentChange();
		}
		
	}
}
