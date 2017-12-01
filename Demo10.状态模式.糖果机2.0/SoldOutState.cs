using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机2._0
{
	public class SoldOutState : IState
	{
		GumballMachine machine;
		public SoldOutState(GumballMachine _machine)
		{
			machine = _machine;
		}
		public void dispense()
		{
			Console.WriteLine("已经卖光");
		}

		public void ejectQuarter()
		{
			Console.WriteLine("无法退钱，无法接受钱");
			machine.SetState(machine.HasQuarterState);
		}

		public void insertQuarter()
		{
			Console.WriteLine("无法投钱，糖果已经卖光");
		}

		public void turnCrank()
		{
			Console.WriteLine("糖果已经卖光");
		}
	}
}
