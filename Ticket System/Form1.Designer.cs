namespace Ticket_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cancelCurrentOrderToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            kmTxtBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            travelClassCb = new ComboBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label6 = new Label();
            euroTxtBox = new TextBox();
            label7 = new Label();
            summary = new ListBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 0;
            label1.Text = " Railway Ticket Ordering";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(826, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, cancelCurrentOrderToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(230, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // cancelCurrentOrderToolStripMenuItem
            // 
            cancelCurrentOrderToolStripMenuItem.Name = "cancelCurrentOrderToolStripMenuItem";
            cancelCurrentOrderToolStripMenuItem.Size = new Size(230, 26);
            cancelCurrentOrderToolStripMenuItem.Text = "Cancel Current Order";
            cancelCurrentOrderToolStripMenuItem.Click += cancelCurrentOrderToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 101);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "distance traveled";
            // 
            // kmTxtBox
            // 
            kmTxtBox.Location = new Point(199, 98);
            kmTxtBox.Name = "kmTxtBox";
            kmTxtBox.Size = new Size(125, 27);
            kmTxtBox.TabIndex = 3;
            kmTxtBox.TextChanged += kmTxtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 101);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 4;
            label3.Text = "Km";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 144);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 5;
            label4.Text = "Travel class";
            // 
            // travelClassCb
            // 
            travelClassCb.FormattingEnabled = true;
            travelClassCb.Items.AddRange(new object[] { "First class", "Business class", "Economy class" });
            travelClassCb.Location = new Point(199, 144);
            travelClassCb.Name = "travelClassCb";
            travelClassCb.Size = new Size(125, 28);
            travelClassCb.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 201);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 7;
            label5.Text = "Reduces fares";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(199, 201);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(147, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Senior Ticket 50%";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(199, 231);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(133, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kids Ticket 20%";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(199, 261);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(153, 24);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "No travel Discount";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 326);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Payable";
            // 
            // euroTxtBox
            // 
            euroTxtBox.Location = new Point(199, 323);
            euroTxtBox.Name = "euroTxtBox";
            euroTxtBox.Size = new Size(125, 27);
            euroTxtBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 326);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 13;
            label7.Text = "€";
            // 
            // summary
            // 
            summary.FormattingEnabled = true;
            summary.ItemHeight = 20;
            summary.Location = new Point(482, 101);
            summary.Name = "summary";
            summary.Size = new Size(295, 224);
            summary.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(583, 350);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 15;
            button1.Text = "Ready";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 484);
            Controls.Add(button1);
            Controls.Add(summary);
            Controls.Add(label7);
            Controls.Add(euroTxtBox);
            Controls.Add(label6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(travelClassCb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(kmTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Ticket System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private Label label2;
        private TextBox kmTxtBox;
        private Label label3;
        private Label label4;
        private ComboBox travelClassCb;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
        private TextBox euroTxtBox;
        private Label label7;
        private ListBox summary;
        private Button button1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem cancelCurrentOrderToolStripMenuItem;
    }
}