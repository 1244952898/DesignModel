using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站
{
public class WeatherData : ISubject
{
	List<IObserver> observerList;
	public long temperature { get; set; }
	public long humidity { get; set; }
	public long pressure { get; set; }

	public WeatherData() {
		observerList = new List<IObserver>();
	}

	public void notifyObserver()
	{
		foreach (var o in observerList)
		{
			o.update(temperature, humidity, pressure);
		}
	}

	public void registerObserver(IObserver o)
	{
		observerList.Add(o);
	}

	public void removeObserver(IObserver o)
	{
		observerList.Remove(o);
	}

	public void mesurmentChange() {
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
