using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.装饰着.星巴克
{
	public class Soy : CondimentDecorator
	{
		public Beverage beverage;
		public Soy(Beverage _beverage)
		{
			beverage = _beverage;
		}
		

		public override double Cost()
		{
			return beverage.Cost() + 0.001;
		}

		public override string GetDescription()
		{
			return beverage.GetDescription() + ",Soy";
		}
	}
}
