using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PaintAbstract.Enums;
using System.Drawing.Drawing2D;

namespace PaintAbstract.Interfaces
{
    public interface IPaintDraw
    {       
        int Width { get; }
        int Height { get; }
        Bitmap CurrentImage { get; set; }
        void DrawFigure(Pen pen, Point srt, Point fnsh, DrawItem item, Color bColor);
        void SaveImage();
        void Clear();
    }
}
