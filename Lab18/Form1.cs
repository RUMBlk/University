using System.Collections.Generic;

namespace Lab18
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
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')
                || (e.KeyChar == ' ' && tb.Text.Length > 0 && (tb.Text[tb.Text.Length - 1] != ' ') && (tb.Text[tb.Text.Length - 1] != '-'))
                || (e.KeyChar == '-' && (tb.Text.Length == 0 || tb.Text[tb.Text.Length - 1] == ' '))
            )
            {
                // цифра або пропуск
                return;
            }
            if (Char.IsControl(e.KeyChar) && tb.Text.Length > 0)
            {
                // <Enter>, <Backspace>, <Esc>
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void t1_process_Click(object sender, EventArgs e)
        {
            try
            {
                var substrings = t1_input.Text.Trim().Split(' ', '\n');
                int[] arr = new int[substrings.Length];
                t1_output.Text = "";
                for (int i = 0; i < substrings.Length; i++)
                {
                    arr[i] = int.Parse(substrings[i]);
                }

                (int index, int value)? min = null;
                (int state, int value) sum = (0, 0);  //state - кількість досягнутих негативних значень
                string sorted_arr = "";
                for (int i = 0, finish_sort = 0; i < arr.Length; i++)
                {
                    if (finish_sort == 0)
                    {
                        var cell = (index: i, value: arr[i]);
                        if (min == null || min.Value.value > cell.value)
                        {
                            min = cell;
                        }

                        if (arr[i] < 0) { sum.state++; }
                        else if (sum.state == 1)
                        {
                            sum.value += arr[i];
                        }
                        if (!(Math.Abs(arr[i]) > 1)) { sorted_arr += arr[i].ToString() + " "; }
                        if (i == arr.Length - 1) { finish_sort++; i = -1; }
                    }
                    else
                    {
                        if (Math.Abs(arr[i]) > 1) { sorted_arr += arr[i].ToString() + " "; }
                    }
                }
                t1_output.Text = String.Format("Номер мінімального елемента масиву: {0}" + Environment.NewLine
                    + "Сума елементів масиву, розташованих між першим і другим від’ємними елементами: {1}" + Environment.NewLine
                    + "Перетворений масив: {2}" + Environment.NewLine,
                    min.Value.index, sum.value, sorted_arr
                    );
            }
            catch
            {
                t1_output.Text = "Помилка!";
            }
        }

        private void t2_process_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = t2_input.Text.Trim().Split('\n');
                string[][] substrings = new string[lines.Length][];
                int? columns = null;  
                for(int i=0; i<lines.Length; i++)
                {
                    substrings[i] = lines[i].Trim().Split(' ');
                    int line_columns = substrings[i].Length;
                    if (columns == null || columns > line_columns)
                    {
                        columns = line_columns;
                    }
                }
                int[][] arr = new int[lines.Length][];
                t2_output.Text = "Масив:" + Environment.NewLine;
                for(int i=0; i< lines.Length; i++)
                {
                    arr[i] = new int[columns.Value];
                    for(int j=0; j<columns; j++)
                    {
                        arr[i][j] = int.Parse(substrings[i][j]);
                        t2_output.Text += arr[i][j] + " ";
                    }
                    t2_output.Text += Environment.NewLine;
                }

                try
                {
                    var a = t2_a.Text.Trim().Split(';');
                    var b = t2_b.Text.Trim().Split(';');
                    var c = t2_c.Text.Trim().Split(';');

                    var ab = arr[int.Parse(a[0])][int.Parse(a[1])] + arr[int.Parse(b[0])][int.Parse(b[1])];
                    var avrg = (arr[int.Parse(a[0])][int.Parse(a[1])] + arr[int.Parse(b[0])][int.Parse(b[1])] + arr[int.Parse(c[0])][int.Parse(c[1])]) / 3f;

                    t2_output.Text += Environment.NewLine + String.Format("Сума a та b: {0}" + Environment.NewLine
                        + "Середнє арифметичне a, b, c: {1}",
                        ab, avrg);
                }
                catch
                {
                    t2_output.Text += Environment.NewLine + "Координати значень масиву не введено або введено некоректно!";
                }
            }
            catch
            {
                t2_output.Text = "Помилка!";
            }
        }
    }
}
