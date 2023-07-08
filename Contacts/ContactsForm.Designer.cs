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
            search_contact_button = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // search_contact_button
            // 
            search_contact_button.Location = new Point(12, 12);
            search_contact_button.Name = "search_contact_button";
            search_contact_button.Size = new Size(118, 29);
            search_contact_button.TabIndex = 0;
            search_contact_button.Text = "Search Contact";
            search_contact_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(136, 378);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 2;
            button2.Text = "New Contact";
            button2.UseVisualStyleBackColor = true;
            // 
            // ContactsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(search_contact_button);
            Name = "ContactsForm";
            Text = "Contacts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button search_contact_button;
        private TextBox textBox1;
        private Button button2;
    }
}