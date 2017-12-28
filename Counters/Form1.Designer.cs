namespace Counters
{
    partial class MainActivity
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_controllButton = new System.Windows.Forms.Panel();
            this.button_sizable = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.pictureBox_sizeEditable = new System.Windows.Forms.PictureBox();
            this.splitContainer_content = new System.Windows.Forms.SplitContainer();
            this.panel_menu_3 = new System.Windows.Forms.Panel();
            this.button_record = new System.Windows.Forms.Button();
            this.panel_menu_2 = new System.Windows.Forms.Panel();
            this.button_timer = new System.Windows.Forms.Button();
            this.panel_menu_1_content = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_reset = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_menu_1 = new System.Windows.Forms.Panel();
            this.button_main = new System.Windows.Forms.Button();
            this.panel_record = new System.Windows.Forms.Panel();
            this.groupBox_record = new System.Windows.Forms.GroupBox();
            this.textBox_recordContent = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listBox_matchRecords = new System.Windows.Forms.ListBox();
            this.label_recordTitle = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label_playerBlueName = new System.Windows.Forms.Label();
            this.label_teamBlueName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_playerRedName = new System.Windows.Forms.Label();
            this.label_teamRedName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_timer = new System.Windows.Forms.Panel();
            this.groupBox_timer = new System.Windows.Forms.GroupBox();
            this.pictureBox_opeartePicture = new System.Windows.Forms.PictureBox();
            this.button_skin = new System.Windows.Forms.Button();
            this.panel_title.SuspendLayout();
            this.panel_controllButton.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sizeEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_content)).BeginInit();
            this.splitContainer_content.Panel1.SuspendLayout();
            this.splitContainer_content.Panel2.SuspendLayout();
            this.splitContainer_content.SuspendLayout();
            this.panel_menu_3.SuspendLayout();
            this.panel_menu_2.SuspendLayout();
            this.panel_menu_1_content.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_reset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_menu_1.SuspendLayout();
            this.panel_record.SuspendLayout();
            this.groupBox_record.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.groupBox_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_opeartePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_title.Controls.Add(this.panel_controllButton);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1095, 50);
            this.panel_title.TabIndex = 0;
            this.panel_title.SizeChanged += new System.EventHandler(this.FormSizeChanged);
            this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
            this.panel_title.DoubleClick += new System.EventHandler(this.MinOrMaxForm);
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // panel_controllButton
            // 
            this.panel_controllButton.Controls.Add(this.button_skin);
            this.panel_controllButton.Controls.Add(this.button_sizable);
            this.panel_controllButton.Controls.Add(this.button_exit);
            this.panel_controllButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_controllButton.Location = new System.Drawing.Point(855, 0);
            this.panel_controllButton.Name = "panel_controllButton";
            this.panel_controllButton.Size = new System.Drawing.Size(240, 50);
            this.panel_controllButton.TabIndex = 0;
            // 
            // button_sizable
            // 
            this.button_sizable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sizable.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_sizable.FlatAppearance.BorderSize = 0;
            this.button_sizable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sizable.Font = new System.Drawing.Font("宋体", 20F);
            this.button_sizable.ForeColor = System.Drawing.Color.DimGray;
            this.button_sizable.Location = new System.Drawing.Point(80, 0);
            this.button_sizable.Name = "button_sizable";
            this.button_sizable.Size = new System.Drawing.Size(80, 50);
            this.button_sizable.TabIndex = 1;
            this.button_sizable.Text = "口";
            this.button_sizable.UseVisualStyleBackColor = false;
            this.button_sizable.Click += new System.EventHandler(this.MinOrMaxForm);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("宋体", 20F);
            this.button_exit.ForeColor = System.Drawing.Color.DimGray;
            this.button_exit.Location = new System.Drawing.Point(160, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(80, 50);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "×";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.ExitForm);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_bottom.Controls.Add(this.pictureBox_sizeEditable);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 570);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1095, 100);
            this.panel_bottom.TabIndex = 0;
            // 
            // pictureBox_sizeEditable
            // 
            this.pictureBox_sizeEditable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_sizeEditable.Image = global::Counters.Properties.Resources.size;
            this.pictureBox_sizeEditable.Location = new System.Drawing.Point(1075, 80);
            this.pictureBox_sizeEditable.Name = "pictureBox_sizeEditable";
            this.pictureBox_sizeEditable.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_sizeEditable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sizeEditable.TabIndex = 0;
            this.pictureBox_sizeEditable.TabStop = false;
            this.pictureBox_sizeEditable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.pictureBox_sizeEditable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.pictureBox_sizeEditable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // splitContainer_content
            // 
            this.splitContainer_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_content.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_content.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer_content.Location = new System.Drawing.Point(0, 50);
            this.splitContainer_content.Name = "splitContainer_content";
            // 
            // splitContainer_content.Panel1
            // 
            this.splitContainer_content.Panel1.AutoScroll = true;
            this.splitContainer_content.Panel1.Controls.Add(this.panel_menu_3);
            this.splitContainer_content.Panel1.Controls.Add(this.panel_menu_2);
            this.splitContainer_content.Panel1.Controls.Add(this.panel_menu_1_content);
            this.splitContainer_content.Panel1.Controls.Add(this.panel_menu_1);
            this.splitContainer_content.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Panel1MinSize = 150;
            // 
            // splitContainer_content.Panel2
            // 
            this.splitContainer_content.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer_content.Panel2.Controls.Add(this.panel_record);
            this.splitContainer_content.Panel2.Controls.Add(this.panel_main);
            this.splitContainer_content.Panel2.Controls.Add(this.panel_timer);
            this.splitContainer_content.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Panel2MinSize = 868;
            this.splitContainer_content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Size = new System.Drawing.Size(1095, 520);
            this.splitContainer_content.SplitterDistance = 223;
            this.splitContainer_content.TabIndex = 2;
            // 
            // panel_menu_3
            // 
            this.panel_menu_3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_menu_3.Controls.Add(this.button_record);
            this.panel_menu_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu_3.Location = new System.Drawing.Point(0, 225);
            this.panel_menu_3.Name = "panel_menu_3";
            this.panel_menu_3.Size = new System.Drawing.Size(223, 45);
            this.panel_menu_3.TabIndex = 3;
            // 
            // button_record
            // 
            this.button_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_record.FlatAppearance.BorderSize = 0;
            this.button_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_record.Location = new System.Drawing.Point(0, 0);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(223, 45);
            this.button_record.TabIndex = 1;
            this.button_record.Text = "查纪录";
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.FoldingMenuOperate);
            // 
            // panel_menu_2
            // 
            this.panel_menu_2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_menu_2.Controls.Add(this.button_timer);
            this.panel_menu_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu_2.Location = new System.Drawing.Point(0, 180);
            this.panel_menu_2.Name = "panel_menu_2";
            this.panel_menu_2.Size = new System.Drawing.Size(223, 45);
            this.panel_menu_2.TabIndex = 2;
            // 
            // button_timer
            // 
            this.button_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_timer.FlatAppearance.BorderSize = 0;
            this.button_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_timer.Location = new System.Drawing.Point(0, 0);
            this.button_timer.Name = "button_timer";
            this.button_timer.Size = new System.Drawing.Size(223, 45);
            this.button_timer.TabIndex = 0;
            this.button_timer.Text = "计时器";
            this.button_timer.UseVisualStyleBackColor = true;
            this.button_timer.Click += new System.EventHandler(this.FoldingMenuOperate);
            // 
            // panel_menu_1_content
            // 
            this.panel_menu_1_content.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_menu_1_content.Controls.Add(this.panel3);
            this.panel_menu_1_content.Controls.Add(this.panel2);
            this.panel_menu_1_content.Controls.Add(this.panel_reset);
            this.panel_menu_1_content.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu_1_content.Location = new System.Drawing.Point(0, 45);
            this.panel_menu_1_content.Name = "panel_menu_1_content";
            this.panel_menu_1_content.Size = new System.Drawing.Size(223, 135);
            this.panel_menu_1_content.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 45);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(51, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 45);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(51, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_reset
            // 
            this.panel_reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_reset.Controls.Add(this.label1);
            this.panel_reset.Controls.Add(this.pictureBox1);
            this.panel_reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_reset.Location = new System.Drawing.Point(0, 0);
            this.panel_reset.Name = "panel_reset";
            this.panel_reset.Size = new System.Drawing.Size(223, 45);
            this.panel_reset.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_menu_1
            // 
            this.panel_menu_1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_menu_1.Controls.Add(this.button_main);
            this.panel_menu_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu_1.Location = new System.Drawing.Point(0, 0);
            this.panel_menu_1.Name = "panel_menu_1";
            this.panel_menu_1.Size = new System.Drawing.Size(223, 45);
            this.panel_menu_1.TabIndex = 0;
            this.panel_menu_1.Click += new System.EventHandler(this.FoldingMenuOperate);
            // 
            // button_main
            // 
            this.button_main.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_main.FlatAppearance.BorderSize = 0;
            this.button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button_main.Location = new System.Drawing.Point(0, 0);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(223, 45);
            this.button_main.TabIndex = 0;
            this.button_main.Text = "记分牌";
            this.button_main.UseVisualStyleBackColor = false;
            this.button_main.Click += new System.EventHandler(this.FoldingMenuOperate);
            // 
            // panel_record
            // 
            this.panel_record.Controls.Add(this.groupBox_record);
            this.panel_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_record.Location = new System.Drawing.Point(0, 0);
            this.panel_record.Name = "panel_record";
            this.panel_record.Size = new System.Drawing.Size(868, 520);
            this.panel_record.TabIndex = 0;
            this.panel_record.Visible = false;
            this.panel_record.VisibleChanged += new System.EventHandler(this.PanelVisibleChanged);
            // 
            // groupBox_record
            // 
            this.groupBox_record.Controls.Add(this.textBox_recordContent);
            this.groupBox_record.Controls.Add(this.splitter1);
            this.groupBox_record.Controls.Add(this.listBox_matchRecords);
            this.groupBox_record.Controls.Add(this.label_recordTitle);
            this.groupBox_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_record.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_record.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_record.Location = new System.Drawing.Point(0, 0);
            this.groupBox_record.Name = "groupBox_record";
            this.groupBox_record.Size = new System.Drawing.Size(868, 520);
            this.groupBox_record.TabIndex = 0;
            this.groupBox_record.TabStop = false;
            this.groupBox_record.Text = "RECORD";
            // 
            // textBox_recordContent
            // 
            this.textBox_recordContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_recordContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_recordContent.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox_recordContent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_recordContent.Location = new System.Drawing.Point(313, 61);
            this.textBox_recordContent.Multiline = true;
            this.textBox_recordContent.Name = "textBox_recordContent";
            this.textBox_recordContent.ReadOnly = true;
            this.textBox_recordContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recordContent.Size = new System.Drawing.Size(552, 456);
            this.textBox_recordContent.TabIndex = 1;
            this.textBox_recordContent.WordWrap = false;
            // 
            // splitter1
            // 
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(303, 61);
            this.splitter1.MaximumSize = new System.Drawing.Size(20, 0);
            this.splitter1.MinimumSize = new System.Drawing.Size(10, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 456);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // listBox_matchRecords
            // 
            this.listBox_matchRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_matchRecords.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_matchRecords.Font = new System.Drawing.Font("宋体", 18F);
            this.listBox_matchRecords.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listBox_matchRecords.FormattingEnabled = true;
            this.listBox_matchRecords.ItemHeight = 24;
            this.listBox_matchRecords.Location = new System.Drawing.Point(3, 61);
            this.listBox_matchRecords.Name = "listBox_matchRecords";
            this.listBox_matchRecords.Size = new System.Drawing.Size(300, 456);
            this.listBox_matchRecords.TabIndex = 0;
            this.listBox_matchRecords.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
            this.listBox_matchRecords.DoubleClick += new System.EventHandler(this.DeleteSelectedRecord);
            // 
            // label_recordTitle
            // 
            this.label_recordTitle.AutoSize = true;
            this.label_recordTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_recordTitle.Location = new System.Drawing.Point(3, 34);
            this.label_recordTitle.Name = "label_recordTitle";
            this.label_recordTitle.Size = new System.Drawing.Size(0, 27);
            this.label_recordTitle.TabIndex = 2;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.groupBox_main);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(868, 520);
            this.panel_main.TabIndex = 2;
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.panel1);
            this.groupBox_main.Controls.Add(this.label5);
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_main.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(868, 520);
            this.groupBox_main.TabIndex = 0;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "MAIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 459);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(862, 350);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(862, 175);
            this.panel6.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label_playerBlueName);
            this.panel8.Controls.Add(this.label_teamBlueName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 175);
            this.panel8.TabIndex = 1;
            // 
            // label_playerBlueName
            // 
            this.label_playerBlueName.AutoSize = true;
            this.label_playerBlueName.Font = new System.Drawing.Font("宋体", 24F);
            this.label_playerBlueName.Location = new System.Drawing.Point(105, 119);
            this.label_playerBlueName.Name = "label_playerBlueName";
            this.label_playerBlueName.Size = new System.Drawing.Size(143, 33);
            this.label_playerBlueName.TabIndex = 2;
            this.label_playerBlueName.Text = "选手姓名";
            // 
            // label_teamBlueName
            // 
            this.label_teamBlueName.AutoSize = true;
            this.label_teamBlueName.Font = new System.Drawing.Font("楷体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_teamBlueName.ForeColor = System.Drawing.Color.Blue;
            this.label_teamBlueName.Location = new System.Drawing.Point(13, 47);
            this.label_teamBlueName.Name = "label_teamBlueName";
            this.label_teamBlueName.Size = new System.Drawing.Size(181, 40);
            this.label_teamBlueName.TabIndex = 1;
            this.label_teamBlueName.Text = "战队名称";
            this.label_teamBlueName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(862, 175);
            this.panel5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_playerRedName);
            this.panel7.Controls.Add(this.label_teamRedName);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 175);
            this.panel7.TabIndex = 0;
            // 
            // label_playerRedName
            // 
            this.label_playerRedName.AutoSize = true;
            this.label_playerRedName.Font = new System.Drawing.Font("宋体", 24F);
            this.label_playerRedName.Location = new System.Drawing.Point(105, 107);
            this.label_playerRedName.Name = "label_playerRedName";
            this.label_playerRedName.Size = new System.Drawing.Size(143, 33);
            this.label_playerRedName.TabIndex = 1;
            this.label_playerRedName.Text = "选手姓名";
            // 
            // label_teamRedName
            // 
            this.label_teamRedName.AutoSize = true;
            this.label_teamRedName.Font = new System.Drawing.Font("楷体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_teamRedName.ForeColor = System.Drawing.Color.Red;
            this.label_teamRedName.Location = new System.Drawing.Point(13, 32);
            this.label_teamRedName.Name = "label_teamRedName";
            this.label_teamRedName.Size = new System.Drawing.Size(181, 40);
            this.label_teamRedName.TabIndex = 0;
            this.label_teamRedName.Text = "战队名称";
            this.label_teamRedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("宋体", 18F);
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 0;
            // 
            // panel_timer
            // 
            this.panel_timer.Controls.Add(this.groupBox_timer);
            this.panel_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timer.Location = new System.Drawing.Point(0, 0);
            this.panel_timer.Name = "panel_timer";
            this.panel_timer.Size = new System.Drawing.Size(868, 520);
            this.panel_timer.TabIndex = 1;
            this.panel_timer.Visible = false;
            // 
            // groupBox_timer
            // 
            this.groupBox_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_timer.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_timer.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_timer.Location = new System.Drawing.Point(0, 0);
            this.groupBox_timer.Name = "groupBox_timer";
            this.groupBox_timer.Size = new System.Drawing.Size(868, 520);
            this.groupBox_timer.TabIndex = 0;
            this.groupBox_timer.TabStop = false;
            this.groupBox_timer.Text = "TIMER";
            // 
            // pictureBox_opeartePicture
            // 
            this.pictureBox_opeartePicture.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_opeartePicture.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_opeartePicture.Name = "pictureBox_opeartePicture";
            this.pictureBox_opeartePicture.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_opeartePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_opeartePicture.TabIndex = 1;
            this.pictureBox_opeartePicture.TabStop = false;
            this.pictureBox_opeartePicture.Visible = false;
            // 
            // button_skin
            // 
            this.button_skin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_skin.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_skin.FlatAppearance.BorderSize = 0;
            this.button_skin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_skin.Font = new System.Drawing.Font("宋体", 20F);
            this.button_skin.ForeColor = System.Drawing.Color.DimGray;
            this.button_skin.Location = new System.Drawing.Point(0, 0);
            this.button_skin.Name = "button_skin";
            this.button_skin.Size = new System.Drawing.Size(80, 50);
            this.button_skin.TabIndex = 2;
            this.button_skin.Text = "a";
            this.button_skin.UseVisualStyleBackColor = false;
            this.button_skin.Click += new System.EventHandler(this.ChangeSkin);
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 670);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox_opeartePicture);
            this.Controls.Add(this.splitContainer_content);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainActivity";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.MainActivity_Load);
            this.Resize += new System.EventHandler(this.FormResize);
            this.panel_title.ResumeLayout(false);
            this.panel_controllButton.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sizeEditable)).EndInit();
            this.splitContainer_content.Panel1.ResumeLayout(false);
            this.splitContainer_content.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_content)).EndInit();
            this.splitContainer_content.ResumeLayout(false);
            this.panel_menu_3.ResumeLayout(false);
            this.panel_menu_2.ResumeLayout(false);
            this.panel_menu_1_content.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_reset.ResumeLayout(false);
            this.panel_reset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_menu_1.ResumeLayout(false);
            this.panel_record.ResumeLayout(false);
            this.groupBox_record.ResumeLayout(false);
            this.groupBox_record.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel_timer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_opeartePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.SplitContainer splitContainer_content;
        private System.Windows.Forms.PictureBox pictureBox_sizeEditable;
        private System.Windows.Forms.Panel panel_controllButton;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_sizable;
        private System.Windows.Forms.PictureBox pictureBox_opeartePicture;
        private System.Windows.Forms.Panel panel_menu_1;
        private System.Windows.Forms.Panel panel_menu_1_content;
        private System.Windows.Forms.Panel panel_reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_menu_3;
        private System.Windows.Forms.Panel panel_menu_2;
        private System.Windows.Forms.Panel panel_record;
        private System.Windows.Forms.GroupBox groupBox_record;
        private System.Windows.Forms.ListBox listBox_matchRecords;
        private System.Windows.Forms.TextBox textBox_recordContent;
        private System.Windows.Forms.Label label_recordTitle;
        private System.Windows.Forms.Panel panel_timer;
        private System.Windows.Forms.GroupBox groupBox_timer;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label_playerBlueName;
        private System.Windows.Forms.Label label_teamBlueName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_playerRedName;
        private System.Windows.Forms.Label label_teamRedName;
        private System.Windows.Forms.Button button_record;
        private System.Windows.Forms.Button button_timer;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button_skin;
    }
}

