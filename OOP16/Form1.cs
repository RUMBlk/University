namespace OOP16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void process_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = String.Empty;
                string[] numbers = input.Text.Split(' ');
                for(int i = 1; i <= Convert.ToInt32(N.Text); i++)
                {
                    output.AppendText("N = " +  i + ": ");
                    foreach (var num in numbers)
                    {
                        Complex number = new Complex(num).Pow(i);
                        output.AppendText(number.Get() + '\t');
                    }
                    output.AppendText(Environment.NewLine);
                }
            }
            catch
            {
                output.Text = "Error!";
            }
        }

        private void N_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    process.Focus();
                }
                return;
            }
            e.Handled = true;
        }
    }
}
