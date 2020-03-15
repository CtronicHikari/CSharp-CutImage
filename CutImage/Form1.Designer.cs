namespace CutImage
{
    partial class Background
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.labWidth = new System.Windows.Forms.Label();
            this.labHeight = new System.Windows.Forms.Label();
            this.labLength = new System.Windows.Forms.Label();
            this.TextBoxW = new System.Windows.Forms.TextBox();
            this.TextBoxH = new System.Windows.Forms.TextBox();
            this.TextBoxL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PictureBox.Location = new System.Drawing.Point(174, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(508, 721);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(370, 747);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(158, 70);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开图片";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(370, 1000);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 70);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "执行";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labWidth
            // 
            this.labWidth.AutoSize = true;
            this.labWidth.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWidth.Location = new System.Drawing.Point(46, 886);
            this.labWidth.Name = "labWidth";
            this.labWidth.Size = new System.Drawing.Size(96, 28);
            this.labWidth.TabIndex = 3;
            this.labWidth.Text = "Width:";
            // 
            // labHeight
            // 
            this.labHeight.AutoSize = true;
            this.labHeight.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHeight.Location = new System.Drawing.Point(312, 886);
            this.labHeight.Name = "labHeight";
            this.labHeight.Size = new System.Drawing.Size(110, 28);
            this.labHeight.TabIndex = 4;
            this.labHeight.Text = "Height:";
            // 
            // labLength
            // 
            this.labLength.AutoSize = true;
            this.labLength.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLength.Location = new System.Drawing.Point(586, 886);
            this.labLength.Name = "labLength";
            this.labLength.Size = new System.Drawing.Size(110, 28);
            this.labLength.TabIndex = 5;
            this.labLength.Text = "Length:";
            // 
            // TextBoxW
            // 
            this.TextBoxW.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxW.Location = new System.Drawing.Point(148, 886);
            this.TextBoxW.Name = "TextBoxW";
            this.TextBoxW.Size = new System.Drawing.Size(100, 35);
            this.TextBoxW.TabIndex = 6;
            this.TextBoxW.TextChanged += new System.EventHandler(this.TextBoxW_TextChanged);
            // 
            // TextBoxH
            // 
            this.TextBoxH.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxH.Location = new System.Drawing.Point(428, 886);
            this.TextBoxH.Name = "TextBoxH";
            this.TextBoxH.Size = new System.Drawing.Size(100, 35);
            this.TextBoxH.TabIndex = 7;
            this.TextBoxH.TextChanged += new System.EventHandler(this.TextBoxH_TextChanged);
            // 
            // TextBoxL
            // 
            this.TextBoxL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxL.Location = new System.Drawing.Point(702, 886);
            this.TextBoxL.Name = "TextBoxL";
            this.TextBoxL.Size = new System.Drawing.Size(100, 35);
            this.TextBoxL.TabIndex = 8;
            this.TextBoxL.TextChanged += new System.EventHandler(this.TextBoxL_TextChanged);
            // 
            // Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 1126);
            this.Controls.Add(this.TextBoxL);
            this.Controls.Add(this.TextBoxH);
            this.Controls.Add(this.TextBoxW);
            this.Controls.Add(this.labLength);
            this.Controls.Add(this.labHeight);
            this.Controls.Add(this.labWidth);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.PictureBox);
            this.Name = "Background";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labWidth;
        private System.Windows.Forms.Label labHeight;
        private System.Windows.Forms.Label labLength;
        private System.Windows.Forms.TextBox TextBoxW;
        private System.Windows.Forms.TextBox TextBoxH;
        private System.Windows.Forms.TextBox TextBoxL;
    }
}

