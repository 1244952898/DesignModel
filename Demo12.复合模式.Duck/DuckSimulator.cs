using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.复合模式.Duck
{
	public class DuckSimulator
	{
		public void Simulate(AbstractDuckFactory fac) {
			IQuackable mallardDuck = fac.createMallardDuck();
			IQuackable readHeadDuck = fac.createReadHeadDuck();
			IQuackable duckCall = fac.createDuckCall();
			IQuackable rubberCall = fac.createRubberCall();
			IQuackable goose = new GooseAdapter(new Goose());
			Console.WriteLine("\n ducl simulator");
			Simulate(mallardDuck);
			Simulate(readHeadDuck);
			Simulate(duckCall);
			Simulate(rubberCall);
			Simulate(goose);
			Console.WriteLine("\n ducl quacker count:"+ QackerCounter.Cont());
			
		}

		public void Simulate(IQuackable duck) {
			duck.quack();
		}
	}
}
