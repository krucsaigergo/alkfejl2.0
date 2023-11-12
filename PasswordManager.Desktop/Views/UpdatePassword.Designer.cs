namespace PasswordManager.Desktop.Views
{
    partial class UpdatePassword
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
            label2 = new Label();
            label3 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxWebsite = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 81);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Website";
            // 
            // textBox1
            // 
            textBoxUsername.Location = new Point(128, 46);
            textBoxUsername.Name = "textBox1";
            textBoxUsername.Size = new Size(100, 23);
            textBoxUsername.TabIndex = 3;
            // 
            // textBox2
            // 
            textBoxPassword.Location = new Point(128, 78);
            textBoxPassword.Name = "textBox2";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // textBox3
            // 
            textBoxWebsite.Location = new Point(128, 112);
            textBoxWebsite.Name = "textBox3";
            textBoxWebsite.Size = new Size(100, 23);
            textBoxWebsite.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(211, 165);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 165);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 7;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_click;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 216);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxWebsite);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdatePassword";
            Text = "UpdatePassword";
            Load += UpdatePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxWebsite;
        private Button button1;
        private Button button2;
    }
}