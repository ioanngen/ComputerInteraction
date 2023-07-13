namespace Reminders
{
    partial class EventForm
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
            button1 = new Button();
            btnCancel = new Button();
            txevent = new TextBox();
            txdate = new TextBox();
            lbDate = new Label();
            lbEvent = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(163, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(82, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // txevent
            // 
            txevent.Location = new Point(12, 96);
            txevent.Name = "txevent";
            txevent.Size = new Size(226, 23);
            txevent.TabIndex = 2;
            txevent.TextChanged += txevent_TextChanged;
            // 
            // txdate
            // 
            txdate.Location = new Point(12, 33);
            txdate.Name = "txdate";
            txdate.Size = new Size(226, 23);
            txdate.TabIndex = 3;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(12, 15);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(51, 18);
            lbDate.TabIndex = 4;
            lbDate.Text = "Date:";
            // 
            // lbEvent
            // 
            lbEvent.AutoSize = true;
            lbEvent.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEvent.Location = new Point(12, 75);
            lbEvent.Name = "lbEvent";
            lbEvent.Size = new Size(59, 18);
            lbEvent.TabIndex = 5;
            lbEvent.Text = "Event:";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 202);
            Controls.Add(lbEvent);
            Controls.Add(lbDate);
            Controls.Add(txdate);
            Controls.Add(txevent);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            Name = "EventForm";
            Text = "Event Form";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCancel;
        private TextBox txevent;
        private TextBox txdate;
        private Label lbDate;
        private Label lbEvent;
    }
}