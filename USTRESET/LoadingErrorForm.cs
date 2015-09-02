using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace USTRESET
{
    public partial class LoadingFailed : Form
    {
        public LoadingFailed()
        {
            InitializeComponent();
        }

        private void LoadingErrorConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
