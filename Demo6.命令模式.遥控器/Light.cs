using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6.命令模式.遥控器
{
	public class Light
	{
		public void On() {
			Console.WriteLine("开灯");
		}

		public void Off() {
			Console.WriteLine("关灯");
		}
	}
}
