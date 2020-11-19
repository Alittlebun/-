namespace 骰子
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGO.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGO.Location = new System.Drawing.Point(239, 160);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(247, 158);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
    }
}

