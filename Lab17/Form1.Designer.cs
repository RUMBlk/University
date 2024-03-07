namespace Lab17
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linear_a1 = new System.Windows.Forms.TextBox();
            this.linear_a2 = new System.Windows.Forms.TextBox();
            this.linear_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linear_sum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linear_an = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linear_process = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exp_sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.exp_an = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.exp_process = new System.Windows.Forms.Button();
            this.exp_a2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exp_a1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.exp_n = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linear_a1
            // 
            this.linear_a1.Location = new System.Drawing.Point(64, 15);
            this.linear_a1.Name = "linear_a1";
            this.linear_a1.Size = new System.Drawing.Size(100, 22);
            this.linear_a1.TabIndex = 1;
            this.linear_a1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // linear_a2
            // 
            this.linear_a2.Location = new System.Drawing.Point(64, 43);
            this.linear_a2.Name = "linear_a2";
            this.linear_a2.Size = new System.Drawing.Size(100, 22);
            this.linear_a2.TabIndex = 2;
            this.linear_a2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // linear_n
            // 
            this.linear_n.Location = new System.Drawing.Point(64, 71);
            this.linear_n.Name = "linear_n";
            this.linear_n.Size = new System.Drawing.Size(100, 22);
            this.linear_n.TabIndex = 3;
            this.linear_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "a1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "a2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "n:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linear_sum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linear_an);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linear_process);
            this.groupBox1.Controls.Add(this.linear_a2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linear_a1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.linear_n);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Арифметична прогресія";
            // 
            // linear_sum
            // 
            this.linear_sum.Location = new System.Drawing.Point(245, 59);
            this.linear_sum.Name = "linear_sum";
            this.linear_sum.ReadOnly = true;
            this.linear_sum.Size = new System.Drawing.Size(100, 22);
            this.linear_sum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "sum:";
            // 
            // linear_an
            // 
            this.linear_an.Location = new System.Drawing.Point(245, 31);
            this.linear_an.Name = "linear_an";
            this.linear_an.ReadOnly = true;
            this.linear_an.Size = new System.Drawing.Size(100, 22);
            this.linear_an.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "an:";
            // 
            // linear_process
            // 
            this.linear_process.Location = new System.Drawing.Point(17, 99);
            this.linear_process.Name = "linear_process";
            this.linear_process.Size = new System.Drawing.Size(328, 23);
            this.linear_process.TabIndex = 7;
            this.linear_process.Text = "Обчислити";
            this.linear_process.UseVisualStyleBackColor = true;
            this.linear_process.Click += new System.EventHandler(this.linear_process_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exp_sum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.exp_an);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.exp_process);
            this.groupBox2.Controls.Add(this.exp_a2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.exp_a1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.exp_n);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(409, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 128);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Геометрична прогресія";
            // 
            // exp_sum
            // 
            this.exp_sum.Location = new System.Drawing.Point(245, 59);
            this.exp_sum.Name = "exp_sum";
            this.exp_sum.ReadOnly = true;
            this.exp_sum.Size = new System.Drawing.Size(100, 22);
            this.exp_sum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "sum:";
            // 
            // exp_an
            // 
            this.exp_an.Location = new System.Drawing.Point(245, 31);
            this.exp_an.Name = "exp_an";
            this.exp_an.ReadOnly = true;
            this.exp_an.Size = new System.Drawing.Size(100, 22);
            this.exp_an.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "an:";
            // 
            // exp_process
            // 
            this.exp_process.Location = new System.Drawing.Point(17, 99);
            this.exp_process.Name = "exp_process";
            this.exp_process.Size = new System.Drawing.Size(328, 23);
            this.exp_process.TabIndex = 7;
            this.exp_process.Text = "Обчислити";
            this.exp_process.UseVisualStyleBackColor = true;
            this.exp_process.Click += new System.EventHandler(this.exp_process_Click);
            // 
            // exp_a2
            // 
            this.exp_a2.Location = new System.Drawing.Point(64, 43);
            this.exp_a2.Name = "exp_a2";
            this.exp_a2.Size = new System.Drawing.Size(100, 22);
            this.exp_a2.TabIndex = 2;
            this.exp_a2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "n:";
            // 
            // exp_a1
            // 
            this.exp_a1.Location = new System.Drawing.Point(64, 15);
            this.exp_a1.Name = "exp_a1";
            this.exp_a1.Size = new System.Drawing.Size(100, 22);
            this.exp_a1.TabIndex = 1;
            this.exp_a1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "a2:";
            // 
            // exp_n
            // 
            this.exp_n.Location = new System.Drawing.Point(64, 71);
            this.exp_n.Name = "exp_n";
            this.exp_n.Size = new System.Drawing.Size(100, 22);
            this.exp_n.TabIndex = 3;
            this.exp_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "a1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "ЛР 17 Варіант 15";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox linear_a1;
        private System.Windows.Forms.TextBox linear_a2;
        private System.Windows.Forms.TextBox linear_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox linear_sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox linear_an;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button linear_process;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox exp_sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox exp_an;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exp_process;
        private System.Windows.Forms.TextBox exp_a2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox exp_a1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox exp_n;
        private System.Windows.Forms.Label label10;
    }
}

