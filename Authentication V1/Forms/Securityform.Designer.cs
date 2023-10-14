namespace Authentication_V1.Forms
{
    partial class Securityform
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
            pictureBox1 = new PictureBox();
            addBtn = new Button();
            removeBtn = new Button();
            textBoxMainParkingValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.An_example_of_logical_parking_lot_map;
            pictureBox1.Location = new Point(62, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(739, 458);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(127, 88);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(244, 88);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(94, 29);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // textBoxMainParkingValue
            // 
            textBoxMainParkingValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMainParkingValue.Location = new Point(355, 87);
            textBoxMainParkingValue.Name = "textBoxMainParkingValue";
            textBoxMainParkingValue.Size = new Size(59, 34);
            textBoxMainParkingValue.TabIndex = 3;
            // 
            // Securityform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 540);
            Controls.Add(textBoxMainParkingValue);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(pictureBox1);
            Name = "Securityform";
            Text = "Securityform";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button addBtn;
        private Button removeBtn;
        private Label currentlbl1;
        private TextBox textBoxMainParkingValue;
    }
}