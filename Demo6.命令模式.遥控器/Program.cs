using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6.命令模式.遥控器
{
	class Program
	{
		static void Main(string[] args)
		{
			SampleRemoteController controller = new SampleRemoteController();
			Light light = new Light();
			ICommand lightCommand = new LightOnCommand(light);
			controller.setCommmand(lightCommand);
			controller.ButtonWasPress();
	

			GarageDoor door = new GarageDoor();
			ICommand doorCommand = new GarageDoorCommand(door);
			controller.setCommmand(doorCommand);
			controller.ButtonWasPress();
			Console.Read();
		}
	}
}
