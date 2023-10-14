namespace Authentication_V1.Forms
{
    partial class RUD
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
            dataGridView1 = new DataGridView();
            idtxtbox = new TextBox();
            nametxtbox = new TextBox();
            passtxtbox = new TextBox();
            emailtxtbox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            searchbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 39);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(471, 296);
            dataGridView1.TabIndex = 0;
            // 
            // idtxtbox
            // 
            idtxtbox.Location = new Point(117, 39);
            idtxtbox.Margin = new Padding(3, 2, 3, 2);
            idtxtbox.Name = "idtxtbox";
            idtxtbox.Size = new Size(193, 23);
            idtxtbox.TabIndex = 1;
            // 
            // nametxtbox
            // 
            nametxtbox.Location = new Point(117, 85);
            nametxtbox.Margin = new Padding(3, 2, 3, 2);
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(193, 23);
            nametxtbox.TabIndex = 2;
            nametxtbox.TextChanged += nametxtbox_TextChanged;
            nametxtbox.MouseEnter += nametxtbox_MouseEnter;
            nametxtbox.MouseLeave += nametxtbox_MouseLeave;
            nametxtbox.MouseHover += nametxtbox_MouseHover;
            // 
            // passtxtbox
            // 
            passtxtbox.Location = new Point(117, 136);
            passtxtbox.Margin = new Padding(3, 2, 3, 2);
            passtxtbox.Name = "passtxtbox";
            passtxtbox.Size = new Size(193, 23);
            passtxtbox.TabIndex = 3;
            // 
            // emailtxtbox
            // 
            emailtxtbox.Location = new Point(117, 187);
            emailtxtbox.Margin = new Padding(3, 2, 3, 2);
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.Size = new Size(193, 23);
            emailtxtbox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 87);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 189);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 138);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 40);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Institutional ID";
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(69, 236);
            searchbtn.Margin = new Padding(3, 2, 3, 2);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(82, 22);
            searchbtn.TabIndex = 9;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(178, 236);
            updatebtn.Margin = new Padding(3, 2, 3, 2);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(82, 22);
            updatebtn.TabIndex = 10;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(178, 328);
            deletebtn.Margin = new Padding(3, 2, 3, 2);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(110, 38);
            deletebtn.TabIndex = 11;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(72, 263);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // RUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 392);
            Controls.Add(checkBox1);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(searchbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(emailtxtbox);
            Controls.Add(passtxtbox);
            Controls.Add(nametxtbox);
            Controls.Add(idtxtbox);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RUD";
            Text = "RUD";
            Load += RUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox idtxtbox;
        private TextBox nametxtbox;
        private TextBox passtxtbox;
        private TextBox emailtxtbox;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button searchbtn;
        private Button updatebtn;
        private Button deletebtn;
        private CheckBox checkBox1;
    }
}