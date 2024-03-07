using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (tb.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void linear_process_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(linear_a1.Text);
                double a2 = Convert.ToDouble(linear_a2.Text);
                Linear a = new Linear(a1, a2);
                int n = Convert.ToInt32(linear_n.Text);
                linear_an.Text = a.get_at(n).ToString();
                linear_sum.Text = a.sum(n).ToString();
            }
            catch
            {
                linear_an.Text = "Error";
                linear_sum.Text = "Error";
            }
        }

        private void exp_process_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(exp_a1.Text);
                double a2 = Convert.ToDouble(exp_a2.Text);
                Exponential a = new Exponential(a1, a2);
                int n = Convert.ToInt32(exp_n.Text);
                exp_an.Text = a.get_at(n).ToString();
                exp_sum.Text = a.sum(n).ToString();
            }
            catch
            {
                exp_an.Text = "Error";
                exp_sum.Text = "Error";
            }
        }
    }
}
