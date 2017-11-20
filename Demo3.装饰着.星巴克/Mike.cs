using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.装饰着.星巴克
{
	public class Mike : CondimentDecorator
	{
		public Beverage beverage;
		public Mike(Beverage _beverage) {
			beverage = _beverage;
		}

		//public string GetDescription() {
		//	return beverage.GetDescription() + ",Mike";
		//}

		public override double Cost()
		{
			return beverage.Cost()+0.1;
		}

		public override string GetDescription()
		{
			return beverage.GetDescription() + ",Mike";
		}
	}
}
