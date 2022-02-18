using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorControl
{
    public partial class ColorRectangle : Control
    {
        private Color _color;
        public Color Color {
            get { return _color; }
            set { 
                _color = value;
                Invalidate();
            }
        }
        public ColorRectangle()
        {
            InitializeComponent();
        }

        public ColorRectangle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = CreateGraphics();

            g.FillRectangle(new SolidBrush(_color), ClientRectangle);
        }
    }
}
