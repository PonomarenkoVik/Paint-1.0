namespace MyPaint
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.RedoButton = new System.Windows.Forms.ToolStripButton();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.CutButton = new System.Windows.Forms.ToolStripButton();
            this.IncreaseButton = new System.Windows.Forms.ToolStripButton();
            this.DecreaseButton = new System.Windows.Forms.ToolStripButton();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.InfoButton = new System.Windows.Forms.ToolStripButton();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.PenComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.PenTypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.PencilButton = new System.Windows.Forms.ToolStripButton();
            this.LineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SquareToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CircleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EllipseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EraserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InvertButton = new System.Windows.Forms.ToolStripButton();
            this.ColorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentColorPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorCirclePictureBox = new System.Windows.Forms.PictureBox();
            this.labelRed = new System.Windows.Forms.Label();
            this.RedTextBox = new System.Windows.Forms.TextBox();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            this.labelGreen = new System.Windows.Forms.Label();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.labelBlue = new System.Windows.Forms.Label();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.AlphaLabel = new System.Windows.Forms.Label();
            this.AlphaTextBox = new System.Windows.Forms.TextBox();
            this.AlphaTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.BackColorPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetBackColorButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.XStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.YStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorCirclePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorPictureBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.OpenButton,
            this.SaveButton,
            this.CloseButton,
            this.UndoButton,
            this.RedoButton,
            this.CopyButton,
            this.CutButton,
            this.IncreaseButton,
            this.DecreaseButton,
            this.PrintButton,
            this.SettingsButton,
            this.InfoButton,
            this.ExitButton,
            this.PenComboBox,
            this.toolStripLabel1,
            this.PenTypeComboBox,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(995, 26);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "Create new";
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(23, 20);
            this.OpenButton.Text = "Open";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 20);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 20);
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(23, 20);
            this.UndoButton.Text = "Undo";
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoButton.Image")));
            this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(23, 20);
            this.RedoButton.Text = "Redo";
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 20);
            this.CopyButton.Text = "Copy";
            // 
            // CutButton
            // 
            this.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutButton.Image = ((System.Drawing.Image)(resources.GetObject("CutButton.Image")));
            this.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(23, 20);
            this.CutButton.Text = "Cut";
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IncreaseButton.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseButton.Image")));
            this.IncreaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(23, 20);
            this.IncreaseButton.Text = "Increase";
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DecreaseButton.Image = ((System.Drawing.Image)(resources.GetObject("DecreaseButton.Image")));
            this.DecreaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(23, 20);
            this.DecreaseButton.Text = "Decrease";
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(23, 20);
            this.PrintButton.Text = "Print";
            // 
            // SettingsButton
            // 
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(23, 20);
            this.SettingsButton.Text = "Settings";
            // 
            // InfoButton
            // 
            this.InfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InfoButton.Image = ((System.Drawing.Image)(resources.GetObject("InfoButton.Image")));
            this.InfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(23, 20);
            this.InfoButton.Text = "About programm";
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(23, 20);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PenComboBox
            // 
            this.PenComboBox.DropDownWidth = 75;
            this.PenComboBox.Name = "PenComboBox";
            this.PenComboBox.Size = new System.Drawing.Size(75, 23);
            this.PenComboBox.SelectedIndexChanged += new System.EventHandler(this.PenComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripLabel1.Text = "Pen size";
            // 
            // PenTypeComboBox
            // 
            this.PenTypeComboBox.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.PenTypeComboBox.Name = "PenTypeComboBox";
            this.PenTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.PenTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.PenTypeComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 20);
            this.toolStripLabel2.Text = "Pen type";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PencilButton,
            this.LineToolStripButton,
            this.SquareToolStripButton,
            this.CircleToolStripButton,
            this.EllipseToolStripButton,
            this.EraserToolStripButton,
            this.InvertButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 26);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 505);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // PencilButton
            // 
            this.PencilButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PencilButton.Image = ((System.Drawing.Image)(resources.GetObject("PencilButton.Image")));
            this.PencilButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(21, 20);
            this.PencilButton.Text = "Pen";
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // LineToolStripButton
            // 
            this.LineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LineToolStripButton.Image")));
            this.LineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineToolStripButton.Name = "LineToolStripButton";
            this.LineToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.LineToolStripButton.Text = "Line";
            this.LineToolStripButton.Click += new System.EventHandler(this.StickStripButton_Click);
            // 
            // SquareToolStripButton
            // 
            this.SquareToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SquareToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SquareToolStripButton.Image")));
            this.SquareToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SquareToolStripButton.Name = "SquareToolStripButton";
            this.SquareToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.SquareToolStripButton.Text = "Rectangle";
            this.SquareToolStripButton.Click += new System.EventHandler(this.SquareToolStripButton_Click);
            // 
            // CircleToolStripButton
            // 
            this.CircleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CircleToolStripButton.Image")));
            this.CircleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CircleToolStripButton.Name = "CircleToolStripButton";
            this.CircleToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.CircleToolStripButton.Text = "Circle";
            this.CircleToolStripButton.Click += new System.EventHandler(this.CircleToolStripButton_Click);
            // 
            // EllipseToolStripButton
            // 
            this.EllipseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EllipseToolStripButton.Image")));
            this.EllipseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EllipseToolStripButton.Name = "EllipseToolStripButton";
            this.EllipseToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.EllipseToolStripButton.Text = "Ellipse";
            this.EllipseToolStripButton.Click += new System.EventHandler(this.EllipseToolStripButton_Click);
            // 
            // EraserToolStripButton
            // 
            this.EraserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EraserToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EraserToolStripButton.Image")));
            this.EraserToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EraserToolStripButton.Name = "EraserToolStripButton";
            this.EraserToolStripButton.Size = new System.Drawing.Size(21, 20);
            this.EraserToolStripButton.Text = "Eraser";
            this.EraserToolStripButton.Click += new System.EventHandler(this.EraserToolStripButton_Click);
            // 
            // InvertButton
            // 
            this.InvertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InvertButton.Image = ((System.Drawing.Image)(resources.GetObject("InvertButton.Image")));
            this.InvertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InvertButton.Margin = new System.Windows.Forms.Padding(0, 40, 0, 2);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(21, 20);
            this.InvertButton.Text = "Inversion";
            this.InvertButton.Click += new System.EventHandler(this.InversionButton_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPanel.Controls.Add(this.CurrentColorPictureBox);
            this.ColorPanel.Controls.Add(this.ColorCirclePictureBox);
            this.ColorPanel.Controls.Add(this.labelRed);
            this.ColorPanel.Controls.Add(this.RedTextBox);
            this.ColorPanel.Controls.Add(this.RedTrackBar);
            this.ColorPanel.Controls.Add(this.labelGreen);
            this.ColorPanel.Controls.Add(this.GreenTextBox);
            this.ColorPanel.Controls.Add(this.GreenTrackBar);
            this.ColorPanel.Controls.Add(this.labelBlue);
            this.ColorPanel.Controls.Add(this.BlueTextBox);
            this.ColorPanel.Controls.Add(this.BlueTrackBar);
            this.ColorPanel.Controls.Add(this.AlphaLabel);
            this.ColorPanel.Controls.Add(this.AlphaTextBox);
            this.ColorPanel.Controls.Add(this.AlphaTrackBar);
            this.ColorPanel.Controls.Add(this.label1);
            this.ColorPanel.Controls.Add(this.BackColorPictureBox);
            this.ColorPanel.Controls.Add(this.ResetBackColorButton);
            this.ColorPanel.Location = new System.Drawing.Point(770, 29);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(213, 468);
            this.ColorPanel.TabIndex = 4;
            // 
            // CurrentColorPictureBox
            // 
            this.CurrentColorPictureBox.Location = new System.Drawing.Point(3, 3);
            this.CurrentColorPictureBox.Name = "CurrentColorPictureBox";
            this.CurrentColorPictureBox.Size = new System.Drawing.Size(100, 100);
            this.CurrentColorPictureBox.TabIndex = 1;
            this.CurrentColorPictureBox.TabStop = false;
            // 
            // ColorCirclePictureBox
            // 
            this.ColorCirclePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorCirclePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ColorCirclePictureBox.Image")));
            this.ColorCirclePictureBox.Location = new System.Drawing.Point(109, 3);
            this.ColorCirclePictureBox.Name = "ColorCirclePictureBox";
            this.ColorCirclePictureBox.Size = new System.Drawing.Size(99, 100);
            this.ColorCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ColorCirclePictureBox.TabIndex = 0;
            this.ColorCirclePictureBox.TabStop = false;
            this.ColorCirclePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColorCirclePictureBox_MouseClick);
            this.ColorCirclePictureBox.MouseLeave += new System.EventHandler(this.ColorCirclePictureBox_MouseLeave);
            this.ColorCirclePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorCirclePictureBox_MouseMove);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(3, 116);
            this.labelRed.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(15, 13);
            this.labelRed.TabIndex = 4;
            this.labelRed.Text = "R";
            // 
            // RedTextBox
            // 
            this.RedTextBox.Location = new System.Drawing.Point(24, 114);
            this.RedTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.RedTextBox.Name = "RedTextBox";
            this.RedTextBox.ReadOnly = true;
            this.RedTextBox.Size = new System.Drawing.Size(24, 20);
            this.RedTextBox.TabIndex = 5;
            this.RedTextBox.Text = "0";
            this.RedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RedTrackBar.Location = new System.Drawing.Point(54, 114);
            this.RedTrackBar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.RedTrackBar.Maximum = 255;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(155, 45);
            this.RedTrackBar.TabIndex = 3;
            this.RedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTrackBar.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(3, 172);
            this.labelGreen.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(15, 13);
            this.labelGreen.TabIndex = 7;
            this.labelGreen.Text = "G";
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.Location = new System.Drawing.Point(24, 170);
            this.GreenTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.ReadOnly = true;
            this.GreenTextBox.Size = new System.Drawing.Size(24, 20);
            this.GreenTextBox.TabIndex = 8;
            this.GreenTextBox.Text = "0";
            this.GreenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GreenTrackBar.Location = new System.Drawing.Point(54, 170);
            this.GreenTrackBar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.GreenTrackBar.Maximum = 255;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(155, 45);
            this.GreenTrackBar.TabIndex = 6;
            this.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrackBar.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(3, 228);
            this.labelBlue.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(14, 13);
            this.labelBlue.TabIndex = 10;
            this.labelBlue.Text = "B";
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.Location = new System.Drawing.Point(23, 226);
            this.BlueTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.ReadOnly = true;
            this.BlueTextBox.Size = new System.Drawing.Size(24, 20);
            this.BlueTextBox.TabIndex = 11;
            this.BlueTextBox.Text = "0";
            this.BlueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueTrackBar.Location = new System.Drawing.Point(53, 226);
            this.BlueTrackBar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.BlueTrackBar.Maximum = 255;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(155, 45);
            this.BlueTrackBar.TabIndex = 9;
            this.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // AlphaLabel
            // 
            this.AlphaLabel.AutoSize = true;
            this.AlphaLabel.Location = new System.Drawing.Point(3, 284);
            this.AlphaLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.AlphaLabel.Name = "AlphaLabel";
            this.AlphaLabel.Size = new System.Drawing.Size(14, 13);
            this.AlphaLabel.TabIndex = 13;
            this.AlphaLabel.Text = "A";
            // 
            // AlphaTextBox
            // 
            this.AlphaTextBox.Location = new System.Drawing.Point(23, 282);
            this.AlphaTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.AlphaTextBox.Name = "AlphaTextBox";
            this.AlphaTextBox.ReadOnly = true;
            this.AlphaTextBox.Size = new System.Drawing.Size(24, 20);
            this.AlphaTextBox.TabIndex = 14;
            this.AlphaTextBox.Text = "0";
            this.AlphaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AlphaTrackBar
            // 
            this.AlphaTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlphaTrackBar.Location = new System.Drawing.Point(53, 282);
            this.AlphaTrackBar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.AlphaTrackBar.Maximum = 255;
            this.AlphaTrackBar.Name = "AlphaTrackBar";
            this.AlphaTrackBar.Size = new System.Drawing.Size(155, 45);
            this.AlphaTrackBar.TabIndex = 12;
            this.AlphaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.AlphaTrackBar.Scroll += new System.EventHandler(this.TrackBars_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(55, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Background color";
            // 
            // BackColorPictureBox
            // 
            this.BackColorPictureBox.Location = new System.Drawing.Point(55, 348);
            this.BackColorPictureBox.Margin = new System.Windows.Forms.Padding(55, 5, 5, 5);
            this.BackColorPictureBox.Name = "BackColorPictureBox";
            this.BackColorPictureBox.Size = new System.Drawing.Size(100, 100);
            this.BackColorPictureBox.TabIndex = 15;
            this.BackColorPictureBox.TabStop = false;
            this.BackColorPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackColorPictureBox_MouseClick);
            // 
            // ResetBackColorButton
            // 
            this.ResetBackColorButton.Location = new System.Drawing.Point(163, 383);
            this.ResetBackColorButton.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.ResetBackColorButton.Name = "ResetBackColorButton";
            this.ResetBackColorButton.Size = new System.Drawing.Size(45, 23);
            this.ResetBackColorButton.TabIndex = 17;
            this.ResetBackColorButton.Text = "Reset";
            this.ResetBackColorButton.UseVisualStyleBackColor = true;
            this.ResetBackColorButton.Click += new System.EventHandler(this.ResetBackColorButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.XStatusLabel,
            this.toolStripStatusLabel3,
            this.YStatusLabel,
            this.StripProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(673, 505);
            this.StatusStrip.Margin = new System.Windows.Forms.Padding(5);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(322, 26);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 21);
            this.toolStripStatusLabel1.Text = "X: ";
            // 
            // XStatusLabel
            // 
            this.XStatusLabel.Name = "XStatusLabel";
            this.XStatusLabel.Size = new System.Drawing.Size(25, 21);
            this.XStatusLabel.Text = "000";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(20, 21);
            this.toolStripStatusLabel3.Text = "Y: ";
            // 
            // YStatusLabel
            // 
            this.YStatusLabel.Name = "YStatusLabel";
            this.YStatusLabel.Size = new System.Drawing.Size(25, 21);
            this.YStatusLabel.Text = "000";
            // 
            // StripProgressBar
            // 
            this.StripProgressBar.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.StripProgressBar.Name = "StripProgressBar";
            this.StripProgressBar.Size = new System.Drawing.Size(160, 16);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainPictureBox.Location = new System.Drawing.Point(29, 32);
            this.MainPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(733, 465);
            this.MainPictureBox.TabIndex = 6;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
            this.MainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            this.MainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 531);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 570);
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Paint";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorCirclePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorPictureBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton UndoButton;
        private System.Windows.Forms.ToolStripButton RedoButton;
        private System.Windows.Forms.ToolStripButton CopyButton;
        private System.Windows.Forms.ToolStripButton CutButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.ToolStripButton IncreaseButton;
        private System.Windows.Forms.ToolStripButton DecreaseButton;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripButton SettingsButton;
        private System.Windows.Forms.ToolStripButton InfoButton;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton PencilButton;
        private System.Windows.Forms.ToolStripButton LineToolStripButton;
        private System.Windows.Forms.ToolStripButton SquareToolStripButton;
        private System.Windows.Forms.ToolStripButton CircleToolStripButton;
        private System.Windows.Forms.ToolStripButton EllipseToolStripButton;
        private System.Windows.Forms.FlowLayoutPanel ColorPanel;
        private System.Windows.Forms.PictureBox CurrentColorPictureBox;
        private System.Windows.Forms.PictureBox ColorCirclePictureBox;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.TextBox RedTextBox;
        private System.Windows.Forms.TrackBar RedTrackBar;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.TextBox GreenTextBox;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.TextBox BlueTextBox;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.Label AlphaLabel;
        private System.Windows.Forms.TextBox AlphaTextBox;
        private System.Windows.Forms.TrackBar AlphaTrackBar;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripProgressBar StripProgressBar;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.PictureBox BackColorPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton EraserToolStripButton;
        private System.Windows.Forms.Button ResetBackColorButton;
        private System.Windows.Forms.ToolStripComboBox PenComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox PenTypeComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton InvertButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel XStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel YStatusLabel;

    }
}

