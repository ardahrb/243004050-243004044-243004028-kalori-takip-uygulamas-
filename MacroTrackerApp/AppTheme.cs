using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MacroTrackerApp
{
    public static class AppTheme
    {
        public static readonly Color BgDark = Color.FromArgb(24, 28, 36);
        public static readonly Color BgCard = Color.FromArgb(32, 38, 50);
        public static readonly Color BgInput = Color.FromArgb(40, 48, 62);
        public static readonly Color Accent = Color.FromArgb(99, 179, 237);
        public static readonly Color AccentGreen = Color.FromArgb(72, 199, 142);
        public static readonly Color AccentOrange = Color.FromArgb(237, 167, 70);
        public static readonly Color AccentRed = Color.FromArgb(235, 87, 87);
        public static readonly Color AccentPurple = Color.FromArgb(155, 89, 182);
        public static readonly Color TextPrimary = Color.FromArgb(235, 240, 250);
        public static readonly Color TextSecondary = Color.FromArgb(160, 170, 190);
        public static readonly Color Border = Color.FromArgb(50, 58, 75);

        public static Font FontTitle = new Font("Segoe UI", 18F, FontStyle.Bold);
        public static Font FontSubtitle = new Font("Segoe UI", 11F);
        public static Font FontBody = new Font("Segoe UI", 9.5F);
        public static Font FontSmall = new Font("Segoe UI", 8.5F);
        public static Font FontBtnLarge = new Font("Segoe UI Semibold", 12F);
        public static Font FontBtnSmall = new Font("Segoe UI Semibold", 9.5F);

        public static void StyleForm(Form form, string title = "")
        {
            form.BackColor = BgDark;
            form.ForeColor = TextPrimary;
            form.Font = FontBody;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            if (!string.IsNullOrEmpty(title)) form.Text = title;
        }

        public static Panel CreateCard(int x, int y, int w, int h)
        {
            return new Panel()
            {
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = BgCard,
                Padding = new Padding(12),
            };
        }

        public static Button CreateButton(string text, int x, int y, int w, int h, Color bg)
        {
            var btn = new Button()
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = FontBtnSmall,
                Cursor = Cursors.Hand,
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(bg, 0.15f);
            return btn;
        }

        public static Button CreateLargeButton(string text, string icon, int x, int y, int w, int h, Color bg)
        {
            var btn = new Button()
            {
                Text = $"{icon}  {text}",
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = FontBtnLarge,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(bg, 0.15f);
            return btn;
        }

        public static Label CreateLabel(string text, int x, int y, Font? font = null, Color? color = null)
        {
            return new Label()
            {
                Text = text,
                Location = new Point(x, y),
                AutoSize = true,
                Font = font ?? FontBody,
                ForeColor = color ?? TextPrimary,
                BackColor = Color.Transparent,
            };
        }

        public static TextBox CreateTextBox(int x, int y, int w = 180)
        {
            var txt = new TextBox()
            {
                Location = new Point(x, y),
                Size = new Size(w, 28),
                Font = FontBody,
                BackColor = BgInput,
                ForeColor = TextPrimary,
                BorderStyle = BorderStyle.FixedSingle,
            };
            return txt;
        }

        public static ComboBox CreateComboBox(int x, int y, int w = 180)
        {
            var cmb = new ComboBox()
            {
                Location = new Point(x, y),
                Size = new Size(w, 28),
                Font = FontBody,
                BackColor = BgInput,
                ForeColor = TextPrimary,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
            };
            return cmb;
        }

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = BgCard;
            dgv.ForeColor = TextPrimary;
            dgv.GridColor = Border;
            dgv.BorderStyle = BorderStyle.None;
            dgv.Font = FontSmall;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 45, 60);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Accent;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 45, 60);
            dgv.ColumnHeadersHeight = 32;

            dgv.DefaultCellStyle.BackColor = BgCard;
            dgv.DefaultCellStyle.ForeColor = TextPrimary;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 80, 130);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 34, 46);
        }
    }

    public class MacroProgressBar : Panel
    {
        private double _value = 0;
        private double _max = 100;
        private Color _barColor = AppTheme.Accent;
        private string _label = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Value { get => _value; set { _value = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Maximum { get => _max; set { _max = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BarColor { get => _barColor; set { _barColor = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DisplayLabel { get => _label; set { _label = value; Invalidate(); } }

        public MacroProgressBar()
        {
            this.DoubleBuffered = true;
            this.Height = 28;
            this.BackColor = AppTheme.BgInput;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var bgBrush = new SolidBrush(AppTheme.BgInput))
            {
                var path = GetRoundedRect(new RectangleF(0, 0, Width, Height), 6);
                g.FillPath(bgBrush, path);
            }

            double ratio = _max > 0 ? Math.Min(_value / _max, 1.0) : 0;
            int barWidth = (int)(ratio * (Width - 2));
            if (barWidth > 0)
            {
                Color endColor = ratio > 0.9 ? AppTheme.AccentRed : _barColor;
                using (var barBrush = new LinearGradientBrush(
                    new Point(0, 0), new Point(barWidth, 0), _barColor, endColor))
                {
                    var barPath = GetRoundedRect(new RectangleF(1, 1, barWidth, Height - 2), 5);
                    g.FillPath(barBrush, barPath);
                }
            }

            if (!string.IsNullOrEmpty(_label))
            {
                using (var font = new Font("Segoe UI Semibold", 8.5F))
                using (var brush = new SolidBrush(Color.White))
                {
                    var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(_label, font, brush, new RectangleF(0, 0, Width, Height), sf);
                }
            }
        }

        private GraphicsPath GetRoundedRect(RectangleF rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
