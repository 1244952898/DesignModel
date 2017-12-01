using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机2._0
{
	public class WinnerState : IState
	{
		GumballMachine machine;
		public WinnerState(GumballMachine _machine)
		{
			machine = _machine;
		}
		public void dispense()
		{
			Console.WriteLine("赢家获得两个糖果！");
			machine.releaseBall();
			if (machine.count==0)
			{
				machine.SetState(machine.SoldOutState);
			}
			else
			{
				machine.releaseBall();
				if (machine.count > 0)
				{
					machine.SetState(machine.NoQuarterState);
				}
				else
				{
					Console.WriteLine("糖果已经卖光");
					machine.SetState(machine.SoldOutState);
				}
			}
		}

		public void ejectQuarter()
		{
			Console.WriteLine("发生错误！");
		}

		public void insertQuarter()
		{
			Console.WriteLine("发生错误！");
		}

		public void turnCrank()
		{
			Console.WriteLine("发生错误！");
		}
	}
}
