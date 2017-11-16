using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站2
{
	public class Observable : ISubject
	{
		List<IObserver> observerList;
		bool change;
		public Observable()
		{
			observerList = new List<IObserver>();
		}

		public void notifyObserver(object arg)
		{
			if (change)
			{
				foreach (var o in observerList)
				{
					o.update(this,arg);
				}
				change = false;
			}
		}

		public void notifyObserver()
		{
			notifyObserver(null);
		}

		public void registerObserver(IObserver o)
		{
			observerList.Add(o);
		}

		public void removeObserver(IObserver o)
		{
			observerList.Remove(o);
		}

		public void setChange() {
			change = true;
		}
	}
}
