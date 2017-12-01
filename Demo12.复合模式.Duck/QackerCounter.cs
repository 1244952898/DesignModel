using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	public class QackerCounter : IQuackable
	{
		IQuackable duck;
		static int numberOfQuack;

		public QackerCounter(IQuackable _duck) {
			duck = _duck;
		}

		public void quack()
		{
			duck.quack();
			numberOfQuack++;
		}

		public static int Cont() {
			return numberOfQuack;
		}
	}
}
