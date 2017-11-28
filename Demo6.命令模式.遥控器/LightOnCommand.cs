using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6.命令模式.遥控器
{
	public class LightOnCommand : ICommand
	{
		private Light light;
		public LightOnCommand(Light _light) {
			this.light = _light;
		}
		public void Excute()
		{
			light.On();
		}
	}
}
