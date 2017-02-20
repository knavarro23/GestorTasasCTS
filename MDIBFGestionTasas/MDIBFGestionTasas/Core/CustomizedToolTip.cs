using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MDIBFGestionTasas.Core
{
    /// <summary>
    /// CustomizedToolTip to create tooltips with Image.
    /// </summary>
    internal class CustomizedToolTip : ToolTip
    {
        #region Constants

        private const int TooltipWidth = 250;
        private const int TooltipHeight = 250;
        private const int BorderThickness = 1;
        private const int Padding = 6;
        private const int DefaultImageWidth = 200;

        #endregion

        #region Fields

        private static Color _myBorderColor = Color.Green;
        private static readonly Font MyFont = new Font("Arial", 8);

        private readonly StringFormat _myTextFormat = new StringFormat();

        private Rectangle _myImageRectangle;
        private Rectangle _myToolTipRectangle;

        private Brush _myBackColorBrush = new SolidBrush(Color.LightYellow);
        private Brush _myTextBrush = new SolidBrush(Color.Black);
        private Brush _myBorderBrush = new SolidBrush(_myBorderColor);

        private Size _mySize = new Size(TooltipWidth, TooltipHeight);

        private int _myInternalImageWidth = DefaultImageWidth;
        private bool _myAutoSize = true;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether the ToolTip is drawn by the operating
        /// system or by code that you provide.
        /// If true, the properties 'ToolTipIcon' and 'ToolTipTitle' will set to their default values
        /// and the image will display in ToolTip otherwise only text will display.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets a value indicating whether the ToolTip is drawn by the operating system or by code that you provide. If true, the properties 'ToolTipIcon' and 'ToolTipTitle' will set to their default values and the image will display in ToolTip otherwise only text will display.")]
        public new bool OwnerDraw
        {
            get
            {
                return base.OwnerDraw;
            }
            set
            {
                if (value)
                {
                    ToolTipIcon = ToolTipIcon.None;
                    ToolTipTitle = string.Empty;
                }
                base.OwnerDraw = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that defines the type of icon to be displayed alongside
        /// the ToolTip text.
        /// Cannot set if the property 'OwnerDraw' is true.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets a value that defines the type of icon to be displayed alongside the ToolTip text. Cannot set if the property 'OwnerDraw' is true.")]
        public new ToolTipIcon ToolTipIcon
        {
            get
            {
                return base.ToolTipIcon;
            }
            set
            {
                if (!OwnerDraw)
                {
                    base.ToolTipIcon = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets a title for the ToolTip window.
        /// Cannot set if the property 'OwnerDraw' is true.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets a title for the ToolTip window. Cannot set if the property 'OwnerDraw' is true.")]
        public new string ToolTipTitle
        {
            get
            {
                return base.ToolTipTitle;
            }
            set
            {
                if (!OwnerDraw)
                {
                    base.ToolTipTitle = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the background color for the ToolTip.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets the background color for the ToolTip.")]
        public new Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                Brush temp = _myBackColorBrush;
                _myBackColorBrush = new SolidBrush(value);
                temp.Dispose();
            }
        }

        /// <summary>
        /// Gets or sets the foreground color for the ToolTip.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets the foreground color for the ToolTip.")]
        public new Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                Brush temp = _myTextBrush;
                _myTextBrush = new SolidBrush(value);
                temp.Dispose();
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the ToolTip resizes based on its text.
        /// true if the ToolTip automatically resizes based on its text; otherwise, false. The default is true.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets a value that indicates whether the ToolTip resizes based on its text. true if the ToolTip automatically resizes based on its text; otherwise, false. The default is true.")]
        public bool AutoSize
        {
            get { return _myAutoSize; }
            set
            {
                _myAutoSize = value;
                _myTextFormat.Trimming = _myAutoSize ? StringTrimming.None : StringTrimming.EllipsisCharacter;
            }
        }

        /// <summary>
        /// Gets or sets the size of the ToolTip.
        /// Valid only if the Property 'AutoSize' is false.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets the size of the ToolTip. Valid only if the Property 'AutoSize' is false.")]
        public Size Size
        {
            get { return _mySize; }
            set
            {
                if (!_myAutoSize)
                {
                    _mySize = value;
                    _myToolTipRectangle.Size = _mySize;
                }
            }
        }

        /// <summary>
        /// Gets or sets the border color for the ToolTip.
        /// </summary>
        [Category("Custom Settings"), Description(@"Gets or sets the border color for the ToolTip.")]
        public Color BorderColor
        {
            get
            {
                return _myBorderColor;
            }
            set
            {
                _myBorderColor = value;
                Brush temp = _myBorderBrush;
                _myBorderBrush = new SolidBrush(value);
                temp.Dispose();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create instance of CustomizedToolTip class that can display Thumbnails/Images in it.
        /// </summary>
        public CustomizedToolTip()
        {
            try
            {
                OwnerDraw = true;

                _myTextFormat.FormatFlags = StringFormatFlags.LineLimit;
                _myTextFormat.Alignment = StringAlignment.Near;
                _myTextFormat.LineAlignment = StringAlignment.Center;
                _myTextFormat.Trimming = StringTrimming.None;

                Popup += CustomizedToolTip_Popup;
                Draw += CustomizedToolTip_Draw;
            }
            catch (Exception ex)
            {
                string logMessage = "Exception in CustomizedToolTip.CustomizedToolTip () " + ex;
                Trace.TraceError(logMessage);
                throw;
            }
        }

        #endregion

        #region Methods

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                //Dispose of the disposable objects.
                try
                {
                    if (disposing)
                    {
                        if (MyFont != null)
                        {
                            MyFont.Dispose();
                        }
                        if (_myTextBrush != null)
                        {
                            _myTextBrush.Dispose();
                        }
                        if (_myBackColorBrush != null)
                        {
                            _myBackColorBrush.Dispose();
                        }
                        if (_myBorderBrush != null)
                        {
                            _myBorderBrush.Dispose();
                        }
                        if (_myTextFormat != null)
                        {
                            _myTextFormat.Dispose();
                        }
                    }
                }
                finally
                {
                    base.Dispose(disposing);
                }
            }

            catch (Exception ex)
            {
                string logMessage = "Exception in CustomizedToolTip.Dispose (bool) " + ex;
                Trace.TraceError(logMessage);
                throw;
            }
        }

        /// <summary>
        /// CustomizedToolTip_Draw raised when tooltip is drawn.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void CustomizedToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            try
            {
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

                _myToolTipRectangle.Size = e.Bounds.Size;
                e.Graphics.FillRectangle(_myBorderBrush, _myToolTipRectangle);

                _myImageRectangle = Rectangle.Inflate(_myToolTipRectangle, -BorderThickness, -BorderThickness);
                e.Graphics.FillRectangle(_myBackColorBrush, _myImageRectangle);

                Control parent = e.AssociatedControl;
                Image toolTipImage = parent.Tag as Image;
                if (toolTipImage != null)
                {
                    e.Graphics.DrawImage(toolTipImage, _myImageRectangle);
                }
                else
                {
                    e.Graphics.DrawString(e.ToolTipText, MyFont, _myTextBrush, _myImageRectangle, _myTextFormat);
                }
            }

            catch (Exception ex)
            {
                string logMessage = "Exception in CustomizedToolTip.BlindHeaderToolTip_Draw (object, DrawToolTipEventArgs) " + ex;
                Trace.TraceError(logMessage);
                throw;
            }
        }

        /// <summary>
        /// CustomizedToolTip_Popup raised when tooltip pops up.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        void CustomizedToolTip_Popup(object sender, PopupEventArgs e)
        {
            try
            {
                if (OwnerDraw)
                {
                    if (!_myAutoSize)
                    {
                        e.ToolTipSize = _mySize;
                        _myInternalImageWidth = _mySize.Height;
                    }
                    else
                    {
                        Size oldSize = e.ToolTipSize;
                        Control parent = e.AssociatedControl;
                        Image toolTipImage = parent.Tag as Image;
                        if (toolTipImage != null)
                        {
                            _myInternalImageWidth = oldSize.Height;
                            oldSize.Width += _myInternalImageWidth + Padding;
                        }
                        else
                        {
                            oldSize.Width += Padding;
                        }
                        e.ToolTipSize = oldSize;
                    }
                }
            }
            catch (Exception ex)
            {
                string logMessage = "Exception in CustomizedToolTip.CustomizedToolTip_Popup (object, PopupEventArgs) " + ex;
                Trace.TraceError(logMessage);
                throw;
            }
        }

        #endregion
    }
}