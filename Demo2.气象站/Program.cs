using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("建立一个温度测试站。。。");
			WeatherData weatherData = new WeatherData();
			CurrentConditionDisply currentConditionDisply = new CurrentConditionDisply(weatherData);
			Console.WriteLine("温度变化为：23，23,23。。。");
			weatherData.setMesurment(23,23,23);
			Console.WriteLine("温度变化为：33，33,33。。。");
			weatherData.setMesurment(33, 33, 33);
			Console.WriteLine("温度变化为：44，44,44。。。");
			weatherData.setMesurment(44, 44, 44);
			Console.Read();
		}
	}
}
