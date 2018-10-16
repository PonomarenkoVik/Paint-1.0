using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using PaintAbstract.Enums;
using PaintAbstract.Interfaces;
using PaintLogic;

namespace MyPaint
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
            MyInitialize();   
        }

        private readonly Color _buttonChosenBackColor = Color.DarkGray;
        private readonly Color _buttonInitialBackColor = Color.White;
        private readonly Color _imBackColor = Color.Beige;
        private const int MinPenSize = 1;
        private const int MaxPenSize = 40;

        private void MyInitialize()
        {
            _painter = new Painter();
            _foregColor = Color.Green;
            _figBackColor = Color.Blue;
            SetControlsColor(_foregColor);
            BackColorPictureBox.BackColor = _figBackColor;
            _draw = false;
            PencilButton.BackColor = _buttonChosenBackColor;
            MainPictureBox.BackColor = _imBackColor;
            ComboboxInitialize();
            SetStatusUndoRedoButton();
            _pen = new Pen(new SolidBrush(_foregColor), 5);
            _pen.StartCap = _pen.EndCap = LineCap.Round;
            PenComboBox.SelectedItem = (int)_pen.Width;
            PenTypeComboBox.SelectedItem = _pen.StartCap.ToString();
            IPictureProcess paint = _painter as IPictureProcess;
            if (paint != null)
            {
                paint.ProgressUpdateEvent += PainterOnProcUpdateEvent;
                paint.ProcessDone += PainterOnProcessDone;
                paint.ProcessStart += PaintOnProcessStart;
            }
        }


        private void ComboboxInitialize()
        {
            for (int i = MinPenSize; i <= MaxPenSize; i++)
            {
                PenComboBox.Items.Add(i);
            }

            string[] penTypes = Enum.GetNames(typeof(LineCap));
            foreach (var penType in penTypes)
            {
                PenTypeComboBox.Items.Add(penType);
            }
        }


        #region Color choosing handlers

        private void ColorCirclePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bmp = (Bitmap)ColorCirclePictureBox.Image.Clone();
            Color color = bmp.GetPixel(e.X, e.Y);
            SetControlsColor(color);
        }

        private void ColorCirclePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = (Bitmap)ColorCirclePictureBox.Image.Clone();
           
            if (_currItem != DrawItem.Eraser)
            {
                _pen.Color = _foregColor;
            }
            _foregColor = bmp.GetPixel(e.X, e.Y);         
            SetControlsColor(_foregColor);
            _pen.Color = _foregColor;
        }

        private void ColorCirclePictureBox_MouseLeave(object sender, EventArgs e)
        {
            SetControlsColor(_foregColor);
        }


        private void TrackBars_Scroll(object sender, EventArgs e)
        {
            SetColorFromTracks();
            SetControlsColor(_foregColor);
            _pen.Color = _foregColor;
        }


        private void BackColorPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            _figBackColor = _foregColor;
            BackColorPictureBox.BackColor = _figBackColor;
        }

        #endregion

        #region DrawItemButtons handlers

        private void PencilButton_Click(object sender, EventArgs e)
        {
            _currItem = DrawItem.Point;
            SetInitialButtonColor();
            _pen.Color = _foregColor;
            PencilButton.BackColor = _buttonChosenBackColor;
        }

        private void StickStripButton_Click(object sender, EventArgs e)
        {
            _currItem = DrawItem.Line;
            SetInitialButtonColor();
            _pen.Color = _foregColor;
            LineToolStripButton.BackColor = _buttonChosenBackColor;
        }

        private void SquareToolStripButton_Click(object sender, EventArgs e)
        {
            _currItem = DrawItem.Rectangle;
            SetInitialButtonColor();
            _pen.Color = _foregColor;
            SquareToolStripButton.BackColor = _buttonChosenBackColor;
        }

        private void CircleToolStripButton_Click(object sender, EventArgs e)
        {
            _currItem = DrawItem.Circle;
            SetInitialButtonColor();
            _pen.Color = _foregColor;
            CircleToolStripButton.BackColor = _buttonChosenBackColor;
        }

        private void EllipseToolStripButton_Click(object sender, EventArgs e)
        {
            _currItem = DrawItem.Ellipse;
            SetInitialButtonColor();
            _pen.Color = _foregColor;
            EllipseToolStripButton.BackColor = _buttonChosenBackColor;
        }

        private void EraserToolStripButton_Click(object sender, EventArgs e)
        {
            _currItem = DrawItem.Eraser;
            _pen.Color = _imBackColor;
            SetInitialButtonColor();
            EraserToolStripButton.BackColor = _buttonChosenBackColor;
        }

        #endregion

        #region MainToolsStrip handlers


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "bmp";
            sfd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Save(sfd);
            }
        }

        private void Save(SaveFileDialog sfd)
        {
            try
            {
                _painter.CurrentImage.Save(sfd.FileName, ImageFormat.Bmp);
            }
            catch (ArgumentNullException exception)
            {
                MessageBox.Show(
                    "Filename or format is null",
                    "Error");
                MessageBox.Show(exception.ToString());
            }
            catch (ExternalException exception)
            {
                MessageBox.Show(
                    "The image was saved with the wrong image format or the image was saved to the same file it was created from.",
                    "Error");
                MessageBox.Show(exception.ToString());
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "bmp";
            ofd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                Bitmap btm = null;
                btm = Open(btm, ofd);
               
                _painter.Clear();
                IHistory paint = _painter as IHistory;
                if (paint != null)
                {
                    paint.Add(btm);
                }
                else
                {
                    _painter.CurrentImage = btm;
                }
                MainPictureBox.Image = _painter.CurrentImage;
            }
        }

        private static Bitmap Open(Bitmap btm, OpenFileDialog ofd)
        {
            try
            {
                btm = (Bitmap) Image.FromFile(ofd.FileName);
            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show(
                    "The file does not have a valid image format.-or-GDI+ does not support the pixel format of the file.",
                    "Error");
                MessageBox.Show(exception.ToString());
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(
                    "The specified file does not exist",
                    "Error");
                MessageBox.Show(exception.ToString());
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(
                    "Filename is a System.Uri",
                    "Error");
                MessageBox.Show(exception.ToString());
            }
            return btm;
        }


        private void ResetBackColorButton_Click(object sender, EventArgs e)
        {
            BackColorPictureBox.BackColor = Color.Empty;
            _figBackColor = Color.Empty;
        }

        private void PenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pen.Width = (int)PenComboBox.SelectedItem;
        }

        private void PenTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pen.StartCap = _pen.EndCap = (LineCap)Enum.Parse(typeof(LineCap), PenTypeComboBox.SelectedItem.ToString());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            _painter.Clear();
            MainPictureBox.Image = null;
            SetStatusUndoRedoButton();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            IHistory paint = _painter as IHistory;
            if (paint != null)
            {
                if (paint.CanUndo)
                {
                    paint.Undo();
                }
                SetStatusUndoRedoButton();
                MainPictureBox.Image = _painter.CurrentImage;
            }
           
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {

            IHistory paint = _painter as IHistory;
            if (paint != null)
            {
                if (paint.CanRedo)
                {
                    paint.Redo();
                }
                SetStatusUndoRedoButton();
                MainPictureBox.Image = _painter.CurrentImage;
            }
            
        }
        #endregion

        #region MainPictureBox Handlers

        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _draw = true;
            _startPoint = new Point(e.X, e.Y);
            
        }

        private void MainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _draw = false;
            _finishPoint = new Point(e.X, e.Y);
            _painter.DrawFigure(_pen, _startPoint, _finishPoint, _currItem, _figBackColor);
            _painter.SaveImage();
            SetStatusUndoRedoButton();
            MainPictureBox.Image = _painter.CurrentImage;
        }

        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draw)
            {               
                _finishPoint = new Point(e.X, e.Y);
                _painter.DrawFigure(_pen, _startPoint, _finishPoint, _currItem, _figBackColor);
                MainPictureBox.Image = _painter.CurrentImage;
                if (_currItem == DrawItem.Eraser || _currItem == DrawItem.Point)
                {
                    _startPoint = new Point(e.X, e.Y);
                }
            }

            XStatusLabel.Text = e.X.ToString();
           YStatusLabel.Text = e.Y.ToString();
        }


        #endregion



        private void InversionButton_Click(object sender, EventArgs e)
        {
            IPictureProcess paint = _painter as IPictureProcess;
            if (paint != null)
            {
                Thread thread = new Thread(paint.Invert);
                thread.IsBackground = true;
                thread.Start();
            }
            

        }


        private void PainterOnProcUpdateEvent(int p)
        {
            Invoke(new Action(() => StripProgressBar.Value = p));
        }

        private void PainterOnProcessDone()
        {
            Invoke(
                    new Action
                    (
                        delegate
                        {
                            StripProgressBar.Value = 0;
                            MainPictureBox.Enabled = true;
                            MainPictureBox.Image = _painter.CurrentImage;
                        }
                    )
                  );
        }

        private void PaintOnProcessStart()
        {
            Invoke(new Action(() => MainPictureBox.Enabled = false));

        }

        private void SetColorFromTracks()
        {
            _foregColor = Color.FromArgb(AlphaTrackBar.Value, RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
        }

        private void SetControlsColor(Color source)
        {
            RedTrackBar.Value = source.R;
            GreenTrackBar.Value = source.G;
            BlueTrackBar.Value = source.B;
            AlphaTrackBar.Value = source.A;
            RedTextBox.Text = source.R.ToString();
            GreenTextBox.Text = source.G.ToString();
            BlueTextBox.Text = source.B.ToString();
            AlphaTextBox.Text = source.A.ToString();
            CurrentColorPictureBox.BackColor = source;
        }

        private void SetInitialButtonColor()
        {
            PencilButton.BackColor = _buttonInitialBackColor;
            LineToolStripButton.BackColor = _buttonInitialBackColor;
            SquareToolStripButton.BackColor = _buttonInitialBackColor;
            CircleToolStripButton.BackColor = _buttonInitialBackColor;
            EllipseToolStripButton.BackColor = _buttonInitialBackColor;
            EraserToolStripButton.BackColor = _buttonInitialBackColor;
        }

        private void SetStatusUndoRedoButton()
        {
            IHistory paint = _painter as IHistory;
            if (paint != null)
            {
                UndoButton.Enabled = paint.CanUndo;
                RedoButton.Enabled = paint.CanRedo;
            }
        }





        private bool _draw;
        private IPaintDraw _painter;
        private Color _foregColor;
        private Color _figBackColor;
        private Point _startPoint;
        private Point _finishPoint;
        private DrawItem _currItem;
        private Pen _pen;
    }
}
