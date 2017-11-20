using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.装饰着.星巴克
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("顾客：来一杯Houseblend，什么也不加！");
			Beverage b = new HouseBlend();
			Console.WriteLine("这是您点的{0}，一共消费：{1}元", b.GetDescription(), b.Cost());

			Console.WriteLine("顾客：DarkRoast，加Mike和Mocha！");
			Beverage b1 = new DarkRoast();
			b1 = new Mike(b1);
			b1 = new Mocha(b1);
			Console.WriteLine("这是您点的{0}，一共消费：{1}元", b1.GetDescription(), b1.Cost());

			Console.WriteLine("顾客：Espresso，加双份Soy！");
			Beverage b2 = new DarkRoast();
			b2 = new Soy(b2);
			b2 = new Soy(b2);
			Console.WriteLine("这是您点的{0}，一共消费：{1}元", b2.GetDescription(), b2.Cost());

			Console.WriteLine("顾客：来一杯Decaf，加soy,whip,Mike,Mocha！");
			Beverage b3 = new HouseBlend();
			b3 = new Soy(b3);
			b3 = new Whip(b3);
			b3 = new Mike(b3);
			b3 = new Mocha(b3);
			Console.WriteLine("这是您点的{0}，一共消费：{1}元", b3.GetDescription(), b3.Cost());
			Console.ReadKey();
		}
	}
}
