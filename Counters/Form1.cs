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
using System.Windows.Forms;
using System.Configuration;
using Microsoft.VisualBasic;

namespace Counters
{
    public partial class MainActivity : Form
    {
        //标识计时器是否开始计时
        private Boolean isStart = false;
        private string time = "0";
        //
        private FormBorder formBorder;
        private SynchronizationContext _syncContext = null;
        //
        private String systemSavePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "DDenry/Counters");
        private Boolean canMoveForm = false;
        private Point preLocation;

        private Boolean canSetSize = false;
        private Boolean canMax = false;
        private Boolean signal = false;

        private int themeType = 0;
        private int themeNum = 0;

        protected const int minWidth = 1022;
        protected const int minHeight = 670;

        //
        private Color selectedColor;
        private Color unSelectedColor;

        private Panel[] contentPanels;
        private static Button[] functionButtons;

        private enum SKINS
        {
            BLACK,
            BLUE,
            GREEN,
            YELLOW,
            LAVENDER,
            TOMATO
        };
        public MainActivity()
        {
            InitializeComponent();
            //
            InitData();
        }
        private void InitData()
        {
            //功能菜单按钮
            functionButtons = new Button[] { button_main };
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
                            //
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
                            //
                            else if (e.Location.X + this.Left == 0)
                            {
                                if (!canMax)
                                {
                                    canMax = true;
                                    //
                                    ShowOpeartePicture("LEFTHALF_FULLSCREEN");
                                }
                            }//
                            else if (this.Right - Screen.PrimaryScreen.Bounds.Width >= this.Width - e.Location.X - 1)
                            {
                                if (!canMax)
                                {
                                    canMax = true;
                                    //
                                    ShowOpeartePicture("RIGHTHALF_FULLSCREEN");
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
                    //显示边框
                    formBorder = new FormBorder(0);
                    formBorder.Show();
                    break;
                case "LEFTHALF_FULLSCREEN":
                    formBorder = new FormBorder(1);
                    formBorder.Show();
                    break;
                case "RIGHTHALF_FULLSCREEN":
                    formBorder = new FormBorder(2);
                    formBorder.Show();
                    break;
                case "HIDE":
                    //
                    if (formBorder != null)
                        formBorder.Close();
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
                //
                if (formBorder != null)
                    formBorder.Close();
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

        private int GetConfigTheme()
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == "THEME")
                {
                    return int.Parse(ConfigurationManager.AppSettings["THEME"]);
                }
            }
            return (int)SKINS.BLACK;
        }

        private void MainActivity_Load(object sender, EventArgs e)
        {
            themeNum = Enum.GetNames(new SKINS().GetType()).Length;
            ChangeThemeColor((SKINS)GetConfigTheme());
            //
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
                //
                if (listBox_matchRecords.Items.Count == 0) label_recordTitle.Text = "暂未检测到历史比赛记录！";
                else label_recordTitle.Text = "";
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

            //功能菜单按钮重置
            foreach (Button _button in functionButtons)
            {
                _button.BackColor = unSelectedColor;
            }

            button.BackColor = selectedColor;

            switch (button.Name)
            {
                //
                case "button_main":
                    panel_main.Visible = true;
                    //TODO:需要显示当前选项内容
                    //panel_menu_1_content.Visible = true;
                    break;
                //
                case "button_timer":
                    panel_timer.Visible = true;
                    panel_menu_1_content.Visible = false;
                    break;
                //
                case "button_record":
                    //
                    CheckExistedLogFile();
                    textBox_recordContent.Text = "";
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
                //
                if (listBox_matchRecords.Items.Count == 0) label_recordTitle.Text = "暂未检测到历史比赛记录！";
                else label_recordTitle.Text = "";
            }
        }

