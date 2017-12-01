using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机
{
	class Program
	{
		static void Main(string[] args)
		{
			GumballMachine machine = new GumballMachine(5);
			Console.WriteLine(machine);
			machine.insertQuarter();
			machine.turnCrank();

			Console.WriteLine(machine);
			machine.insertQuarter();
			machine.ejectQuarter();
			machine.turnCrank();

			Console.WriteLine(machine);
			machine.insertQuarter();
			machine.turnCrank();
			machine.insertQuarter();
			machine.turnCrank();
			machine.ejectQuarter();

			Console.WriteLine(machine);
			machine.insertQuarter();
			machine.insertQuarter();
			machine.turnCrank();
			machine.insertQuarter();
			machine.turnCrank();
			machine.insertQuarter();
			machine.turnCrank();

			Console.WriteLine(machine);
			Console.Read();
		}
	}
}
