using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace PaintAbstract.Interfaces
{
    public interface IHistory
    {
        int HistorySteps { get; }
        int Count { get; }
        void Add(Bitmap btmp);
        bool CanUndo { get; }
        bool CanRedo { get; }
        void Undo();
        void Redo();
        void ClearHistory();
    }
}
