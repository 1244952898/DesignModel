using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
public class MallHardDuck : Duck
{
	public MallHardDuck()
	{
		flyBehavior = new FlyWithWings();
		quackBehavior = new Quack();
	}
	public override void Display()
	{
		Console.WriteLine("Display-MallHardDuck");
	}

	public override void Swim()
	{
		Console.WriteLine("Swim-MallHardDuck");
	}
}
}
