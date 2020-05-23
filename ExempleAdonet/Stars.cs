using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationDemo;

namespace EvaluationDemo
{
    // Auteur: Nicolas Chourot

    [DefaultEvent("ValueChanged")]
    public partial class Stars : UserControl
    {
        private int _StarsCount;
        private int _Value;

        public delegate void ValueChangedEventHandler(object sender, EventArgs e);
        public event ValueChangedEventHandler ValueChanged;
        public int StarsCount
        {
            get
            {
                return _StarsCount;
            }
            set
            {
                if ((value > 1) && (value <= 10))
                {
                    _StarsCount = value;
                    InstallStars();
                }
            }
        }
        public int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if ((value <= StarsCount) && (value >= 0))
                {
                    _Value = value;
                    UpdateValue();
                    ValueChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public Stars()
        {
            InitializeComponent();
            MinimumSize = new Size(100, 20);
            _StarsCount = 5;
            _Value = 0;
            Size = new Size(150, 30);
        }

        private void InstallStars()
        {
            Controls.Clear();
            Size = new Size(Height*StarsCount, Height);
            for (int s = 0; s < StarsCount; s++)
            {
                Star star = new Star();
                star.Size = new Size(Height - 5, Height - 5);
                star.Location = new Point(s * Height, 3);
                star.MouseHover += Star_MouseHover;
                star.MouseLeave += Star_MouseLeave;
                star.Click += Star_Click;
                Controls.Add(star);
            }
            UpdateValue();
        }

        private void UpdateValue()
        {
            for (int s = 0; s < StarsCount; s++)
            {
                ((Star)Controls[s]).Highlighted = s < Value;
            }
        }
        private void Star_MouseHover(object sender, EventArgs e)
        {
            Star star = (Star)sender;
            int starIndex = Controls.IndexOf(star);
            for (int s = 0; s < StarsCount; s++)
            {
                ((Star)Controls[s]).Highlighted = s <= starIndex;
            }
        }
        private void Star_MouseLeave(object sender, EventArgs e)
        {
            UpdateValue();
        }
        private void Star_Click(object sender, EventArgs e)
        {
            Star star = (Star)sender;
            Value = Controls.IndexOf(star) + 1;
            UpdateValue();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Width = StarsCount * Height;
            InstallStars();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Stars
            // 
            this.Name = "Stars";
            this.Load += new System.EventHandler(this.Stars_Load);
            this.ResumeLayout(false);

        }

        private void Stars_Load(object sender, EventArgs e)
        {

        }
    }
}
