namespace USTRESET
{
    partial class LoadingFailed
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
            this.LoadingError = new System.Windows.Forms.Label();
            this.LoadingErrorConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadingError
            // 
            this.LoadingError.AutoSize = true;
            this.LoadingError.Location = new System.Drawing.Point(112, 31);
            this.LoadingError.Name = "LoadingError";
            this.LoadingError.Size = new System.Drawing.Size(106, 15);
            this.LoadingError.TabIndex = 0;
            this.LoadingError.Text = "UST载入失败。";
            this.LoadingError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoadingErrorConfirm
            // 
            this.LoadingErrorConfirm.Location = new System.Drawing.Point(121, 61);
            this.LoadingErrorConfirm.Name = "LoadingErrorConfirm";
            this.LoadingErrorConfirm.Size = new System.Drawing.Size(75, 23);
            this.LoadingErrorConfirm.TabIndex = 1;
            this.LoadingErrorConfirm.Text = "确定";
            this.LoadingErrorConfirm.UseVisualStyleBackColor = true;
            this.LoadingErrorConfirm.Click += new System.EventHandler(this.LoadingErrorConfirm_Click);
            // 
            // LoadingFailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 104);
            this.Controls.Add(this.LoadingErrorConfirm);
            this.Controls.Add(this.LoadingError);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingFailed";
            this.Text = "错误";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoadingError;
        private System.Windows.Forms.Button LoadingErrorConfirm;

    }
}