using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.装饰着.星巴克
{
	public abstract class Beverage
	{
		public string description="just beverage without any thing";

		public virtual string GetDescription() {
			return description;
		}

		public abstract double Cost();
	}
}
