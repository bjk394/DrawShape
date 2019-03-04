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
        Bitmap bg = null, fg;
        Graphics fgg, bgg;
        //Graphics g = Paintpanel.CreateGraphics();
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
            cpanel.BackColor = Color.FromArgb(254, RedBar.Value, GreenBar.Value, BlueBar.Value); //changes the cpanel to show the selected color
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            cpanel.BackColor = Color.FromArgb(254, RedBar.Value, GreenBar.Value, BlueBar.Value); //changes the cpanel to show the selected color
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            cpanel.BackColor = Color.FromArgb(254, RedBar.Value, GreenBar.Value, BlueBar.Value); //changes the cpanel to show the selected color
        }
        private void Paintpanel_MouseDown(object sender, MouseEventArgs e)
        {
            oldx = e.X;         //initialize oldx on mouse pressed
            oldy = e.Y;         //initialize oldy on mouse pressed

            if (bg == null)
            {
                bg = new Bitmap(Paintpanel.Width, Paintpanel.Height);
                fg = new Bitmap(Paintpanel.Width, Paintpanel.Height);
            }
        }
        
        private void Paintpanel_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Paintpanel.CreateGraphics();
            
            if (e.Button == MouseButtons.Left)
            {
                fgg = Graphics.FromImage(fg);
                g.Clear(Color.White);
                if (type == 1) //creates new Rectangle and makes it the selected color
                {
                    s = new Rect();
                    s.c = cpanel.BackColor;     
                }
                else if (type == 2) //creates new oval and makes it the selected color
                {
                    s = new Oval();
                    s.c = cpanel.BackColor;
                }
                else if (type == 3)     //creates new line and makes it the selected color
                {
                    s = new Line();
                    s.c = cpanel.BackColor;
                }
                
                s.paintShape(oldx, oldy, e.X, e.Y, g);      
                g.DrawImage(fg, Paintpanel.Width, Paintpanel.Height);
                
            }
            
        }

        
        private void Paintpanel_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics fgg = Graphics.FromImage(fg);
            Graphics bgg = Graphics.FromImage(bg);
            bgg.DrawImage(fg, 0, 0);
            

            Paintpanel.CreateGraphics().DrawImage(bg, Paintpanel.Width, Paintpanel.Height);
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
