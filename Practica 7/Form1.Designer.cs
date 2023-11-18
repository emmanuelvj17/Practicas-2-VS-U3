namespace Practica_7
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 42);
            label1.Name = "label1";
            label1.Size = new Size(387, 16);
            label1.TabIndex = 0;
            label1.Text = "Imprime numeros de un rango especifico y calcula la suma.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 114);
            label2.Name = "label2";
            label2.Size = new Size(98, 16);
            label2.TabIndex = 1;
            label2.Text = "Rango inferior";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(365, 114);
            label3.Name = "label3";
            label3.Size = new Size(104, 16);
            label3.TabIndex = 2;
            label3.Text = "Rango superior";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(299, 408);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 3;
            label4.Text = "Suma";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(475, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(232, 214);
            button1.Name = "button1";
            button1.Size = new Size(97, 33);
            button1.TabIndex = 6;
            button1.Text = "Imprime";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new Point(365, 160);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 212);
            listBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(369, 406);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(705, 461);
            Controls.Add(textBox3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox3;
    }
}