using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Fight
{
public class KnifeBehavior : IWeaponBehavior
{
	public void useWeapon()
	{
		Console.WriteLine("use Weapon Knife ");
	}
}
}
