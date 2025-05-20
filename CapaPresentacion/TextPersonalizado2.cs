using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    [DefaultEvent("_TextChanged")]
    public class TextPersonalizado2 : UserControl
    {
        // Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private int borderRadius = 0;

        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isFocused = false;
        private bool isPasswordChar = false;

        private string text = "";

        // Caret
        private int caretPosition = 0;
        private Timer caretTimer;
        private bool caretVisible = false;

        // Events
        public event EventHandler _TextChanged;

        // Constructor
        public TextPersonalizado2()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Font = new Font("Segoe UI", 9F);

            this.TabStop = true; // allow focus

            caretTimer = new Timer();
            caretTimer.Interval = 500;
            caretTimer.Tick += CaretTimer_Tick;

            this.Cursor = Cursors.IBeam;

            this.Size = new Size(150, 30);

            this.Padding = new Padding(5);
        }

        private void CaretTimer_Tick(object sender, EventArgs e)
        {
            caretVisible = !caretVisible;
            Invalidate();
        }

        // Properties

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value >= 1 ? value : 1; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set { underlinedStyle = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value >= 0 ? value : 0; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set { placeholderColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public string PlaceholderText
        {
            get => placeholderText;
            set { placeholderText = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public bool PasswordChar
        {
            get => isPasswordChar;
            set { isPasswordChar = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set { base.ForeColor = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get => base.Font;
            set { base.Font = value; Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public override string Text
        {
            get => text;
            set
            {
                if (text != value)
                {
                    text = value ?? "";
                    caretPosition = Math.Min(caretPosition, text.Length);
                    _TextChanged?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        // Override focus behavior to start/stop caret blinking
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            isFocused = true;
            caretVisible = true;
            caretTimer.Start();
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            isFocused = false;
            caretTimer.Stop();
            caretVisible = false;
            Invalidate();
        }

        // Keyboard handling
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!isFocused)
                return;

            bool invalidate = false;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (caretPosition > 0)
                    {
                        caretPosition--;
                        invalidate = true;
                    }
                    e.Handled = true;
                    break;
                case Keys.Right:
                    if (caretPosition < text.Length)
                    {
                        caretPosition++;
                        invalidate = true;
                    }
                    e.Handled = true;
                    break;
                case Keys.Back:
                    if (caretPosition > 0)
                    {
                        text = text.Remove(caretPosition - 1, 1);
                        caretPosition--;
                        _TextChanged?.Invoke(this, EventArgs.Empty);
                        invalidate = true;
                    }
                    e.Handled = true;
                    break;
                case Keys.Delete:
                    if (caretPosition < text.Length)
                    {
                        text = text.Remove(caretPosition, 1);
                        _TextChanged?.Invoke(this, EventArgs.Empty);
                        invalidate = true;
                    }
                    e.Handled = true;
                    break;
            }

            if (invalidate) Invalidate();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!isFocused)
                return;

            if (!char.IsControl(e.KeyChar))
            {
                text = text.Insert(caretPosition, e.KeyChar.ToString());
                caretPosition++;
                _TextChanged?.Invoke(this, EventArgs.Empty);
                Invalidate();
                e.Handled = true;
            }
        }

        // Mouse click: set caret position where clicked
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();

            using (Graphics g = CreateGraphics())
            {
                string drawText = isPasswordChar ? new string('•', text.Length) : text;

                int x = Padding.Left;
                caretPosition = 0;

                for (int i = 1; i <= drawText.Length; i++)
                {
                    string substr = drawText.Substring(0, i);
                    int width = (int)g.MeasureString(substr, Font).Width;

                    if (e.X < x + width)
                    {
                        caretPosition = i - 1;
                        break;
                    }

                    caretPosition = i;
                }
            }
            Invalidate();
        }

        // Paint everything
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw background
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(brush, this.ClientRectangle);
            }

            // Draw border
            Color currentBorderColor = isFocused ? borderFocusColor : borderColor;

            using (Pen pen = new Pen(currentBorderColor, borderSize))
            {
                if (underlinedStyle)
                {
                    g.DrawLine(pen, 0, this.Height - borderSize / 2, this.Width, this.Height - borderSize / 2);
                }
                else if (borderRadius > 1)
                {
                    System.Drawing.Drawing2D.GraphicsPath path = GetRoundRect(this.ClientRectangle, borderRadius);
                    g.DrawPath(pen, path);
                }
                else
                {
                    g.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }

            Rectangle textRect = new Rectangle(Padding.Left, Padding.Top, this.Width - Padding.Horizontal, this.Height - Padding.Vertical);

            string displayText = text;

            if (string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(placeholderText) && !isFocused)
            {
                // Draw placeholder
                using (SolidBrush brush = new SolidBrush(placeholderColor))
                {
                    g.DrawString(placeholderText, this.Font, brush, textRect.Location);
                }
            }
            else
            {
                if (isPasswordChar)
                {
                    displayText = new string('•', text.Length);
                }
                using (SolidBrush brush = new SolidBrush(this.ForeColor))
                {
                    g.DrawString(displayText, this.Font, brush, textRect.Location);
                }
            }

            // Draw caret if focused and visible
            if (isFocused && caretVisible)
            {
                // Calculate caret position in pixels
                string textBeforeCaret = isPasswordChar ? new string('•', caretPosition) : text.Substring(0, caretPosition);
                int caretX = Padding.Left + (int)g.MeasureString(textBeforeCaret, this.Font).Width;
                int caretY = Padding.Top;

                using (Pen caretPen = new Pen(this.ForeColor))
                {
                    g.DrawLine(caretPen, caretX, caretY, caretX, caretY + this.Font.Height);
                }
            }
        }

        // Helper method for rounded rectangle
        private System.Drawing.Drawing2D.GraphicsPath GetRoundRect(Rectangle rect, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
