using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6.命令模式.遥控器
{
	public class GarageDoor
	{
		public void Up()
		{
			Console.WriteLine("打开闸门！");
		}
		public void Down()
		{
			Console.WriteLine("关闭闸门！");
		}
		public void Sop()
		{
			Console.WriteLine("停止闸门！");
		}
		public void LightOn()
		{
			Console.WriteLine("打开门灯！");
		}
		public void LightOff()
		{
			Console.WriteLine("关闭门灯！");
		}
	}
}
