namespace MultipleCommTools
{
    partial class ProgressBarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBarForm));
            this.ToolprogressBar = new System.Windows.Forms.ProgressBar();
            this.btnCancelProgressBar = new System.Windows.Forms.Button();
            this.labelProgressStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToolprogressBar
            // 
            this.ToolprogressBar.Location = new System.Drawing.Point(12, 34);
            this.ToolprogressBar.Name = "ToolprogressBar";
            this.ToolprogressBar.Size = new System.Drawing.Size(405, 23);
            this.ToolprogressBar.TabIndex = 0;
            // 
            // btnCancelProgressBar
            // 
            this.btnCancelProgressBar.Location = new System.Drawing.Point(342, 74);
            this.btnCancelProgressBar.Name = "btnCancelProgressBar";
            this.btnCancelProgressBar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProgressBar.TabIndex = 1;
            this.btnCancelProgressBar.Text = "取消";
            this.btnCancelProgressBar.UseVisualStyleBackColor = true;
            this.btnCancelProgressBar.Click += new System.EventHandler(this.btnCancelProgressBar_Click);
            // 
            // labelProgressStatus
            // 
            this.labelProgressStatus.AutoSize = true;
            this.labelProgressStatus.Location = new System.Drawing.Point(12, 9);
            this.labelProgressStatus.Name = "labelProgressStatus";
            this.labelProgressStatus.Size = new System.Drawing.Size(41, 12);
            this.labelProgressStatus.TabIndex = 2;
            this.labelProgressStatus.Text = "Status";
            // 
            // ToolProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 109);
            this.Controls.Add(this.labelProgressStatus);
            this.Controls.Add(this.btnCancelProgressBar);
            this.Controls.Add(this.ToolprogressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "进度条对话框";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToolProgressForm_FormClosed);
            this.Load += new System.EventHandler(this.ToolProgressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ToolprogressBar;
        private System.Windows.Forms.Button btnCancelProgressBar;
        private System.Windows.Forms.Label labelProgressStatus;
    }
}