        //
        private void ChangeSkin(object sender, EventArgs e)
        {
            themeType++;
            ChangeThemeColor((SKINS)(themeType % themeNum));
        }
        //
        private void ChangeThemeColor(SKINS skins)
        {
            //
            themeType = (int)skins;
            selectedColor = ColorTranslator.FromHtml("#D7D7D7");
            Color color_first = ColorTranslator.FromHtml("#F5F5F7");
            Color color_second = ColorTranslator.FromHtml("#FAFAFA");
            Color color_third = ColorTranslator.FromHtml("#44AAF8");
            Color color_label_title = ColorTranslator.FromHtml("#0A0A0A");
            Color color_label_content = ColorTranslator.FromHtml("#000000");
            //
            switch (skins)
            {
                case SKINS.BLACK:
                    selectedColor = Color.White;
                    color_first = ColorTranslator.FromHtml("#191B1F");
                    color_second = ColorTranslator.FromHtml("#16181C");
                    color_third = ColorTranslator.FromHtml("#222225");
                    color_label_title = ColorTranslator.FromHtml("#969696");
                    color_label_content = ColorTranslator.FromHtml("#FFFFFF");
                    //
                    break;
                case SKINS.GREEN:
                    color_third = ColorTranslator.FromHtml("#3BBA7D");
                    break;
                //
                case SKINS.BLUE:
                    color_third = ColorTranslator.FromHtml("#44AAF8");
                    break;
                //
                case SKINS.YELLOW:
                    color_third = ColorTranslator.FromHtml("#E6B450");
                    break;
                //
                case SKINS.LAVENDER:
                    color_third = ColorTranslator.FromHtml("#E6E6FA");
                    break;
                //
                case SKINS.TOMATO:
                    color_third = ColorTranslator.FromHtml("#FF6347");
                    break;
                default:

                    break;
            }

            //
            unSelectedColor = color_first;
            this.BackColor = color_first;
            pictureBox_sizeEditable.BackColor = color_first;
            //Content_Left
            panel_menu_1.BackColor = color_first;
            panel_menu_2.BackColor = color_first;
            panel_menu_3.BackColor = color_first;
            panel_menu_4.BackColor = color_first;
            panel_menu_1_content.BackColor = color_first;
            panel_reset.BackColor = color_first;
            panel_record.BackColor = color_first;
            splitContainer_content.Panel1.BackColor = color_first;
            panel2.BackColor = color_first;
            panel3.BackColor = color_first;
            //第一项默认为选中
            button_main.BackColor = selectedColor;
            button_timer.BackColor = color_first;
            button_record.BackColor = color_first;
            button_reset.BackColor = color_first;

            //Content_Right
            splitContainer_content.Panel2.BackColor = color_second;

            panel1.BackColor = color_second;
            panel1.BackColor = color_second;
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
            button_skin.BackColor = color_third;
            button_sizable.BackColor = color_third;
            button_exit.BackColor = color_third;
            pictureBox_sizeEditable.BackColor = color_third;

            //label
            groupBox_main.ForeColor = color_label_title;
            groupBox_timer.ForeColor = color_label_title;
            groupBox_record.ForeColor = color_label_title;
            //label_teamRedName.ForeColor = color_label;
            //label_teamBlueName.ForeColor = color_label;
            label_playerRedName.ForeColor = color_label_content;
            label_playerBlueName.ForeColor = color_label_content;
            button_main.ForeColor = color_label_title;
            button_timer.ForeColor = color_label_title;
            button_record.ForeColor = color_label_title;
            button_reset.ForeColor = color_label_title;
            textBox_recordContent.ForeColor = color_label_content;
            label_recordTitle.ForeColor = color_label_content;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            //TODO:将主题写入appSetting
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["THEME"].Value = themeType.ToString();
            configuration.Save();
        }

