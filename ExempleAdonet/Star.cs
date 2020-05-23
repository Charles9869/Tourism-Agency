using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationDemo
{
    // Auteur: Nicolas Chourot

    public partial class Star : UserControl
    {
        private Color _EnabledFillColor;
        private Color _EnabledCountourColor;
        private int _EnabledCountourWidth;

        private Color _DisabledFillColor;
        private Color _DisabledCountourColor;
        private int _DisabledCountourWidth;

        private Color _OverFillColor;
        private Color _OverCountourColor;
        private int _OverCountourWidth;

        private float _RadiusRatio;
        private float _BranchCount;
        private bool _overed;
        private bool _Highlighted;
        
        public Color EnabledFillColor { get { return _EnabledFillColor; } set { _EnabledFillColor = value; Refresh(); } }
        public Color EnabledCountourColor { get { return _EnabledCountourColor; } set { _EnabledCountourColor = value; Refresh(); } }
        public int EnabledCountourWidth { get { return _EnabledCountourWidth; } set { _EnabledCountourWidth = value; Refresh(); } }

        public Color DisabledFillColor { get { return _DisabledFillColor; } set { _DisabledFillColor = value; Refresh(); } }
        public Color DisabledCountourColor { get { return _DisabledCountourColor; } set { _DisabledCountourColor = value; Refresh(); } }
        public int DisabledCountourWidth { get { return _DisabledCountourWidth; } set { _DisabledCountourWidth = value; Refresh(); } }

        public Color OverFillColor { get { return _OverFillColor; } set { _OverFillColor = value; Refresh(); } }
        public Color OverCountourColor { get { return _OverCountourColor; } set { _OverCountourColor = value; Refresh(); } }
        public int OverCountourWidth { get { return _OverCountourWidth; } set { _OverCountourWidth = value; Refresh(); } }

        public float RadiusRatio { get { return _RadiusRatio; } set { _RadiusRatio = value; Refresh(); } }
        public float BranchCount { get { return _BranchCount; } set { _BranchCount = value; Refresh(); } }
        public bool Highlighted { get { return _Highlighted; } set { _Highlighted = value; Refresh(); } }

        public Star()
        {
            InitializeComponent();

            EnabledFillColor = Color.Gold;
            EnabledCountourColor = Color.Goldenrod;
            EnabledCountourWidth = 1;

            DisabledFillColor = Color.LightGray;
            DisabledCountourColor = Color.LightGray;
            DisabledCountourWidth = 0;

            OverFillColor = Color.LightGoldenrodYellow;
            OverCountourColor = Color.Goldenrod;
            OverCountourWidth = 2;

            RadiusRatio = 0.385F;
            BranchCount = 5;
            _overed = false;
            Highlighted = false;
            Cursor = Cursors.Hand;
        }

        private void InitializeComponent()
        {

        }

        private List<PointF> MakeCountour()
        {
            List<PointF> points = new List<PointF>();
            float radius = Math.Min(Width, Height) / 2.0F;
            PointF center = new PointF(Width / 2.0F, Height / 2.0F + OverCountourWidth / 2.0F);
            float delatAngle = (float)Math.PI / BranchCount;

            float currentX = 0.0F;
            float currentY = radius;
            float startAngle = (float)Math.PI / 2.0F;
            bool toggleRadius = false;
            for (float angle = 0; angle < 2 * Math.PI; angle += delatAngle)
            {
                currentX = (float)((toggleRadius ? radius * RadiusRatio : radius) * Math.Cos(startAngle + angle));
                currentY = -(float)((toggleRadius ? radius * RadiusRatio : radius) * Math.Sin(startAngle + angle));
                points.Add(new PointF(currentX + center.X, currentY + center.Y));
                toggleRadius = !toggleRadius;
            }
            return points;
        }
        private void Draw(Graphics DC)
        {
            DC.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PointF[] lines = MakeCountour().ToArray();
            Pen pen;
            Brush brush;

            if (_overed)
            {
                pen = new Pen(OverCountourColor, OverCountourWidth);
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                brush = new SolidBrush(OverFillColor);
            }
            else
            {
                if (Highlighted)
                {
                    pen = new Pen(EnabledCountourColor, EnabledCountourWidth);
                    pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    brush = new SolidBrush(EnabledFillColor);
                }
                else
                {
                    pen = new Pen(DisabledCountourColor, DisabledCountourWidth);
                    pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    brush = new SolidBrush(DisabledFillColor);
                }
            }
            DC.FillPolygon(brush, lines);
            DC.DrawPolygon(pen, lines);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Draw(e.Graphics);
        }

        private void Star_MouseHover(object sender, EventArgs e)
        {
            _overed = true;
            Refresh();
        }

        private void Star_MouseLeave(object sender, EventArgs e)
        {
            _overed = false;
            Refresh();
        }
    }
}
