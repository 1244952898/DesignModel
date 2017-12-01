using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机2._0
{
	public class HasQuarterState:IState
	{
		GumballMachine machine;
		Random rd = new Random();
		public HasQuarterState(GumballMachine _machine)
		{
			machine = _machine;
		}

		public void dispense()
		{
			Console.WriteLine("没有an出糖果手柄");
		}

		public void ejectQuarter()
		{
			Console.WriteLine("你还没有投钱");
		}

		public void insertQuarter()
		{
			Console.WriteLine("不能重复投钱");
		}

		public void turnCrank()
		{
			int winner = rd.Next(5);
			if (winner==0&&machine.count>1)
			{
				machine.SetState(machine.WinnerState);
			}
			else
			{
				machine.SetState(machine.SoldState);
			}
		}
	}
}
