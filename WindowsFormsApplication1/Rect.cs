using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Rect : DrawShape
    {
        

        override
        public void paintShape(int ox, int oy, int x, int y, Graphics g)
        {
            pen = new Pen(new SolidBrush(c));
            this.oldx = oldx;
            this.oldy = oldy;
            this.x = x;
            this.y = y;
            //width = x - oldx;
           // height = y - oldy;
            g.DrawRectangle(pen, new Rectangle(new Point(oldx, oldy), new Size(Math.Abs(x - oldx), Math.Abs(y - oldy))));

        }
    }
}
