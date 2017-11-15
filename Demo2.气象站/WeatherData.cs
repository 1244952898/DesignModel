using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站
{
	public class WeatherData : ISubject
	{
		List<> array;
		public long tenperature { get; set; }
		public long humidity { get; set; }
		public long pressure { get; set; }

		public WeatherData() {
			array=new Array
		}

		public void notifyObserver(IObserver o)
		{
			throw new NotImplementedException();
		}

		public void registerObserver(IObserver o)
		{
			throw new NotImplementedException();
		}

		public void removeObserver(IObserver o)
		{
			throw new NotImplementedException();
		}
	}
}
