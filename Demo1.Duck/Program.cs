using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("生产一个MallHardDuck：");
		Duck mallHardDuck = new MallHardDuck();
		mallHardDuck.Display();
		mallHardDuck.Swim();
		mallHardDuck.perFormFly();
		mallHardDuck.perFormQuack();

		Console.WriteLine("生产一个ReadHeadDuck：");
		Duck readHeadDuck = new ReadHeadDuck();
		readHeadDuck.Display();
		readHeadDuck.Swim();
		readHeadDuck.perFormFly();
		readHeadDuck.perFormQuack();

		Console.WriteLine("生产一个RubberDuck：");
		Duck rubberdDuck = new RubberDuck();
		rubberdDuck.Display();
		rubberdDuck.Swim();
		rubberdDuck.perFormFly();
		rubberdDuck.perFormQuack();
		Console.WriteLine("为RubberDuck加一个飞行器：");
		rubberdDuck.setFlyBehavior(new RockFly());
		rubberdDuck.perFormFly();
		Console.WriteLine("让RubberDuck正常发声：");
		rubberdDuck.setQuackBehavior(new Quack());
		Console.Read();
	}
}
}
