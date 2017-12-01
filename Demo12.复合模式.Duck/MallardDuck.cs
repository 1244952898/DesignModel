using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	public class MallardDuck : IQuackable
	{
		public void quack()
		{
			Console.WriteLine("Quack");
		}
	}

	public class ReadHeadDuck : IQuackable {
		public void quack()
		{
			Console.WriteLine("Quack");
		}
	}

	public class DuckCall : IQuackable
	{
		public void quack()
		{
			Console.WriteLine("Kwak");
		}
	}

	public class RubberCall : IQuackable
	{
		public void quack()
		{
			Console.WriteLine("Quack");
		}
	}
}
