﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
	public class NoQuack : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("duck no quack");
		}
	}
}
