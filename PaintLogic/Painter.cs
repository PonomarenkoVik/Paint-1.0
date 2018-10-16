using System;
using System.Collections.Generic;
using PaintAbstract.Interfaces;
using System.Drawing;
using PaintAbstract.Enums;

namespace PaintLogic
{
    public class Painter : IHistory, IPaintDraw, IPictureProcess
    {
        public Painter(int width = 1024, int height = 768)
        {
            _currIndex = -1;
            HistorySteps = 50;
            _images = new List<Bitmap>();
            Add(new Bitmap(width, height));
            Width = width;
            Height = height;
            _converter = new ImageConverter();
            _converter.ProgressUpdateEvent += ConverterOnProgressUpdateEvent;   
        }

        public event Action<int> ProgressUpdateEvent;
        public event Action ProcessDone;
        public event Action ProcessStart;

        public int HistorySteps
        {
            get { return _historySteps; }
            set
            {
                if (value < 5)
                {
                    _historySteps = 5;
                }
                else if (value > 200)
                {
                    _historySteps = 200;
                }
                else
                {
                    _historySteps = value;
                }
            }
        }


        public int Width { get; private set; }
        public int Height { get; private set; }

        #region History
        public int Count
        {
            get { return _images.Count; }
        }

        public void Add(Bitmap btmp)
        {
            if (_currIndex < HistorySteps && _currIndex == _images.Count - 1)
            {
                _images.Add((Bitmap)btmp.Clone());
                _currIndex++;
            }
            else if (_currIndex < HistorySteps && _currIndex < _images.Count - 1)
            {
                ReplaceHistory(btmp);
            }
            else
            {
                ShiftHistory(btmp);
            }
        }

        private void ShiftHistory(Bitmap btmp)
        {
            for (int i = 0; i < _images.Count - 1; i++)
            {
                _images[i] = _images[i + 1];
            }

            _images[_images.Count - 1] = (Bitmap) btmp.Clone();
        }

        private void ReplaceHistory(Bitmap btmp)
        {
            List<Bitmap> imgs = new List<Bitmap>();
            for (int i = 0; i <= _currIndex; i++)
            {
                imgs.Add(_images[i]);
            }

            _images = imgs;
            _images.Add((Bitmap) btmp.Clone());
            _currIndex++;
        }

        public bool CanUndo
        {
            get { return _currIndex > 0; }
        }

        public bool CanRedo
        {
            get { return _images.Count > 0 && _currIndex < _images.Count - 1; }
        }

        public void Undo()
        {
            if (CanUndo)
            {
                _currIndex--;
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                _currIndex++;
            }
        }

        public void ClearHistory()
        {
            Bitmap btn = _images[_currIndex];
            _images = new List<Bitmap>
            {
                btn
            };
            _currIndex = 0;
        }
        #endregion



        public Bitmap CurrentImage
        {
            get
            {
                if (_tempImage != null)
                {
                    return (Bitmap)_tempImage.Clone();
                }
                return (Bitmap)_images[_currIndex].Clone();
            }
            set { new NotImplementedException(); }
        }

        public void Clear()
        {
            _images = new List<Bitmap>()
            {
                new Bitmap(Width, Height)
            };
            _currIndex = 0;
        }

        public void DrawFigure(Pen pen, Point srt, Point fnsh, DrawItem item, Color bColor)
        {
            if (_tempImage == null || (item != DrawItem.Eraser && item != DrawItem.Point))
            {
                _tempImage = (Bitmap) _images[_currIndex].Clone();
            }
            switch (item)
            {
                case DrawItem.Point:
                case DrawItem.Line:
                case DrawItem.Eraser:
                    DrawLine(pen, srt, fnsh, _tempImage);
                    break;
                case DrawItem.Rectangle:
                    DrawRectangle(pen, srt, fnsh, bColor, _tempImage);
                    break;
                case DrawItem.Circle:
                    DrawCircle(pen, srt, fnsh, bColor, _tempImage);
                    break;
                case DrawItem.Ellipse:
                    DrawElliipse(pen, srt, fnsh, bColor, _tempImage);
                    break;
            }
        }

        public void SaveImage()
        {
            Add(_tempImage);
            _tempImage = null;
        }

        #region Drawing
        private static void DrawElliipse(Pen pen, Point srt, Point fnsh, Color bColor, Bitmap btm)
        {
            using (Graphics gr = Graphics.FromImage(btm))
            {
                gr.DrawEllipse(pen, srt.X, srt.Y, fnsh.X - srt.X, fnsh.Y - srt.Y);
                if (bColor != Color.Empty)
                {
                    gr.FillEllipse(new SolidBrush(bColor), srt.X + pen.Width / 2, srt.Y + pen.Width / 2,
                        fnsh.X - srt.X - pen.Width, fnsh.Y - srt.Y - pen.Width);
                }
            }
        }

        private static void DrawCircle(Pen pen, Point srt, Point fnsh, Color bColor, Bitmap btm)
        {
            using (Graphics gr = Graphics.FromImage(btm))
            {
                gr.DrawEllipse(pen, srt.X, srt.Y, fnsh.X - srt.X, fnsh.X - srt.X);
                if (bColor != Color.Empty)
                {
                    gr.FillEllipse(new SolidBrush(bColor), srt.X + pen.Width / 2, srt.Y + pen.Width / 2,
                        fnsh.X - srt.X - pen.Width, fnsh.X - srt.X - pen.Width);
                }
            }
        }

        private static void DrawRectangle(Pen pen, Point srt, Point fnsh, Color bColor, Bitmap btm)
        {
            using (Graphics gr = Graphics.FromImage(btm))
            {
                gr.DrawRectangle(pen, srt.X, srt.Y, fnsh.X - srt.X, fnsh.Y - srt.Y);
                if (bColor != Color.Empty)
                {
                    gr.FillRectangle(new SolidBrush(bColor), srt.X + pen.Width / 2, srt.Y + pen.Width / 2,
                        fnsh.X - srt.X - pen.Width, fnsh.Y - srt.Y - pen.Width);
                }
            }
        }

        private static void DrawLine(Pen pen, Point srt, Point fnsh, Bitmap btm)
        {
            using (Graphics gr = Graphics.FromImage(btm))
            {
                gr.DrawLine(pen, srt, fnsh);
            }
        }
        

        #endregion

        public void Invert()
        {
            if (ProcessStart != null)
            {
                ProcessStart();
            }
            Bitmap bmp = _converter.Invert(CurrentImage);
            Add(bmp);
            if (ProcessDone != null)
            {
                ProcessDone();
            }
        }
        private void ConverterOnProgressUpdateEvent(int p)
        {
            if (ProgressUpdateEvent != null)
            {
                ProgressUpdateEvent(p);
            }
        }

        private int _currIndex;
        private List<Bitmap> _images;
        private readonly ImageConverter _converter;
        private int _historySteps;
        private Bitmap _tempImage;
        
    }
}
