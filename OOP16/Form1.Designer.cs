namespace OOP16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            input = new TextBox();
            output = new TextBox();
            label1 = new Label();
            label2 = new Label();
            process = new Button();
            N = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(597, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // input
            // 
            input.Location = new Point(12, 467);
            input.Multiline = true;
            input.Name = "input";
            input.PlaceholderText = "1+2i 3+4i 5+6i 1+2i 3+4i 5+6i 1+2i 3+4i 5+6i 1+2i 3+4i 5+6i 1+2i 3+4i 5+6i";
            input.Size = new Size(597, 244);
            input.TabIndex = 1;
            // 
            // output
            // 
            output.Location = new Point(627, 45);
            output.Multiline = true;
            output.Name = "output";
            output.Size = new Size(560, 701);
            output.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 12);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Вихідні дані:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 429);
            label2.Name = "label2";
            label2.Size = new Size(535, 20);
            label2.TabIndex = 4;
            label2.Text = "Ввід комплексних чисел в форматі \"x+yi\" з пропуском у якості роздільника:";
            // 
            // process
            // 
            process.Location = new Point(176, 717);
            process.Name = "process";
            process.Size = new Size(433, 29);
            process.TabIndex = 5;
            process.Text = "Обчислити";
            process.UseVisualStyleBackColor = true;
            process.Click += process_Click;
            // 
            // N
            // 
            N.Location = new Point(41, 717);
            N.Name = "N";
            N.Size = new Size(129, 27);
            N.TabIndex = 6;
            N.KeyPress += N_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 721);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 7;
            label3.Text = "N:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 758);
            Controls.Add(label3);
            Controls.Add(N);
            Controls.Add(process);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "ЛР 16 Варіант 15";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox input;
        private TextBox output;
        private Label label1;
        private Label label2;
        private Button process;
        private TextBox N;
        private Label label3;
    }
}
