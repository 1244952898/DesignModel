﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.装饰着.星巴克
{
public class Decaf : Beverage
{
	public Decaf()
	{
		description = "Decaf";
	}
	public override double Cost()
	{
		return 40;
	}
}
}
