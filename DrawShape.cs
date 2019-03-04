using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    abstract class DrawShape
    {
        
  
       //public int oldx;
       //public int oldy;
       public int x;
       public int y;
       public Color c;

       public Pen pen;

        public abstract void paintShape(int ox, int oy, int x, int y, Graphics g);
    }
}
