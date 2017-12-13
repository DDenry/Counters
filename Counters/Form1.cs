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


        public MainActivity()
        {
            InitializeComponent();
        }

        //
        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            //按下鼠标左键
            if (e.Button.Equals(MouseButtons.Left))
            {
                canMoveForm = true;
                preLocation = e.Location;
            }
            //按下鼠标右键
            else if (e.Button.Equals(MouseButtons.Right)) {

            }
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            //移动窗体
            if (e.Button.Equals(MouseButtons.Left) && canMoveForm)
            {
                Point newPosition = new Point(e.Location.X - preLocation.X, e.Location.Y - preLocation.Y);
                this.Location += new Size(newPosition);
            }
            //
            if (pictureBox_sizeEditable.Width - e.Location.X <= 5 && pictureBox_sizeEditable.Height - e.Location.Y <= 5)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else this.Cursor = Cursors.Arrow;
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            //抬起鼠标左键
            if (e.Button.Equals(MouseButtons.Left))
            {
                canMoveForm = false;
            }
        }
        //

    }
}
