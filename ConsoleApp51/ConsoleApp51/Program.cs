﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp51
{
    class Program:Form
    {
        Random r;
        public Program()
        {
            r = new Random();
            this.MouseWheel += new MouseEventHandler(OnjMouseWheel);
            this.MouseDown += new MouseEventHandler(OnjMousedown);
        }

        private void OnjMousedown(object sender, MouseEventArgs e)
        {
          if(e.Button == MouseButtons.Left)
            {
                this.MaximizeBox = true;
                this.MinimizeBox = true;
                Color oldcolor = this.BackColor;
                this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }
          if(e.Button == MouseButtons.Right)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
        }

        private void OnjMouseWheel(object sender, MouseEventArgs e)
        {
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1);
            Console.WriteLine("Opacity: {0}", this.Opacity);
        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
