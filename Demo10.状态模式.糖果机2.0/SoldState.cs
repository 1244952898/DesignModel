using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机2._0
{
	public class SoldState : IState
	{
		GumballMachine machine;
		public SoldState(GumballMachine _machine)
		{
			machine = _machine;
		}

		public void dispense()
		{
			machine.releaseBall();
			if (machine.count>0)
			{
				machine.SetState(machine.NoQuarterState);
			}
			else
			{
				Console.WriteLine("糖果已经卖光");
				machine.SetState(machine.SoldOutState);
			}
		}

		public void ejectQuarter()
		{
			Console.WriteLine("糖果已卖出");
		}

		public void insertQuarter()
		{
			Console.WriteLine("请稍等，准备糖果中");
		}

		public void turnCrank()
		{
			Console.WriteLine("转动两次无法获得两个糖果");
		}
	}
}
