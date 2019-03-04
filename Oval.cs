using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Oval : DrawShape
    {
        override
        public void paintShape(int ox, int oy, int x, int y, Graphics g)
        {
            int toy = oy, tox = ox, ty = y, tx = x; //puts coordinates in temp variables
            pen = new Pen(new SolidBrush(c));
            if (x < ox) //switches x and oldx
            {
                tox = x;
                tx = ox;
            } if (y < oy) //switches y and oldy
            {
                toy = y;
                ty = oy;
            }
            g.DrawEllipse(pen, new Rectangle(new Point(tox, toy), new Size(Math.Abs(tx - tox), Math.Abs(ty - toy))));

        }
    }
}
