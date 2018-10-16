using System;
using System.Drawing;


namespace PaintLogic
{
    internal class ImageConverter
    {      

            public event Action<int> ProgressUpdateEvent;
            public Bitmap Invert(Bitmap btm)
            {
                for (int x = 0; x < btm.Width; x++)
                {
                    for (int y = 0; y < btm.Height; y++)
                    {
                        Color oldColor = btm.GetPixel(x, y);
                        var newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                        btm.SetPixel(x, y, newColor);
                    }
                    if (ProgressUpdateEvent != null)
                    {
                        int progress = ((x + 1) * 100) / btm.Width;
                        ProgressUpdateEvent(progress);
                    }
                }
                return btm;
            }        
    }
}
