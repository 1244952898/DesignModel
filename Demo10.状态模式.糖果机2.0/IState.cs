using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.状态模式.糖果机2._0
{
	public interface IState
	{
		void insertQuarter();
		void ejectQuarter();
		void turnCrank();
		void dispense();
	}
}
