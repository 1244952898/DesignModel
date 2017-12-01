using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机2._0
{
	public class NoQuarterState : IState
	{
		GumballMachine machine;
		public NoQuarterState(GumballMachine _machine) {
			machine = _machine;
		}
		public void dispense()
		{
			Console.WriteLine("你必须先投钱");
		}

		public void ejectQuarter()
		{
			Console.WriteLine("你还没有投钱");
		}

		public void insertQuarter()
		{
			Console.WriteLine("你已投钱");
			machine.SetState(machine.HasQuarterState);
		}

		public void turnCrank()
		{
			Console.WriteLine("你还没有投钱");
		}
	}
}
