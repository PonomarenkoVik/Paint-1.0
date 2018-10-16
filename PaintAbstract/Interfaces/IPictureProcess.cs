using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintAbstract.Interfaces
{
    public interface IPictureProcess
    {

        event Action<int> ProgressUpdateEvent;
        event Action ProcessDone;
        event Action ProcessStart;
        void Invert();
        
    }
}