        private void InputContent(object sender, EventArgs e)
        {
            if (isStart)
            {
                MessageBox.Show("计时器已经启动，不可操作！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Label label = sender as Label;
            string _name = "战队名称";
            switch (label.Name)
            {
                case "label_teamRedName":
                    _name = "红方战队名称";
                    break;
                case "label_playerRedName":
                    _name = "红方选手姓名";
                    break;
                case "label_teamBlueName":
                    _name = "蓝方战队名称";
                    break;
                case "label_playerBlueName":
                    _name = "蓝方选手姓名";
                    break;

            }
            string input = Interaction.InputBox("请输入" + _name, "系统消息", "输入为空则视为无效", -1, -1);
            //如果输入合法
            if (!string.IsNullOrEmpty(input))
            {
                label.Text = input;
            }
        }

        //
        private void PointOperator(object sender, EventArgs e)
        {
            if (!isStart)
            {
                MessageBox.Show("计时器暂未启动，不可操作！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Button button = sender as Button;
            int value;
            switch (button.Name)
            {
                //RedPoint +
                case "button_RedPAdd":
                    value = int.Parse(label_RedP.Text);
                    value++;
                    label_RedP.Text = value.ToString();
                    break;
                //RedPoint -
                case "button_RedPSub":
                    value = int.Parse(label_RedP.Text);
                    value--;
                    label_RedP.Text = value.ToString();
                    break;
                //RedAdvance +
                case "button_RedAAdd":
                    value = int.Parse(label_RedA.Text);
                    value++;
                    label_RedA.Text = value.ToString();
                    break;
                //RedAdvance -
                case "button_RedASub":
                    value = int.Parse(label_RedA.Text);
                    value--;
                    label_RedA.Text = value.ToString();
                    break;
                //RedWarninng +
                case "button_RedWAdd":
                    value = int.Parse(label_RedW.Text);
                    value++;
                    label_RedW.Text = value.ToString();
                    break;
                //RedWarning -
                case "button_RedWSub":
                    value = int.Parse(label_RedW.Text);
                    value--;
                    label_RedW.Text = value.ToString();
                    break;
                //BluePoint +
                case "button_BluePAdd":
                    value = int.Parse(label_BlueP.Text);
                    value++;
                    label_BlueP.Text = value.ToString();
                    break;
                //BluePoint -
                case "button_BluePSub":
                    value = int.Parse(label_BlueP.Text);
                    value--;
                    label_BlueP.Text = value.ToString();
                    break;
                //BlueAdvance +
                case "button_BlueAAdd":
                    value = int.Parse(label_BlueA.Text);
                    value++;
                    label_BlueA.Text = value.ToString();
                    break;
                //BlueAdvance -
                case "button_BlueASub":
                    value = int.Parse(label_BlueA.Text);
                    value--;
                    label_BlueA.Text = value.ToString();
                    break;
                //RedWarninng +
                case "button_BlueWAdd":
                    value = int.Parse(label_BlueW.Text);
                    value++;
                    label_BlueW.Text = value.ToString();
                    break;
                //RedWarning -
                case "button_BlueWSub":
                    value = int.Parse(label_BlueW.Text);
                    value--;
                    label_BlueW.Text = value.ToString();
                    break;
            }
        }

        private void ResetTool(object sender, EventArgs e)
        {
            if (isStart)
            {
                DialogResult result = MessageBox.Show("计时器仍在运行，是否要重置工具？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //
                if (result != DialogResult.Yes) return;
            }

            //
            time = "0";
            label_time.Text = "0";
            label_time.Visible = false;
            timer.Enabled = false;
            isStart = false;
            label_RedP.Text = "0";
            label_RedA.Text = "0";
            label_RedW.Text = "0";
            label_BlueP.Text = "0";
            label_BlueA.Text = "0";
            label_BlueW.Text = "0";
            label_teamRedName.Text = "战队名称";
            label_teamBlueName.Text = "战队名称";
            label_playerRedName.Text = "选手姓名";
            label_playerBlueName.Text = "选手姓名";
            //
            MessageBox.Show("工具已重置~", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //计时器操作
        private void TimerOperator(object sender, EventArgs e)
        {
            if (isStart)
            {
                DialogResult result = MessageBox.Show("计时器正在运行，是否要重置？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    time = "0";
                    timer.Enabled = false;
                    isStart = false;
                    label_time.Text = "0";
                    label_time.Visible = false;
                }
                else return;
            }
            time = Interaction.InputBox("请输入倒计时的时长", "系统消息", "时间格式为3:05/1:23:48", -1, -1);
            //TODO:处理用户的输入
            string[] values = time.Split(':');

            if (string.IsNullOrEmpty(time) || values.Length > 3) time = "0";

            int _time = 0;
            try
            {
                if (int.Parse(time) > 0)
                {
                    for (int i = values.Length - 1; i >= 0; i--)
                    {
                        _time += int.Parse(values[i]) * (int)Math.Pow(60, values.Length - 1 - i);
                    }
                    time = _time.ToString();
                    //
                    timer.Enabled = true;
                    isStart = true;
                    //
                    label_time.Visible = true;

                }
                else
                {
                    MessageBox.Show("时长格式错误，请重新输入！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("时长格式错误，请重新输入！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int _time = int.Parse(time) - 1;
            time = _time.ToString();

            if (_time < 4)
            {
                Console.Beep();
                if (_time == 0)
                {
                    //
                    timer.Enabled = false;
                    isStart = false;
                    //
                    label_time.Visible = false;
                    MessageBox.Show("时间到！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //
            label_time.Text = _time / 3600 + ":" + _time % 3600 / 60 + ":" + (_time % 60).ToString();
        }
    }
}