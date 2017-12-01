using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机
{
	public class GumballMachine
	{
		public static int SOLD_OUT = 0;
		public static int NO_QUARTER = 1;
		public static int HAS_QUARTER = 2;
		public static int SOLD = 3;

		int state = SOLD_OUT;
		int count = 0;

		public GumballMachine(int count) {
			this.count = count;
			state = NO_QUARTER;
		}

		public override string ToString() {
			return "糖果机器状态：" + (state==0? "SOLD_OUT" : state == 1? "NO_QUARTER": state == 2 ? "HAS_QUARTER" : "SOLD") + " 剩余糖果数量：" + count;
		}

		public void insertQuarter() {
			if (state== HAS_QUARTER)
			{
				Console.WriteLine("不能重复投钱");
			}
			else if (state == NO_QUARTER)
			{
				state = HAS_QUARTER;
				Console.WriteLine("你已投钱");
			
			}
			else if (state == SOLD_OUT)
			{
				Console.WriteLine("无法投钱，糖果已经卖光");
			}
			else if (state == SOLD)
			{
				Console.WriteLine("请稍等，准备糖果中");
			}
		}

		public void ejectQuarter() {
			if (state == HAS_QUARTER)
			{
				Console.WriteLine("返回投钱");
				state = NO_QUARTER;
			}
			else if (state == NO_QUARTER)
			{
				Console.WriteLine("你还没有投钱");
			}
			else if (state == SOLD_OUT)
			{
				Console.WriteLine("无法退钱，无法接受钱");
				state = HAS_QUARTER;
			}
			else if (state == SOLD)
			{
				Console.WriteLine("糖果已卖出");
			}
		}

		public void turnCrank() {
			if (state == SOLD)
			{
				Console.WriteLine("转动两次无法获得两个糖果");
			}
			else if (state == NO_QUARTER)
			{
				Console.WriteLine("你还没有投钱");
			}
			else if (state == SOLD_OUT)
			{
				Console.WriteLine("糖果已经卖光");
			}
			else if (state == HAS_QUARTER)
			{
				Console.WriteLine("糖果正准备。。。");
				state = SOLD;
				dispense();
			}
		}

		private void dispense()
		{
			if (state == SOLD)
			{
				Console.WriteLine("正在售出糖果");
				count = count - 1;
				if (count == 0)
				{
					Console.WriteLine("糖果已经卖光");
					state = SOLD_OUT;
				}
				else
				{
					state = NO_QUARTER;
				}
			}
			else if (state == NO_QUARTER)
			{
				Console.WriteLine("你必须先投钱");
			}
			else if (state == SOLD_OUT)
			{
				Console.WriteLine("已经卖光");
			}
			else if (state == HAS_QUARTER)
			{
				Console.WriteLine("没有an出糖果手柄");
			}
		}
	}
}
