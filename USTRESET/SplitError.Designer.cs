namespace USTRESET
{
    partial class SplitError
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
            this.UTAUSettingErrorConfirm = new System.Windows.Forms.Button();
            this.USTSettingError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UTAUSettingErrorConfirm
            // 
            this.UTAUSettingErrorConfirm.Location = new System.Drawing.Point(111, 60);
            this.UTAUSettingErrorConfirm.Name = "UTAUSettingErrorConfirm";
            this.UTAUSettingErrorConfirm.Size = new System.Drawing.Size(75, 23);
            this.UTAUSettingErrorConfirm.TabIndex = 5;
            this.UTAUSettingErrorConfirm.Text = "确定";
            this.UTAUSettingErrorConfirm.UseVisualStyleBackColor = true;
            this.UTAUSettingErrorConfirm.Click += new System.EventHandler(this.UTAUSettingErrorConfirm_Click);
            // 
            // USTSettingError
            // 
            this.USTSettingError.AutoSize = true;
            this.USTSettingError.Location = new System.Drawing.Point(51, 22);
            this.USTSettingError.Name = "USTSettingError";
            this.USTSettingError.Size = new System.Drawing.Size(217, 30);
            this.USTSettingError.TabIndex = 4;
            this.USTSettingError.Text = "处理失败（超出音符数限制）\r\n请不要勾选“切割长休止符”。";
            this.USTSettingError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SplitError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 104);
            this.Controls.Add(this.UTAUSettingErrorConfirm);
            this.Controls.Add(this.USTSettingError);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplitError";
            this.Text = "错误";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UTAUSettingErrorConfirm;
        private System.Windows.Forms.Label USTSettingError;
    }
}