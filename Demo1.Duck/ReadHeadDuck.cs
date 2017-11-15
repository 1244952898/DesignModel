using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
public class ReadHeadDuck: Duck
{
	public ReadHeadDuck() {
		flyBehavior = new FlyWithWings();
		quackBehavior = new Quack();
	}

	public override void Display()
	{
		Console.WriteLine("Display-ReadHeadDuck");
	}

	public override void Swim()
	{
		Console.WriteLine("Swim-ReadHeadDuck");
	}
}
}
