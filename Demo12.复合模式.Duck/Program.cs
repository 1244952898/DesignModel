using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	class Program
	{
		static void Main(string[] args)
		{
			DuckSimulator simulartor = new DuckSimulator();
			AbstractDuckFactory fac = new CountingDuckFactory();
			simulartor.Simulate(fac);
			Console.ReadLine();
		}
	}
}
