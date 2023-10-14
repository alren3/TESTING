namespace Authentication_V1.Forms
{
    partial class Login
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
            loginbtn = new Button();
            label2 = new Label();
            passtxtbox = new TextBox();
            label1 = new Label();
            idtxtbox = new TextBox();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Location = new Point(215, 176);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(158, 73);
            loginbtn.TabIndex = 23;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 108);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // passtxtbox
            // 
            passtxtbox.Location = new Point(215, 105);
            passtxtbox.Name = "passtxtbox";
            passtxtbox.Size = new Size(265, 27);
            passtxtbox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 63);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 13;
            label1.Text = "Institutional ID";
            // 
            // idtxtbox
            // 
            idtxtbox.Location = new Point(215, 60);
            idtxtbox.Name = "idtxtbox";
            idtxtbox.Size = new Size(265, 27);
            idtxtbox.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 309);
            Controls.Add(loginbtn);
            Controls.Add(label2);
            Controls.Add(passtxtbox);
            Controls.Add(label1);
            Controls.Add(idtxtbox);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Label label2;
        private TextBox passtxtbox;
        private Label label1;
        private TextBox idtxtbox;
    }
}