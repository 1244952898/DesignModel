using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	public abstract class AbstractDuckFactory
	{
		public abstract IQuackable createMallardDuck();
		public abstract IQuackable createReadHeadDuck();
		public abstract IQuackable createDuckCall();
		public abstract IQuackable createRubberCall();
	}
}
