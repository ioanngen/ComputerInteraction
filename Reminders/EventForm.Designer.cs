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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            button1 = new Button();
            btnCancel = new Button();
            txevent = new TextBox();
            txdate = new TextBox();
            lbDate = new Label();
            lbEvent = new Label();
            toolTip1 = new ToolTip(components);
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(163, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Save";
            toolTip1.SetToolTip(button1, "Save the Event");
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
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(12, 149);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 41);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 202);
            Controls.Add(button6);
            Controls.Add(lbEvent);
            Controls.Add(lbDate);
            Controls.Add(txdate);
            Controls.Add(txevent);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private ToolTip toolTip1;
        private Button button6;
    }
}