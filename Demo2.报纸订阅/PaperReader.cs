using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.报纸订阅
{
public class PaperReader1 : IObserver
{
	ISubject s;
	public PaperReader1(ISubject _s) {
		s = _s;
		s.RegisterEvent(this);
	}
	public void Send()
	{
		Console.WriteLine("用户《"+this.GetType().FullName + "》收到了订阅的报纸");
	}
}
public class PaperReader2 : IObserver
{
	ISubject s;
	public PaperReader2(ISubject _s)
	{
		s = _s;
		s.RegisterEvent(this);
	}
	public void Send()
	{
		Console.WriteLine("用户《" + this.GetType().FullName + "》收到了订阅的报纸");
	}
}
public class PaperReader3 : IObserver
{
	ISubject s;
	public PaperReader3(ISubject _s)
	{
		s = _s;
		s.RegisterEvent(this);
	}
	public void Send()
	{
		Console.WriteLine("用户《" + this.GetType().FullName + "》收到了订阅的报纸");
	}
}
public class PaperReader4 : IObserver
{
	ISubject s;
	public PaperReader4(ISubject _s)
	{
		s = _s;
		s.RegisterEvent(this);
	}
	public void Send()
	{
		Console.WriteLine("用户《" + this.GetType().FullName + "》收到了订阅的报纸");
	}
}
public class PaperReader5 : IObserver
{
	ISubject s;
	public PaperReader5(ISubject _s)
	{
		s = _s;
		s.RegisterEvent(this);
	}
	public void Send()
	{
		Console.WriteLine("用户《" + this.GetType().FullName + "》收到了订阅的报纸");
	}
}
}
