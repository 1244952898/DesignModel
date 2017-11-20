using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.装饰着.星巴克
{
	public abstract class CondimentDecorator:Beverage
	{
		//public List<String> Decoratorlist { get; set; }
		public override string GetDescription() {
			return "";
		}
	}
}
