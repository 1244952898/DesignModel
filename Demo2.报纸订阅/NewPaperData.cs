using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.报纸订阅
{
public class NewPaperData : ISubject
{
	public List<IObserver> obList;

	public NewPaperData() {
		obList = new List<IObserver>();
	}

	public void NoticeEvent()
	{
		if (obList!=null)
		{
			foreach (var o in obList)
			{
				o.Send();
			}
		}
	}

	public void RegisterEvent(IObserver o)
	{
		obList.Add(o);
	}

	public void RemoveEvent(IObserver o)
	{
		obList.Remove(o);
	}

	public void SendNewPaper() {
		NoticeEvent();
	}
}
}
