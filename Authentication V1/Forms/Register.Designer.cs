namespace Authentication_V1.Forms
{
    partial class Register
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
            idtxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passtxtbox = new TextBox();
            label3 = new Label();
            emailtxtbox = new TextBox();
            label4 = new Label();
            nametxtbox = new TextBox();
            label5 = new Label();
            usercombobox = new ComboBox();
            backbtn = new Button();
            registerbtn = new Button();
            SuspendLayout();
            // 
            // idtxtbox
            // 
            idtxtbox.Location = new Point(288, 91);
            idtxtbox.Name = "idtxtbox";
            idtxtbox.Size = new Size(265, 27);
            idtxtbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 94);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Institutional ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 139);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passtxtbox
            // 
            passtxtbox.Location = new Point(288, 136);
            passtxtbox.Name = "passtxtbox";
            passtxtbox.PasswordChar = '*';
            passtxtbox.Size = new Size(265, 27);
            passtxtbox.TabIndex = 2;
            passtxtbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 189);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // emailtxtbox
            // 
            emailtxtbox.Location = new Point(288, 186);
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.Size = new Size(265, 27);
            emailtxtbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 49);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // nametxtbox
            // 
            nametxtbox.Location = new Point(288, 46);
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(265, 27);
            nametxtbox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 241);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "User Type";
            // 
            // usercombobox
            // 
            usercombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            usercombobox.FormattingEnabled = true;
            usercombobox.Items.AddRange(new object[] { "Admin", "Student", "Professor", "Staff", "Security " });
            usercombobox.Location = new Point(288, 238);
            usercombobox.Name = "usercombobox";
            usercombobox.Size = new Size(265, 28);
            usercombobox.TabIndex = 9;
            // 
            // backbtn
            // 
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Location = new Point(213, 314);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(123, 57);
            backbtn.TabIndex = 10;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // registerbtn
            // 
            registerbtn.FlatStyle = FlatStyle.Flat;
            registerbtn.Location = new Point(368, 314);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(123, 57);
            registerbtn.TabIndex = 11;
            registerbtn.Text = "Register User";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(registerbtn);
            Controls.Add(backbtn);
            Controls.Add(usercombobox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nametxtbox);
            Controls.Add(label3);
            Controls.Add(emailtxtbox);
            Controls.Add(label2);
            Controls.Add(passtxtbox);
            Controls.Add(label1);
            Controls.Add(idtxtbox);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idtxtbox;
        private Label label1;
        private Label label2;
        private TextBox passtxtbox;
        private Label label3;
        private TextBox emailtxtbox;
        private Label label4;
        private TextBox nametxtbox;
        private Label label5;
        private ComboBox usercombobox;
        private Button backbtn;
        private Button registerbtn;
    }
}