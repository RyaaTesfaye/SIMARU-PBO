using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Utils
{
    public class SimpleProgressBar : Control
    {
        private int _value = 0;
        private int _maximum = 100;

        public int Value
        {
            get => _value;
            set
            {
                _value = Math.Max(0, Math.Min(value, _maximum));
                Invalidate(); 
            }
        }
        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = Math.Max(1, value);
                Invalidate();
            }
        }
        public SimpleProgressBar()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);

            this.Height = 10;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.FromArgb(60, 60, 60));

            float percent = (float)_value / _maximum;
            int fillWidth = (int)(Width * percent);

            using (Brush yellowBrush = new SolidBrush(Color.Yellow))
            {
                e.Graphics.FillRectangle(yellowBrush, 0, 0, fillWidth, Height);
            }
        }
    }
}
