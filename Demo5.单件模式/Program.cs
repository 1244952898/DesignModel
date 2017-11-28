using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.单件模式
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass1 m = MyClass1.GetInstance();
			Console.Read();
		}
	}
}
