namespace Contacts
{
    partial class ContactsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            newContactsTip = new ToolTip(components);
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            colorDialog1 = new ColorDialog();
            btnSearch = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Properties.Resources.new_user1;
            btnAdd.Location = new Point(226, 335);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 79);
            btnAdd.TabIndex = 0;
            newContactsTip.SetToolTip(btnAdd, "Add Contact");
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(145, 335);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 79);
            btnEdit.TabIndex = 1;
            newContactsTip.SetToolTip(btnEdit, "Edit Contact");
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(56, 335);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 79);
            btnDelete.TabIndex = 2;
            newContactsTip.SetToolTip(btnDelete, "Delete Selected Contact");
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.magnifier;
            btnSearch.Location = new Point(304, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(45, 43);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(12, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Search...";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 80);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 249);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(119, 18);
            label1.TabIndex = 6;
            label1.Text = "Contacts List:";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(308, 373);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(42, 41);
            button3.TabIndex = 26;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ContactsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 426);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ContactsForm";
            Text = "Contacts";
            Load += ContactsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip newContactsTip;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ColorDialog colorDialog1;
        private Button btnSearch;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button3;
    }
}