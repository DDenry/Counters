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
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.pictureBox_sizeEditable = new System.Windows.Forms.PictureBox();
            this.splitContainer_content = new System.Windows.Forms.SplitContainer();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sizeEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_content)).BeginInit();
            this.splitContainer_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1022, 80);
            this.panel_title.TabIndex = 0;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_bottom.Controls.Add(this.pictureBox_sizeEditable);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 610);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1022, 60);
            this.panel_bottom.TabIndex = 0;
            // 
            // pictureBox_sizeEditable
            // 
            this.pictureBox_sizeEditable.Image = global::Counters.Properties.Resources.size1;
            this.pictureBox_sizeEditable.Location = new System.Drawing.Point(1002, 40);
            this.pictureBox_sizeEditable.Name = "pictureBox_sizeEditable";
            this.pictureBox_sizeEditable.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_sizeEditable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sizeEditable.TabIndex = 0;
            this.pictureBox_sizeEditable.TabStop = false;
            this.pictureBox_sizeEditable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
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
            this.splitContainer_content.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Panel1MinSize = 120;
            // 
            // splitContainer_content.Panel2
            // 
            this.splitContainer_content.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Panel2MinSize = 898;
            this.splitContainer_content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_content.Size = new System.Drawing.Size(1022, 530);
            this.splitContainer_content.SplitterDistance = 120;
            this.splitContainer_content.TabIndex = 2;
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 670);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer_content);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainActivity";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sizeEditable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_content)).EndInit();
            this.splitContainer_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.SplitContainer splitContainer_content;
        private System.Windows.Forms.PictureBox pictureBox_sizeEditable;
    }
}

