using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void phoneNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string message = "Press the speaker button if you want open speaker mode. " +
                                   "Press on red phone button if you want to end the call.  " +
                                   "Press the microphone button if you want to mute the call. ";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
