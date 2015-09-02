namespace USTRESET
{
    partial class UTAUSettingError
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
            this.UTAUSettingErrorConfirm.Location = new System.Drawing.Point(117, 56);
            this.UTAUSettingErrorConfirm.Name = "UTAUSettingErrorConfirm";
            this.UTAUSettingErrorConfirm.Size = new System.Drawing.Size(75, 23);
            this.UTAUSettingErrorConfirm.TabIndex = 3;
            this.UTAUSettingErrorConfirm.Text = "确定";
            this.UTAUSettingErrorConfirm.UseVisualStyleBackColor = true;
            this.UTAUSettingErrorConfirm.Click += new System.EventHandler(this.UTAUSettingErrorConfirm_Click);
            // 
            // USTSettingError
            // 
            this.USTSettingError.AutoSize = true;
            this.USTSettingError.Location = new System.Drawing.Point(28, 26);
            this.USTSettingError.Name = "USTSettingError";
            this.USTSettingError.Size = new System.Drawing.Size(279, 15);
            this.USTSettingError.TabIndex = 2;
            this.USTSettingError.Text = "请将本程序置于UTAU程序根目录下执行。";
            this.USTSettingError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UTAUSettingError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 104);
            this.Controls.Add(this.UTAUSettingErrorConfirm);
            this.Controls.Add(this.USTSettingError);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UTAUSettingError";
            this.Text = "错误";
            this.Load += new System.EventHandler(this.UTAUSettingError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UTAUSettingErrorConfirm;
        private System.Windows.Forms.Label USTSettingError;
    }
}