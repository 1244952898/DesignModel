using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.报纸订阅
{
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("开始建立一个报纸工厂...");
		NewPaperData paper = new NewPaperData();
		Console.WriteLine("PaperReader1订阅了报纸...");
		IObserver p1 = new PaperReader1(paper);
		Console.WriteLine("PaperReader2订阅了报纸...");
		IObserver p2 = new PaperReader2(paper);
		Console.WriteLine("PaperReader3订阅了报纸...");
		IObserver p3 = new PaperReader3(paper);
		Console.WriteLine("PaperReader4订阅了报纸...");
		IObserver p4 = new PaperReader4(paper);
		Console.WriteLine("PaperReader5订阅了报纸...");
		IObserver p5 = new PaperReader5(paper);
		Console.WriteLine("报纸工厂发送一份报纸...");
		paper.SendNewPaper();
		Console.ReadKey();
	}
}
}
