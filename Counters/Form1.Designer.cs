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
            this.treeView_menu = new System.Windows.Forms.TreeView();
            this.pictureBox_opeartePicture = new System.Windows.Forms.PictureBox();
            this.panel_title.SuspendLayout();
            this.panel_controllButton.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sizeEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_content)).BeginInit();
            this.splitContainer_content.Panel1.SuspendLayout();
            this.splitContainer_content.SuspendLayout();
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
            this.panel_title.Size = new System.Drawing.Size(1095, 80);
            this.panel_title.TabIndex = 0;
            this.panel_title.DoubleClick += new System.EventHandler(this.MinOrMaxForm);
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // panel_controllButton
            // 
            this.panel_controllButton.Controls.Add(this.button_sizable);
            this.panel_controllButton.Controls.Add(this.button_exit);
            this.panel_controllButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_controllButton.Location = new System.Drawing.Point(935, 0);
            this.panel_controllButton.Name = "panel_controllButton";
            this.panel_controllButton.Size = new System.Drawing.Size(160, 80);
            this.panel_controllButton.TabIndex = 0;
            // 
            // button_sizable
            // 
            this.button_sizable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sizable.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_sizable.FlatAppearance.BorderSize = 0;
            this.button_sizable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sizable.Font = new System.Drawing.Font("宋体", 20F);
            this.button_sizable.ForeColor = System.Drawing.Color.DimGray;
            this.button_sizable.Location = new System.Drawing.Point(0, 0);
            this.button_sizable.Name = "button_sizable";
            this.button_sizable.Size = new System.Drawing.Size(80, 80);
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
            this.button_exit.Location = new System.Drawing.Point(80, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(80, 80);
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
            this.panel_bottom.Location = new System.Drawing.Point(0, 610);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1095, 60);
            this.panel_bottom.TabIndex = 0;
            // 
            // pictureBox_sizeEditable
            // 
            this.pictureBox_sizeEditable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_sizeEditable.Image = global::Counters.Properties.Resources.size;
            this.pictureBox_sizeEditable.Location = new System.Drawing.Point(1075, 40);
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
            this.splitContainer_content.Location = new System.Drawing.Point(0, 80);
            this.splitContainer_content.Name = "splitContainer_content";
            // 
            // splitContainer_content.Panel1
            // 
            this.splitContainer_content.Panel1.Controls.Add(this.treeView_menu);
            this.splitContainer_content.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Panel1MinSize = 150;
            // 
            // splitContainer_content.Panel2
            // 
            this.splitContainer_content.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer_content.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Panel2MinSize = 868;
            this.splitContainer_content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Size = new System.Drawing.Size(1095, 530);
            this.splitContainer_content.SplitterDistance = 223;
            this.splitContainer_content.TabIndex = 2;
            // 
            // treeView_menu
            // 
            this.treeView_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_menu.Location = new System.Drawing.Point(0, 0);
            this.treeView_menu.Name = "treeView_menu";
            this.treeView_menu.Size = new System.Drawing.Size(223, 530);
            this.treeView_menu.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.MainActivity_Load);
            this.Resize += new System.EventHandler(this.FormResize);
            this.panel_title.ResumeLayout(false);
            this.panel_controllButton.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sizeEditable)).EndInit();
            this.splitContainer_content.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_content)).EndInit();
            this.splitContainer_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_opeartePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.SplitContainer splitContainer_content;
        private System.Windows.Forms.PictureBox pictureBox_sizeEditable;
        private System.Windows.Forms.TreeView treeView_menu;
        private System.Windows.Forms.Panel panel_controllButton;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_sizable;
        private System.Windows.Forms.PictureBox pictureBox_opeartePicture;
    }
}

