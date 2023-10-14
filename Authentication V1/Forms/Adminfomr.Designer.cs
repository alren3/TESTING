namespace Authentication_V1.Forms
{
    partial class Adminfomr
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
            registerbtn = new Button();
            OpenRUD = new Button();
            SuspendLayout();
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(50, 28);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(144, 80);
            registerbtn.TabIndex = 0;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // OpenRUD
            // 
            OpenRUD.Location = new Point(50, 136);
            OpenRUD.Name = "OpenRUD";
            OpenRUD.Size = new Size(144, 80);
            OpenRUD.TabIndex = 1;
            OpenRUD.Text = "Read/ Update/ Delete";
            OpenRUD.UseVisualStyleBackColor = true;
            OpenRUD.Click += OpenRUD_Click;
            // 
            // Adminfomr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 521);
            Controls.Add(OpenRUD);
            Controls.Add(registerbtn);
            Name = "Adminfomr";
            Text = "Adminfomr";
            ResumeLayout(false);
        }

        #endregion

        private Button registerbtn;
        private Button OpenRUD;
    }
}