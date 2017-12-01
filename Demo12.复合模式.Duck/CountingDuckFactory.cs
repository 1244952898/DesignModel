using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	public class CountingDuckFactory : AbstractDuckFactory
	{
		public override IQuackable createDuckCall()
		{
			return new QackerCounter(new DuckCall());
		}

		public override IQuackable createMallardDuck()
		{
			return new QackerCounter(new MallardDuck());
		}

		public override IQuackable createReadHeadDuck()
		{
			return new QackerCounter(new ReadHeadDuck());
		}

		public override IQuackable createRubberCall()
		{
			return new QackerCounter(new RubberCall());
		}
	}
}
