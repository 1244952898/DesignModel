using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6.命令模式.遥控器
{
	public class GarageDoorCommand : ICommand
	{
		private GarageDoor door;
		public  GarageDoorCommand(GarageDoor _door)
		{
			door = _door;
		}

		public void Excute()
		{
			door.Up();
		}
	}
}
