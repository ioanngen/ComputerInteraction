using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallsAndMessages
{
    public partial class PhoneCallPopup : Form
    {
        public PhoneCallPopup()
        {
            InitializeComponent();
        }

        private void pictureBoxEndCall_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
