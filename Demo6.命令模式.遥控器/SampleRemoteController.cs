using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6.命令模式.遥控器
{
	public class SampleRemoteController
	{
		ICommand slot;

		public SampleRemoteController() { }

		public void setCommmand(ICommand _command) {
			slot = _command;
		}

		public void ButtonWasPress() {
			slot.Excute();
		}
	}
}
