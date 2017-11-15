using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
	public class RockFly : IFlyBehavior
	{
		public void fly()
		{
			Console.WriteLine("dock flly by rock");
		}
	}
}
