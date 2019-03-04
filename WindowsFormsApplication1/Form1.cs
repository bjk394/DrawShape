using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        DrawShape s;
        Bitmap bg, fg;
        Color c;
        int type;
        int oldx;
        int oldy;


        public Form1()
        {
            
            InitializeComponent();
        }

        private void RectButton_Click(object sender, EventArgs e)
        {
            type = 1;

        }

        private void RedBar_Scroll(object sender, EventArgs e)
        {
            cpanel.BackColor = Color.FromArgb(254, RedBar.Value, GreenBar.Value, BlueBar.Value);
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            cpanel.BackColor = Color.FromArgb(254, RedBar.Value, GreenBar.Value, BlueBar.Value);
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            cpanel.BackColor = Color.FromArgb(254, RedBar.Value, GreenBar.Value, BlueBar.Value);
        }
        private void Paintpanel_MouseDown(object sender, MouseEventArgs e)
        {
            oldx = e.X;
            oldy = e.Y;

            if (bg == null)
            {
                bg = new Bitmap(Paintpanel.Width, Paintpanel.Height);
                fg = new Bitmap(Paintpanel.Width, Paintpanel.Height);
            }
        }
        private void Paintpanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Graphics fgg = Graphics.FromImage(fg);
                //s.pc = fgg;
                fgg.Clear(Color.White);
                fgg.DrawImage(bg, 0, 0);


                if (type == 1)
                {
                    s = new Rect();
                    s.c = cpanel.BackColor;
                }
                else if (type == 2)
                {
                    s = new Oval();
                    s.c = cpanel.BackColor;
                }
                else if (type == 3)
                {
                    s = new Line();
                    s.c = cpanel.BackColor;
                }

                s.paintShape(oldx, oldy, e.X, e.Y, fgg);
            }
        }
       
        
        private void Paintpanel_MouseUp(object sender, MouseEventArgs e)
        {
           
            
             //bgg = Graphics.FromImage(bg);
             //fgg = Graphics.FromImage(fg);
        }

        private void OvalButton_Click(object sender, EventArgs e)
        {
            type = 2;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            type = 3;
        }   

    }
}
