namespace Lab18
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            t1_output = new TextBox();
            t1_process = new Button();
            label1 = new Label();
            t1_input = new TextBox();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            t2_c = new TextBox();
            label8 = new Label();
            t2_b = new TextBox();
            label7 = new Label();
            t2_a = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            t2_output = new TextBox();
            t2_process = new Button();
            label4 = new Label();
            t2_input = new TextBox();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1088, 390);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(t1_output);
            tabPage1.Controls.Add(t1_process);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(t1_input);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1080, 357);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 6);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 6;
            label2.Text = " Результат:";
            // 
            // t1_output
            // 
            t1_output.Location = new Point(532, 29);
            t1_output.Multiline = true;
            t1_output.Name = "t1_output";
            t1_output.ReadOnly = true;
            t1_output.Size = new Size(539, 318);
            t1_output.TabIndex = 5;
            // 
            // t1_process
            // 
            t1_process.Location = new Point(6, 318);
            t1_process.Name = "t1_process";
            t1_process.Size = new Size(507, 29);
            t1_process.TabIndex = 4;
            t1_process.Text = "Обчислити";
            t1_process.UseVisualStyleBackColor = true;
            t1_process.Click += t1_process_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 188);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 3;
            label1.Text = "Одновимірний масив:";
            // 
            // t1_input
            // 
            t1_input.Location = new Point(6, 211);
            t1_input.Multiline = true;
            t1_input.Name = "t1_input";
            t1_input.PlaceholderText = "1 2 3 4 5 6 7 8 9 10";
            t1_input.Size = new Size(507, 101);
            t1_input.TabIndex = 2;
            t1_input.KeyPress += tb_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(t2_c);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(t2_b);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(t2_a);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(t2_output);
            tabPage2.Controls.Add(t2_process);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(t2_input);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1080, 357);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // t2_c
            // 
            t2_c.Location = new Point(423, 287);
            t2_c.Name = "t2_c";
            t2_c.PlaceholderText = "0; 2";
            t2_c.Size = new Size(89, 27);
            t2_c.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 290);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 18;
            label8.Text = "c:";
            // 
            // t2_b
            // 
            t2_b.Location = new Point(223, 287);
            t2_b.Name = "t2_b";
            t2_b.PlaceholderText = "0; 1";
            t2_b.Size = new Size(89, 27);
            t2_b.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 290);
            label7.Name = "label7";
            label7.Size = new Size(21, 20);
            label7.TabIndex = 16;
            label7.Text = "b:";
            // 
            // t2_a
            // 
            t2_a.Location = new Point(34, 287);
            t2_a.Name = "t2_a";
            t2_a.PlaceholderText = "0; 0";
            t2_a.Size = new Size(89, 27);
            t2_a.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 290);
            label6.Name = "label6";
            label6.Size = new Size(20, 20);
            label6.TabIndex = 14;
            label6.Text = "a:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 252);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 13;
            label5.Text = "Координати(x, y)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 8);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 12;
            label3.Text = " Результат:";
            // 
            // t2_output
            // 
            t2_output.Location = new Point(534, 31);
            t2_output.Multiline = true;
            t2_output.Name = "t2_output";
            t2_output.ReadOnly = true;
            t2_output.Size = new Size(539, 318);
            t2_output.TabIndex = 11;
            // 
            // t2_process
            // 
            t2_process.Location = new Point(8, 320);
            t2_process.Name = "t2_process";
            t2_process.Size = new Size(507, 29);
            t2_process.TabIndex = 10;
            t2_process.Text = "Обчислити";
            t2_process.UseVisualStyleBackColor = true;
            t2_process.Click += t2_process_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(363, 20);
            label4.TabIndex = 9;
            label4.Text = "Двовимірний масив(рядок тексту = рядок масиву):";
            // 
            // t2_input
            // 
            t2_input.Location = new Point(8, 145);
            t2_input.Multiline = true;
            t2_input.Name = "t2_input";
            t2_input.PlaceholderText = "1 2 3";
            t2_input.Size = new Size(505, 104);
            t2_input.TabIndex = 8;
            t2_input.KeyPress += tb_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(505, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 408);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "ЛР 18 Варіант 15";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox t1_input;
        private PictureBox pictureBox1;
        private Button t1_process;
        private Label label2;
        private TextBox t1_output;
        private Label label3;
        private TextBox t2_output;
        private Button t2_process;
        private Label label4;
        private TextBox t2_input;
        private PictureBox pictureBox2;
        private TextBox t2_a;
        private Label label6;
        private Label label5;
        private TextBox t2_c;
        private Label label8;
        private TextBox t2_b;
        private Label label7;
    }
}
