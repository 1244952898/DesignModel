using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
public class RubberDuck : Duck
{
	public RubberDuck() {
		flyBehavior = new FlyNoWay();
		quackBehavior = new NoQuack();
	}

	public override void Display()
	{
		Console.WriteLine("Display-RubberDuck");
	}

	public override void Swim()
	{
		Console.WriteLine("Swim-RubberDuck");
	}
}
}
