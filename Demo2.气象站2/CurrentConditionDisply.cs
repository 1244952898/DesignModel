using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站2
{
	public class CurrentConditionDisply : IObserver, IDisplayElement
	{
		Observable observable;
		public long temperature { get; set; }
		public long humidity { get; set; }
		public long pressure { get; set; }

		public CurrentConditionDisply(Observable observable) {
			this.observable = observable;
			observable.registerObserver(this);
		}

		public void disply()
		{
			Console.WriteLine("当前检测到temperature为："+ temperature);
			Console.WriteLine("当前检测到humidity为：" + humidity);
			Console.WriteLine("当前检测到pressure为：" + pressure);
		}
		
		public void update(object obs, object arg)
		{
			if (obs is WeatherData)
			{
				WeatherData weatherData = (WeatherData)obs;
				this.temperature = weatherData.temperature;
				this.humidity = weatherData.humidity;
				this.pressure = weatherData.pressure;
				disply();
			}
		}
	}
}
