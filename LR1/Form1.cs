using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex1_process_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(ex1_x.Text);
                double y = 2 * 1 / Math.Tan(3 * x) - (1 / (12 * Math.Pow(x, 2) + 7 * x - 5));
                ex1_answer.Text = Convert.ToString(y);
            }
            catch
            {
                ex1_x.Focus();
            }
        }

        private void ex1_x_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex1_x.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex1_process.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex2_r_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex2_r.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на поле редагування R
                    ex2_rr.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex2_rr_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex2_rr.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex2_process.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex2_process_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(ex2_r.Text);
                double R = Convert.ToDouble(ex2_rr.Text);
                if (R > r)
                {
                    double S = Math.PI * Math.Pow(R, 2) - (Math.PI * Math.Pow(r, 2));
                    ex2_answer.Text = Convert.ToString(S);
                } else { throw new ArgumentException("R повинно бути більше за r!"); }
            }
            catch
            {
                ex2_r.Focus();
            }
        }
        private void ex3_a_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex3_a.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex3_b.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex3_b_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex3_b.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex3_c.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex3_c_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex3_c.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex3_process.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex3_process_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(ex3_a.Text);
                double b = Convert.ToDouble(ex3_b.Text);
                double c = Convert.ToDouble(ex3_c.Text);
                ex3_answer.Text = ((a + b) / 2 == c).ToString();

            }
            catch
            {
                ex3_a.Focus();
            }
        }

        private void ex4_r_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex4_r.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex4_a.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex4_a_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                if (ex4_a.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex4_process.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex4_process_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(ex4_r.Text);
                double a = Convert.ToDouble(ex4_a.Text);
                ex4_answer.Text = (Math.Round(Math.Sqrt(3) / 6 * a, 2) == Math.Round(R/2, 2)).ToString();

            }
            catch
            {
                ex4_r.Focus();
            }
        }

        static int SqrSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num /= 10;
            }
            return sum;
        }


        private void ex5_process_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(ex5_n.Text);
            int M = Convert.ToInt32(ex5_m.Text);
            int lowerBound = (int)Math.Pow(10, n - 1);
            int upperBound = (int)Math.Pow(10, n);
            int ans = 0;
            for (int i = lowerBound; i < upperBound; i++)
            {
                if (SqrSum(i) % M == 0)
                {
                    ans++;
                }
            }
            ex5_answer.Text = ans.ToString();
        }

        private void ex5_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex5_m.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void ex5_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    ex5_process.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private List<System.Windows.Forms.TextBox> getSlots()
        {
            List<System.Windows.Forms.TextBox> slots = new List<System.Windows.Forms.TextBox>
            {
                ex6_1,
                ex6_2,
                ex6_3,
                ex6_4,
                ex6_5,
                ex6_6,
                ex6_7,
                ex6_8,
                ex6_9,
                ex6_10
            };
            return slots;
        }

        void validateSlots()
        {
            List<System.Windows.Forms.TextBox> slots = getSlots();
            int occupied = 0;
            foreach (var slot in slots)
            {
                if (slot.Text != "") { occupied++; } //Підрахунок усіх зайнятих гнізд
            }
            ex6_available.Text = "Кількість гральних кубиків: " + (2 - occupied).ToString(); //Оновлення показника
            foreach (var slot in slots)
            {
                if (slot.Text == "") { slot.Enabled = occupied < 2; } //Включення/Виключення можливості взаємодії з гніздами в залежності від кількості гральних кубиків
            }
            if (occupied != 2)
            {
                ex6_process.Enabled = false; //Включати можливість натискати кнопку обчислення тільки у випадку коли всі гральні кубики вставлені
            }
            else { ex6_process.Enabled = true; }
        }

        private void ex6_slot_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox slot = (System.Windows.Forms.TextBox)sender; //Отримання гнізда яке отримало сигнал натискання кнопки
            if ((e.KeyChar >= '1') && (e.KeyChar <= '6')) { slot.Text = e.KeyChar.ToString(); } //Фільтр який пропускає цифри тільки від 1 до 6
            if (e.KeyChar == ((char)Keys.Back)) { slot.Text = ""; } //та стирання тексту
            e.Handled = true;
            validateSlots(); //підрахувати зайняті гнізда та змінити можливість взаємодії з елементами керування
        }

        private void ex6_process_Click(object sender, EventArgs e)
        {
            List<System.Windows.Forms.TextBox> slots = getSlots();
            int a = 0;
            int b = 0;
            int c = 0;
            int state = 0;

            foreach (System.Windows.Forms.TextBox slot in slots)
            {
                if (slot.Text != "" && state == 0) //Якщо це перше знайдене зайняте гніздо
                {
                    a = Convert.ToInt32(slot.Text);
                    state++; //позначати, що перше зайняте гніздо знайдене
                }
                else if(slot.Text != "" && state == 1) //Якщо наступне гніздо також зайняте 
                {
                    b = Convert.ToInt32(slot.Text);
                    if (slot == ex6_10) //та якщо немає куди вставити гральний кубик справа, то вставити зліва
                    {
                        c = b;
                        b = a;
                        a = 10-b-c;

                    }
                    else //інакше зправа
                    {
                        c = 10 - a - b;
                    }
                    break;
                }
                else if(slot.Text == "" && state == 1) //якщо наступне гніздо не зайняте, позначаємо та перевіряємо наступне
                {
                    state++;
                }
                else if(slot.Text == "" && state == 2) //якщо також ні, значить немає більше сенсу перевіряти, задаємо значення яке призведе до помилки та виходимо з циклу
                {
                    c = -10;
                    break;
                }
                else if(slot.Text != "" && state == 2) //інакше обчислюємо значення грального кубика яке потрібно вставити між іншими двома
                {
                    c = Convert.ToInt32(slot.Text);
                    b = 10 - a - c;
                    break;
                }
            }

            if ((a >= 1 && b >= 1 && c >= 1) && (a <= 6 && b <= 6 && c <= 6))
            {
                ex6_answer.Text = a.ToString() + b.ToString() + c.ToString();
            }
            else
            {
                ex6_answer.Text = "Розв'язку немає!";
            }
        }

        private void ex7_process_Click(object sender, EventArgs e)
        {
            string[] words = ex7_input.Text.Split(':')[0].Split(';'); //ділемо вхідні дані на частини до та після знаку :, а потім на частини поділені знаком ;
            int ans = 0;
            foreach (var word in words)
            {
                if (word != "" && word.Last() == 'а') { ans++; } //та підраховуємо
            }
            ex7_answer.Text = ans.ToString();
        }
    }


}
