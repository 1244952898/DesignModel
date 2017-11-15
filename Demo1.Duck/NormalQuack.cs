using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
public class Quack : IQuackBehavior
{
	public void quack()
	{
		Console.WriteLine("duck normal quack gaga");
	}
}
}
