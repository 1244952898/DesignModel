using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.气象站2
{
	public interface IObserver
	{
		void update(object obs,object arg);
	}
}
