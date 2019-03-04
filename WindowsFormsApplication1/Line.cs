using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    
    class Line : DrawShape
    {
        override
        public void paintShape(int ox, int oy, int x, int y, Graphics g)
        {
            pen = new Pen(new SolidBrush(c));
            g.DrawLine(pen, new Point(ox, oy), new Point(x, y));
        }
    }
}
