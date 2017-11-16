using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站
{
public class CurrentConditionDisply : IObserver, IDisplayElement
{
	public long temperature { get; set; }
	public long humidity { get; set; }
	public long pressure { get; set; }
	public ISubject subject { get; set; }

	public CurrentConditionDisply(ISubject subject) {
		this.subject = subject;
		subject.registerObserver(this);
	}

	public void disply()
	{
		Console.WriteLine("当前检测到temperature为："+ temperature);
		Console.WriteLine("当前检测到humidity为：" + humidity);
		Console.WriteLine("当前检测到pressure为：" + pressure);
	}

	public void update(long temperature, long humidity, long pressure)
	{
		this.temperature = temperature;
		this.humidity = humidity;
		this.pressure = pressure;
		disply();
	}
}
}
