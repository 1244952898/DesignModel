using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Duck
{
	public abstract class Duck
	{
		public IFlyBehavior flyBehavior;
		public IQuackBehavior quackBehavior;

		public abstract void Display();
		public abstract void Swim();

		public void perFormFly() {
			flyBehavior.fly();
		}

		public void perFormQuack() {
			quackBehavior.quack();
		}

		public void setFlyBehavior(IFlyBehavior iflyable) {
			flyBehavior = iflyable;
		}

		public void setQuackBehavior(IQuackBehavior iquackable) {
			quackBehavior = iquackable;
		}
	}
}
