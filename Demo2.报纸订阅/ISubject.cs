using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.报纸订阅
{
public interface ISubject
{
	void RegisterEvent(IObserver o);
	void RemoveEvent(IObserver o);
	void NoticeEvent();
}
}
