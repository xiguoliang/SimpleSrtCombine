namespace SrtCombine
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filePath1 = new System.Windows.Forms.TextBox();
            this.filePath2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SavePath = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.uf1 = new System.Windows.Forms.RadioButton();
            this.uf2 = new System.Windows.Forms.RadioButton();
            this.uf3 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "字幕文件1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "字幕文件2";
            // 
            // filePath1
            // 
            this.filePath1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filePath1.Location = new System.Drawing.Point(175, 7);
            this.filePath1.Name = "filePath1";
            this.filePath1.Size = new System.Drawing.Size(365, 31);
            this.filePath1.TabIndex = 0;
            // 
            // filePath2
            // 
            this.filePath2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filePath2.Location = new System.Drawing.Point(175, 52);
            this.filePath2.Name = "filePath2";
            this.filePath2.Size = new System.Drawing.Size(365, 31);
            this.filePath2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(547, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(547, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(111, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(429, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "合并并保存(删除源文件)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "保存文件";
            // 
            // SavePath
            // 
            this.SavePath.Enabled = false;
            this.SavePath.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SavePath.Location = new System.Drawing.Point(175, 89);
            this.SavePath.Name = "SavePath";
            this.SavePath.Size = new System.Drawing.Size(365, 31);
            this.SavePath.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveButton.Location = new System.Drawing.Point(547, 89);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 31);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "浏览";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // uf1
            // 
            this.uf1.AutoSize = true;
            this.uf1.Checked = true;
            this.uf1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uf1.Location = new System.Drawing.Point(8, 8);
            this.uf1.Name = "uf1";
            this.uf1.Size = new System.Drawing.Size(132, 23);
            this.uf1.TabIndex = 5;
            this.uf1.TabStop = true;
            this.uf1.Text = "使用文件名1";
            this.uf1.UseVisualStyleBackColor = true;
            this.uf1.CheckedChanged += new System.EventHandler(this.uf1_CheckedChanged);
            // 
            // uf2
            // 
            this.uf2.AutoSize = true;
            this.uf2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uf2.Location = new System.Drawing.Point(146, 8);
            this.uf2.Name = "uf2";
            this.uf2.Size = new System.Drawing.Size(132, 23);
            this.uf2.TabIndex = 5;
            this.uf2.Text = "使用文件名2";
            this.uf2.UseVisualStyleBackColor = true;
            this.uf2.CheckedChanged += new System.EventHandler(this.uf2_CheckedChanged);
            // 
            // uf3
            // 
            this.uf3.AutoSize = true;
            this.uf3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uf3.Location = new System.Drawing.Point(8, 37);
            this.uf3.Name = "uf3";
            this.uf3.Size = new System.Drawing.Size(141, 23);
            this.uf3.TabIndex = 5;
            this.uf3.Text = "使用新文件名";
            this.uf3.UseVisualStyleBackColor = true;
            this.uf3.CheckedChanged += new System.EventHandler(this.uf3_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uf1);
            this.flowLayoutPanel1.Controls.Add(this.uf2);
            this.flowLayoutPanel1.Controls.Add(this.uf3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 143);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 78);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(155, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 23);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "保留源文件";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(117, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "该工具能对两个字幕文件进行合并,适合制作双语字幕\r\n个人用于将谷歌翻译的字幕文件和原始英文字幕合并\r\n在检测上不是很严谨,慎用(文件行数一样,应该不会出现问题)\r" +
    "\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SavePath);
            this.Controls.Add(this.filePath2);
            this.Controls.Add(this.filePath1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "双语字幕合并";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filePath1;
        private System.Windows.Forms.TextBox filePath2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SavePath;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RadioButton uf1;
        private System.Windows.Forms.RadioButton uf2;
        private System.Windows.Forms.RadioButton uf3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
    }
}

