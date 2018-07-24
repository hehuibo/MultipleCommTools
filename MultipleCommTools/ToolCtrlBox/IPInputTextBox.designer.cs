namespace MultipleCommTools.ToolCtrlBox
{
    partial class IPInputTextBox
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.txt_1 = new ToolCtrlBox.ControlText();
            this.txt_2 = new ToolCtrlBox.ControlText();
            this.txt_3 = new ToolCtrlBox.ControlText();
            this.txt_4 = new ToolCtrlBox.ControlText();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(34, 6);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(11, 12);
            this.lb1.TabIndex = 0;
            this.lb1.Text = ".";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(72, 6);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(11, 12);
            this.lb2.TabIndex = 1;
            this.lb2.Text = ".";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(113, 6);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(11, 12);
            this.lb3.TabIndex = 0;
            this.lb3.Text = ".";
            // 
            // txt_1
            // 
            this.txt_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_1.Location = new System.Drawing.Point(5, 4);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(25, 14);
            this.txt_1.TabIndex = 1;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_2
            // 
            this.txt_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_2.Location = new System.Drawing.Point(45, 4);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(25, 14);
            this.txt_2.TabIndex = 2;
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_3
            // 
            this.txt_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_3.Location = new System.Drawing.Point(84, 4);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(25, 14);
            this.txt_3.TabIndex = 3;
            this.txt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_3.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_4
            // 
            this.txt_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_4.Location = new System.Drawing.Point(126, 4);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(25, 14);
            this.txt_4.TabIndex = 4;
            this.txt_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_4.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // IPInputTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_4);
            this.Name = "IPInputTextBox";
            this.Size = new System.Drawing.Size(154, 24);
            this.Load += new System.EventHandler(this.IPInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private ToolCtrlBox.ControlText txt_1;
        private ToolCtrlBox.ControlText txt_2;
        private ToolCtrlBox.ControlText txt_3;
        private ToolCtrlBox.ControlText txt_4;
    }
}
