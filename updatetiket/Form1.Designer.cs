namespace updatetiket
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
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(314, 43);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "TIKET MASUK";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(481, 130);
            button2.Name = "button2";
            button2.Size = new Size(58, 23);
            button2.TabIndex = 10;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(481, 155);
            button3.Name = "button3";
            button3.Size = new Size(58, 23);
            button3.TabIndex = 12;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 134);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 134);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 159);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 159);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(266, 107);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 17;
            label6.Text = "Kategori";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(349, 107);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 18;
            label7.Text = "Harga Tiket";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "     ";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}