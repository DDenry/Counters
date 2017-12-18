using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counters
{
    public partial class MainActivity : Form
    {
        private Boolean canMoveForm = false;
        private Point preLocation;

        private Boolean canSetSize = false;

        protected const int minWidth = 1022;
        protected const int minHeight = 670;

        public MainActivity()
        {
            InitializeComponent();
        }

        //
        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "Panel":
                    //按下鼠标左键
                    if (e.Button.Equals(MouseButtons.Left))
                    {
                        canMoveForm = true;
                        preLocation = e.Location;
                    }
                    //按下鼠标右键
                    else if (e.Button.Equals(MouseButtons.Right))
                    {

                    }
                    break;
                case "PictureBox":
                    if (e.Button.Equals(MouseButtons.Left))
                    {
                        canSetSize = true;
                    }
                    break;
            }

        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "Panel":
                    //移动窗体
                    if (e.Button.Equals(MouseButtons.Left) && canMoveForm)
                    {
                        if (this.WindowState != FormWindowState.Normal)
                        {
                            float X = preLocation.X * 1.0f / this.Width;
                            float Y = preLocation.Y * 1.0f / this.Height;
                            this.WindowState = FormWindowState.Normal;
                            this.Location = (Point)new Size((int)(e.Location.X - this.Width * X), (int)(e.Location.Y - this.Height * Y));
                            preLocation = e.Location;
                        }
                        else
                        {
                            Point newPosition = new Point(e.Location.X - preLocation.X, e.Location.Y - preLocation.Y);
                            this.Location += new Size(newPosition);
                        }
                    }
                    break;
                case "PictureBox":
                    //
                    if (pictureBox_sizeEditable.Width - e.Location.X <= 10 && pictureBox_sizeEditable.Height - e.Location.Y <= 10)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        if (canSetSize)
                            //调整窗体大小
                            ResizeForm();
                    }
                    else if (canSetSize)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        //
                        ResizeForm();
                    }
                    else this.Cursor = Cursors.Arrow;
                    break;
            }
        }
        //
        private void ResizeForm()
        {
            this.Cursor = Cursors.SizeNWSE;
            //
            if (MousePosition.X - this.Left < minWidth) this.Width = minWidth;
            else this.Width = MousePosition.X - this.Left;
            if (MousePosition.Y - this.Top < minHeight) this.Height = minHeight;
            else this.Height = MousePosition.Y - this.Top;
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            canMoveForm = false;
            canSetSize = false;

            this.Cursor = Cursors.Arrow;
        }

        private void FormResize(object sender, EventArgs e)
        {
            //
            if (splitContainer_content.Panel1.Width > this.Width - splitContainer_content.Panel2.Width - splitContainer_content.SplitterWidth)
            {
                splitContainer_content.SplitterDistance = this.Width - splitContainer_content.Panel2.Width - splitContainer_content.SplitterWidth;
            }
        }

        private void ExitForm(object sender, EventArgs e)
        {
            //
            this.Close();
        }

        private void MinOrMaxForm(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized ? this.WindowState = FormWindowState.Normal : this.WindowState = FormWindowState.Maximized);
        }
    }
}
