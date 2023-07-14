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
            newContactsTip = new ToolTip(components);
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            colorDialog1 = new ColorDialog();
            btnSearch = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
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
            textBox1.Location = new Point(12, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 23);
            textBox1.TabIndex = 4;
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
            // ContactsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 426);
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
    }
}