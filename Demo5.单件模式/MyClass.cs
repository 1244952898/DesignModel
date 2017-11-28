using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.单件模式
{
	public class MyClass
	{
		private static MyClass myclass;
		private MyClass() {
		}

		public static MyClass GetInstance() {
			if (myclass==null)
			{
				myclass = new MyClass();
			}
			return myclass;
		}
	}

	public class MyClass1 {
		private static MyClass1 myclass1;
		private MyClass1(){
		}
		private static object locker=new object();

		public static MyClass1 GetInstance()
		{
			lock (locker)
			{
				if (myclass1 == null)
				{
					myclass1 = new MyClass1();
				}
			
			}
				return myclass1;
		}
	}

	public class MyClass2
	{
		private static MyClass2 myclass2;
		private MyClass2()
		{
		}
		private static object locker = new object();

		public static MyClass2 GetInstance()
		{
			if (myclass2 == null)
			{
				lock (locker)
				{
					if (myclass2 == null)
					{
						myclass2 = new MyClass2();
					}

				}
			}
			
			return myclass2;
		}
	}
}
