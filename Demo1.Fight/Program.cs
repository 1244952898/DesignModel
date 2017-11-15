using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Fight
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("创建一个Queen：");
			Character Queen = new Queen();
			Queen.fight();

			Console.WriteLine("创建一个King：");
			Character King = new King();
			King.fight();

			Console.WriteLine("创建一个Troll：");
			Character Troll = new Troll();
			Troll.fight();

			Console.WriteLine("创建一个Knight：");
			Character Knight = new Knight();
			Knight.fight();
			Console.WriteLine("Knight使用了新武器BowAndArrowBehavior：");
			Knight.setWeapon(new BowAndArrowBehavior());
			Knight.fight();
			Console.Read();
		}
	}
}
