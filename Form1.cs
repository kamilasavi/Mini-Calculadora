namespace Mini_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbNum2_TextChanged(object sender, EventArgs e)
        {
            if ((txbNum1.Text != string.Empty) && (txbNum2.Text != string.Empty))
            {
                btnDivisao.Enabled = true;
                btnMais.Enabled = true;
                btnMenos.Enabled = true;
                btnMultiplicar.Enabled = true;

            }
        }

        private void txbNum1_TextChanged(object sender, EventArgs e)
        {
            if ((txbNum1.Text != string.Empty) && (txbNum2.Text != string.Empty))
            {
                btnDivisao.Enabled = true;
                btnMais.Enabled = true;
                btnMenos.Enabled = true;
                btnMultiplicar.Enabled = true;

            }
        }

        private void txbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void txbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            result = num1 + num2;
            txbResultado.Text = result.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            result = num1 - num2;
            txbResultado.Text = result.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            result = num1 * num2;
            txbResultado.Text = result.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txbNum1.Text);
            num2 = float.Parse(txbNum2.Text);
            result = num1 / num2;
            txbResultado.Text = result.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNum1.Text = "";
            txbNum2.Text = "";
            txbResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}