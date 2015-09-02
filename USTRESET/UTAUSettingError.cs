using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace USTRESET
{
    public partial class UTAUSettingError : Form
    {
        public UTAUSettingError()
        {
            InitializeComponent();
        }

        private void UTAUSettingErrorConfirm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UTAUSettingError_Load(object sender, EventArgs e)
        {
            
        }
    }
}
