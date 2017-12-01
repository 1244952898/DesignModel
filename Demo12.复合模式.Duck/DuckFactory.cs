using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	public class DuckFactory : AbstractDuckFactory
	{
		public override IQuackable createDuckCall()
		{
			return new DuckCall();
		}

		public override IQuackable createMallardDuck()
		{
			return new MallardDuck();
		}

		public override IQuackable createReadHeadDuck()
		{
			return new ReadHeadDuck();
		}

		public override IQuackable createRubberCall()
		{
			return new RubberCall();
		}
	}
}
