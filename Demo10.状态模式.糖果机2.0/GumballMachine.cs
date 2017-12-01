using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机2._0
{
	public class GumballMachine
	{
		public IState NoQuarterState;
		public IState SoldOutState;
		public IState HasQuarterState;
		public IState SoldState;
		public IState WinnerState;
		IState state;
		public int count = 0;
		public GumballMachine(int _count) {
			NoQuarterState = new NoQuarterState(this);
			SoldOutState = new SoldOutState(this);
			HasQuarterState = new HasQuarterState(this);
			SoldState = new SoldState(this);
			WinnerState = new WinnerState(this);

			count = _count;
			if (count>0)
			{
				state = NoQuarterState;
			}
			else
			{
				state = SoldOutState;
			}
		}

		public override string ToString()
		{
			return "糖果机器状态：" + state.GetType().Name + " 剩余糖果数量：" + count;
		}

		public void insertQuarter()
		{
			state.insertQuarter();
		}

		public void ejectQuarter()
		{
			state.insertQuarter();
		}

		public void turnCrank()
		{
			state.turnCrank();
			state.dispense();
		}

		public void SetState(IState _state) {
			state = _state;
		}
		public void releaseBall() {
			Console.WriteLine("释放一个。。");
			if (count!=0)
			{
				count = count - 1;
			}
		}
	}
}
