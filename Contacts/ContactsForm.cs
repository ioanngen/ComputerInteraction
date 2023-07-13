namespace Contacts
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newform = new AddContact();
            newform.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {

        }
    }
}