using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	public class GooseAdapter : IQuackable
	{
		Goose goose;

		public GooseAdapter(Goose g) {
			goose = g;
		}

		public void quack()
		{
			goose.hook();
		}
	}
}
