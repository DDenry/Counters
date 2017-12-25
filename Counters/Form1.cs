using Counters.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counters
{
    public partial class MainActivity : Form
    {
        private SynchronizationContext _syncContext = null;
        //
        private String systemSavePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "DDenry/Counters");
        private Boolean canMoveForm = false;
        private Point preLocation;

        private Boolean canSetSize = false;
        private Boolean canMax = false;
        private Boolean signal = false;

        protected const int minWidth = 1022;
        protected const int minHeight = 670;

        private Panel[] contentPanels;

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
                            signal = true;
                        }
                        else
                        {
                            if (signal)
                            {
                                preLocation = e.Location;
                                signal = false;
                            }
                            Point newPosition = new Point(e.Location.X - preLocation.X, e.Location.Y - preLocation.Y);
                            this.Location += new Size(newPosition);

                            //鼠标拖拽窗口至顶端时显示全屏效果
                            if (e.Location.Y + this.Top == 0)
                            {
                                if (!canMax)
                                {
                                    canMax = true;
                                    //TODO:显示全屏标志
                                    ShowOpeartePicture("FULLSCREEN");
                                }
                            }
                            else if (this.Top >= 0 && canMax)
                            {
                                canMax = false;
                                //
                                ShowOpeartePicture("HIDE");
                            }
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
        private void ShowOpeartePicture(String name)
        {
            switch (name)
            {
                case "FULLSCREEN":

                    pictureBox_opeartePicture.Image = Resources.fullScreen;
                    pictureBox_opeartePicture.Size = new Size(this.Height / 2, this.Height / 2);
                    pictureBox_opeartePicture.Location = new Point((this.Width - pictureBox_opeartePicture.Width) / 2, (this.Height - pictureBox_opeartePicture.Height) / 2);
                    pictureBox_opeartePicture.Visible = true;
                    break;
                case "HIDE":
                    pictureBox_opeartePicture.Visible = false;
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

            if (this.Top < 0)
            {
                this.Top = 0;
            }
            //
            if (canMax)
            {
                this.WindowState = FormWindowState.Maximized;
                canMax = false;
                pictureBox_opeartePicture.Visible = false;
            }
        }

        private void FormResize(object sender, EventArgs e)
        {
            //
            if (splitContainer_content.Panel1.Width > this.Width - splitContainer_content.Panel2.Width - splitContainer_content.SplitterWidth)
            {
                splitContainer_content.SplitterDistance = this.Width - splitContainer_content.Panel2.Width - splitContainer_content.SplitterWidth;
            }
        }

        //退出窗体应用
        private void ExitForm(object sender, EventArgs e)
        {
            //
            this.Close();
        }

        //放大或者缩小Form
        private void MinOrMaxForm(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized ? this.WindowState = FormWindowState.Normal : this.WindowState = FormWindowState.Maximized);
        }

        private void MainActivity_Load(object sender, EventArgs e)
        {
            ChangeThemeColor();
            _syncContext = SynchronizationContext.Current;
            //C:\Users\DDenry\AppData\Roaming
            Console.WriteLine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData));
            //创建应用暂存路径
            if (!Directory.Exists(systemSavePath))
            {
                Directory.CreateDirectory(systemSavePath);
            }

            //加载已存在的记录
            CheckExistedLogFile();
        }
        //
        private List<FileInfo> CheckExistedLogFile()
        {
            List<FileInfo> existedLogFileList = new List<FileInfo>();
            //
            foreach (String path in Directory.GetFiles(systemSavePath))
            {
                FileInfo item = new FileInfo(path);
                if (item.Extension.Equals(".txt"))
                {
                    existedLogFileList.Add(item);
                }
            }

            //TODO:加载已存在的记录
            _syncContext.Post((o) =>
            {
                listBox_matchRecords.Items.Clear();
                foreach (FileInfo item in existedLogFileList)
                {
                    listBox_matchRecords.Items.Add(Path.GetFileNameWithoutExtension(item.FullName));
                }

            }, "");

            return existedLogFileList;
        }

        //窗体大小改变
        private void FormSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) pictureBox_sizeEditable.Visible = false;
            else pictureBox_sizeEditable.Visible = true;
        }

        //
        private void FoldingMenuOperate(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                //
                case "button_main":
                    panel_main.Visible = true;
                    panel_menu_1_content.Visible = true;
                    break;
                //
                case "button_timer":
                    panel_timer.Visible = true;
                    panel_menu_1_content.Visible = false;
                    break;
                //
                case "button_record":
                    panel_record.Visible = true;
                    panel_menu_1_content.Visible = false;
                    break;
            }
            //
            foreach (Panel content in contentPanels)
                if (!content.Name.Equals(button.Name.Replace("button", "panel"))) content.Visible = false;
        }

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {
            //
            contentPanels = new Panel[] { panel_main, panel_timer, panel_record };
        }

        //
        private void ShowFileContent(object sender)
        {
            ListBox listBox = sender as ListBox;
            //
            if (listBox.SelectedIndex != -1)
            {
                String item = listBox_matchRecords.SelectedItem.ToString();
                //
                textBox_recordContent.Text = "正在读取，请稍后~";
                //读取文件内容并显示
                _syncContext.Post((o) =>
                {
                    textBox_recordContent.Text = File.ReadAllText(Path.Combine(systemSavePath, item + ".txt"));
                }, "");
            }
            else textBox_recordContent.Text = "";
        }

        private void PanelVisibleChanged(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            switch (panel.Name)
            {
                case "panel_timer":
                    break;
                case "panel_record":
                    listBox_matchRecords.SelectedIndex = -1;
                    break;

            }
        }

        private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            switch (listBox.Name)
            {
                case "listBox_matchRecords":
                    //
                    ShowFileContent(listBox);
                    break;
            }
        }

        private void DeleteSelectedRecord(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("该操作将删除所选记录，是否继续？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                //
                File.Delete(Path.Combine(systemSavePath, listBox_matchRecords.SelectedItem.ToString() + ".txt"));
                //删除列表所选项
                listBox_matchRecords.Items.RemoveAt(listBox_matchRecords.SelectedIndex);
            }
        }

        //
        private void ChangeThemeColor()
        {
            Color color_first = ColorTranslator.FromHtml("#191B1F");
            Color color_second = ColorTranslator.FromHtml("#16181C");
            Color color_third = ColorTranslator.FromHtml("#222225");
            Color color_label = ColorTranslator.FromHtml("#FFFFFF");
            //
            this.BackColor = color_first;

            pictureBox_sizeEditable.BackColor = color_first;
            //Content_Left
            panel_menu_1.BackColor = color_first;
            panel_menu_2.BackColor = color_first;
            panel_menu_3.BackColor = color_first;
            panel_menu_1_content.BackColor = color_first;
            panel_reset.BackColor = color_first;
            panel_record.BackColor = color_first;
            splitContainer_content.Panel1.BackColor = color_first;
            panel2.BackColor = color_first;
            panel3.BackColor = color_first;
            button_main.BackColor = color_first;
            button_timer.BackColor = color_first;
            button_record.BackColor = color_first;

            //Content_Right
            splitContainer_content.Panel2.BackColor = color_second;

            panel1.BackColor = color_second;
            panel4.BackColor = color_second;
            panel5.BackColor = color_second;
            panel6.BackColor = color_second;
            panel7.BackColor = color_second;
            panel8.BackColor = color_second;

            panel_main.BackColor = color_second;
            panel_timer.BackColor = color_second;
            panel_record.BackColor = color_second;

            groupBox_main.BackColor = color_second;
            groupBox_timer.BackColor = color_second;
            groupBox_record.BackColor = color_second;

            listBox_matchRecords.BackColor = color_second;
            textBox_recordContent.BackColor = color_second;


            //Top&Bottom
            panel_bottom.BackColor = color_third;
            panel_title.BackColor = color_third;
            panel_controllButton.BackColor = color_third;
            button_sizable.BackColor = color_third;
            button_exit.BackColor = color_third;
            pictureBox_sizeEditable.BackColor = color_third;

            //label
            groupBox_main.ForeColor = color_label;
            groupBox_timer.ForeColor = color_label;
            groupBox_record.ForeColor = color_label;
            //label_teamRedName.ForeColor = color_label;
            //label_teamBlueName.ForeColor = color_label;
            label_playerRedName.ForeColor = color_label;
            label_playerBlueName.ForeColor = color_label;
            button_main.ForeColor = color_label;
            button_timer.ForeColor = color_label;
            button_record.ForeColor = color_label;
            textBox_recordContent.ForeColor = color_label;
        }
    }
}