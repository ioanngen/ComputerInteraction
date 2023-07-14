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

        private void ContactsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newform = new AddContact();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string message = "This is where you can store, delete or edit your contacts. \n\n " +
                                   "The first textbox is for search in contacts list, in the second " +
                                   "textbox are displayed the contacts. You can select one and edit " +
                                   "it or delete it. You can also add new contact by clicking the right icon. ";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}