namespace 更新存盘
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSyncOut = new System.Windows.Forms.Button();
            this.btnSyncIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSyncOut
            // 
            this.btnSyncOut.AccessibleDescription = "";
            this.btnSyncOut.Enabled = false;
            this.btnSyncOut.Location = new System.Drawing.Point(22, 16);
            this.btnSyncOut.Name = "btnSyncOut";
            this.btnSyncOut.Size = new System.Drawing.Size(102, 52);
            this.btnSyncOut.TabIndex = 1;
            this.btnSyncOut.Tag = "";
            this.btnSyncOut.Text = "同步U盘";
            this.btnSyncOut.UseVisualStyleBackColor = true;
            this.btnSyncOut.Click += new System.EventHandler(this.btnSyncOut_Click);
            // 
            // btnSyncIn
            // 
            this.btnSyncIn.Location = new System.Drawing.Point(158, 16);
            this.btnSyncIn.Name = "btnSyncIn";
            this.btnSyncIn.Size = new System.Drawing.Size(102, 52);
            this.btnSyncIn.TabIndex = 2;
            this.btnSyncIn.Text = "同步电脑";
            this.btnSyncIn.UseVisualStyleBackColor = true;
            this.btnSyncIn.Click += new System.EventHandler(this.btnSyncIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 88);
            this.Controls.Add(this.btnSyncIn);
            this.Controls.Add(this.btnSyncOut);
            this.MaximumSize = new System.Drawing.Size(297, 126);
            this.MinimumSize = new System.Drawing.Size(297, 126);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "存盘更新";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSyncOut;
        private System.Windows.Forms.Button btnSyncIn;
    }
}

