using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Counters
{
    public partial class FormBorder : Form
    {
        private int borderDistance = 8;
        private int type;

        public FormBorder(int type = -1)
        {
            InitializeComponent();
            //不在任务栏显示
            this.ShowInTaskbar = false;
            this.type = type;
        }

        private void FormBorder_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            //
            Point startPoint = new Point();
            switch (type)
            {
                //全屏
                case 0:
                    startPoint = new Point(borderDistance, borderDistance);
                    this.Width = width - borderDistance * 2;
                    this.Height = height - borderDistance * 2;
                    this.Location = startPoint;
                    break;
                //居左
                case 1:
                    startPoint = new Point(0, borderDistance);
                    this.Width = width/2 + borderDistance * 2;
                    this.Height = height - borderDistance * 2;
                    this.Location = startPoint;
                    break;
                //居右
                case 2:
                    startPoint = new Point(width/2 + borderDistance, borderDistance);
                    this.Width = width / 2 + borderDistance * 2;
                    this.Height = height - borderDistance * 2;
                    this.Location = startPoint;
                    break;
                //
                default:
                    this.Close();
                    break;
            }
        }
    }
}
