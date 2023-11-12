namespace PasswordManager.Desktop.Views
{
    partial class Registration
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
            label1 = new Label();
            textBox_username = new TextBox();
            textBox_email = new TextBox();
            label2 = new Label();
            textBox_fn = new TextBox();
            label3 = new Label();
            textBox_ln = new TextBox();
            label4 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            textBox_pw = new TextBox();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(148, 50);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(100, 23);
            textBox_username.TabIndex = 1;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(148, 110);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(100, 23);
            textBox_email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 113);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // textBox_fn
            // 
            textBox_fn.Location = new Point(148, 139);
            textBox_fn.Name = "textBox_fn";
            textBox_fn.Size = new Size(100, 23);
            textBox_fn.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 142);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Firstname";
            // 
            // textBox_ln
            // 
            textBox_ln.Location = new Point(148, 168);
            textBox_ln.Name = "textBox_ln";
            textBox_ln.Size = new Size(100, 23);
            textBox_ln.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 171);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Lastname";
            // 
            // button1
            // 
            button1.Location = new Point(104, 209);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 8;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(394, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backToolStripMenuItem, exitToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(99, 22);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(99, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // textBox_pw
            // 
            textBox_pw.Location = new Point(148, 79);
            textBox_pw.Name = "textBox_pw";
            textBox_pw.PasswordChar = '*';
            textBox_pw.Size = new Size(100, 23);
            textBox_pw.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 82);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 319);
            Controls.Add(textBox_pw);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox_ln);
            Controls.Add(label4);
            Controls.Add(textBox_fn);
            Controls.Add(label3);
            Controls.Add(textBox_email);
            Controls.Add(label2);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_username;
        private TextBox textBox_email;
        private Label label2;
        private TextBox textBox_fn;
        private Label label3;
        private TextBox textBox_ln;
        private Label label4;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox textBox_pw;
        private Label label5;
    }
}