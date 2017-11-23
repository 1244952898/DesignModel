using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.装饰着.星巴克
{
public class Mocha : CondimentDecorator
{
	public Beverage beverage;
	public Mocha(Beverage _beverage)
	{
		beverage = _beverage;
	}
		
	public override double Cost()
	{
		return beverage.Cost() + 0.01;
	}

	public override string GetDescription()
	{
		return beverage.GetDescription() + ",Mocha";
	}
}
}
