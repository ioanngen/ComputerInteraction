﻿namespace EmailClient
{
    partial class WebMail
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
            TreeNode treeNode1 = new TreeNode("Inbox");
            TreeNode treeNode2 = new TreeNode("Outbox");
            TreeNode treeNode3 = new TreeNode("Drafts");
            TreeNode treeNode4 = new TreeNode("Junk");
            TreeNode treeNode5 = new TreeNode("Bin");
            TreeNode treeNode6 = new TreeNode("All Mail");
            TreeNode treeNode7 = new TreeNode("Archive");
            TreeNode treeNode8 = new TreeNode("Notes");
            TreeNode treeNode9 = new TreeNode("Scheduled");
            TreeNode treeNode10 = new TreeNode("Folders", new TreeNode[] { treeNode7, treeNode8, treeNode9 });
            TreeNode treeNode11 = new TreeNode("Account", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode10 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebMail));
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newMailToolStripMenuItem = new ToolStripMenuItem();
            openMailToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteMailToolStripMenuItem = new ToolStripMenuItem();
            moveToBinToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            accountPropertiesToolStripMenuItem = new ToolStripMenuItem();
            inNewWindowToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            viewHelpToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            treeView1 = new TreeView();
            toolStrip1 = new ToolStrip();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            notifyIcon1 = new NotifyIcon(components);
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 452);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(946, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(946, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMailToolStripMenuItem, openMailToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newMailToolStripMenuItem
            // 
            newMailToolStripMenuItem.Name = "newMailToolStripMenuItem";
            newMailToolStripMenuItem.Size = new Size(180, 22);
            newMailToolStripMenuItem.Text = "New Mail";
            newMailToolStripMenuItem.Click += newMailToolStripMenuItem_Click;
            // 
            // openMailToolStripMenuItem
            // 
            openMailToolStripMenuItem.Name = "openMailToolStripMenuItem";
            openMailToolStripMenuItem.Size = new Size(180, 22);
            openMailToolStripMenuItem.Text = "Open Mail";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(180, 22);
            printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteMailToolStripMenuItem, moveToBinToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteMailToolStripMenuItem
            // 
            deleteMailToolStripMenuItem.Name = "deleteMailToolStripMenuItem";
            deleteMailToolStripMenuItem.Size = new Size(180, 22);
            deleteMailToolStripMenuItem.Text = "Delete Mail";
            // 
            // moveToBinToolStripMenuItem
            // 
            moveToBinToolStripMenuItem.Name = "moveToBinToolStripMenuItem";
            moveToBinToolStripMenuItem.Size = new Size(180, 22);
            moveToBinToolStripMenuItem.Text = "Move to Bin";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountPropertiesToolStripMenuItem, inNewWindowToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // accountPropertiesToolStripMenuItem
            // 
            accountPropertiesToolStripMenuItem.Name = "accountPropertiesToolStripMenuItem";
            accountPropertiesToolStripMenuItem.Size = new Size(180, 22);
            accountPropertiesToolStripMenuItem.Text = "Account Details";
            accountPropertiesToolStripMenuItem.Click += accountPropertiesToolStripMenuItem_Click;
            // 
            // inNewWindowToolStripMenuItem
            // 
            inNewWindowToolStripMenuItem.Name = "inNewWindowToolStripMenuItem";
            inNewWindowToolStripMenuItem.Size = new Size(180, 22);
            inNewWindowToolStripMenuItem.Text = "In New Window";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHelpToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            viewHelpToolStripMenuItem.Size = new Size(180, 22);
            viewHelpToolStripMenuItem.Text = "View Help";
            viewHelpToolStripMenuItem.Click += viewHelpToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0281677F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.9718323F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 512F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(treeView1, 0, 1);
            tableLayoutPanel1.Controls.Add(toolStrip1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 20);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(946, 435);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(3, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(154, 30);
            button1.TabIndex = 0;
            button1.Text = "New Mail";
            toolTip1.SetToolTip(button1, "Create New Mail");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(3, 36);
            treeView1.Margin = new Padding(3, 2, 3, 2);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Inbox";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Outbox";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Drafts";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Junk";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Bin";
            treeNode6.Name = "Node6";
            treeNode6.Text = "All Mail";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Archive";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Notes";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Scheduled";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Folders";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Account";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode11 });
            treeView1.Size = new Size(154, 397);
            treeView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(165, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(268, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel2.Controls.Add(button6, 0, 4);
            tableLayoutPanel2.Location = new Point(436, 36);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 266F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new Size(507, 397);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Cc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 90);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Message:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(89, 2);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(89, 32);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(415, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(89, 62);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(415, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(89, 92);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(415, 262);
            textBox4.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.100605F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.899395F));
            tableLayoutPanel3.Controls.Add(button3, 1, 0);
            tableLayoutPanel3.Controls.Add(button2, 0, 0);
            tableLayoutPanel3.Location = new Point(89, 358);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(415, 37);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(210, 2);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 26);
            button3.TabIndex = 1;
            button3.Text = "Forward";
            toolTip1.SetToolTip(button3, "Forward This Mail");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(122, 2);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 26);
            button2.TabIndex = 0;
            button2.Text = "Reply";
            toolTip1.SetToolTip(button2, "Reply To This Mail");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(3, 358);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(38, 37);
            button6.TabIndex = 9;
            toolTip1.SetToolTip(button6, "Help");
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(168, 36);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(256, 397);
            dataGridView1.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // WebMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 474);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "WebMail";
            Text = "WebMail";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TreeView treeView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Button button2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newMailToolStripMenuItem;
        private ToolStripMenuItem openMailToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteMailToolStripMenuItem;
        private ToolStripMenuItem moveToBinToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem accountPropertiesToolStripMenuItem;
        private ToolStripMenuItem inNewWindowToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStrip toolStrip1;
        private NotifyIcon notifyIcon1;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
        private Button button6;
    }
}