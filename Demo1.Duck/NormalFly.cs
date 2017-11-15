using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
public class FlyWithWings : IFlyBehavior
{
	public void fly()
	{
		Console.WriteLine("duck normal fly");
	}
}
}
