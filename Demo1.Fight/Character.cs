using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Fight
{
public class Character
{
	public IWeaponBehavior weaponBehavior;
	public void fight() {
		weaponBehavior.useWeapon();
	}

	public void setWeapon(IWeaponBehavior _weaponBehavior) {
		weaponBehavior = _weaponBehavior;
	}
}
}
