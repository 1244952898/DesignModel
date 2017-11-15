using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站
{
	public interface ISubject
	{
		void registerObserver(IObserver o);
		void removeObserver(IObserver o);
		void notifyObserver();
	}
}
