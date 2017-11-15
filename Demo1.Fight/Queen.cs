using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Fight
{
public class Queen : Character
{
	public Queen() {
		weaponBehavior = new KnifeBehavior();
	}
}
public class King : Character
{
	public King()
	{
		weaponBehavior = new BowAndArrowBehavior();
	}
}
public class Troll : Character
{
	public Troll()
	{
		weaponBehavior = new AxeBehavior();
	}
}
public class Knight : Character
{
	public Knight()
	{
		weaponBehavior = new SwordBehavior();
	}
}
}
