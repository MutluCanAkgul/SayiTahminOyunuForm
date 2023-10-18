namespace SayiTahminOyunuForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(133, 242);
            button1.Name = "button1";
            button1.Size = new Size(221, 62);
            button1.TabIndex = 0;
            button1.Text = "Tahmin Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(133, 158);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 59);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 43);
            label1.Name = "label1";
            label1.Size = new Size(371, 23);
            label1.TabIndex = 2;
            label1.Text = "Klavyeden 0-100 arasında bir sayı gir";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 389);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(210, 107);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 4;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 584);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Tahmin Etme Oyunu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}