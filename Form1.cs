namespace CalculadoraTreino
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public double value;
        public double value2;
        public double resultado;
        public string operacao;
        public int saveValue2 = 0;
        public int click = 0;

        private void Calcular(string operacao)
        {
            
            if (operacao == "+")
            {
                value += value2;
            }
            else if (operacao == "-")
            {
                value -= value2;
                
            }
            else if (operacao == "*")
            {
                value *= value2;
            }
            else if (operacao == "/")
            {
               value /= value2;
            }
        }

        public void mudaLabel()
        {
            txtExec.Text = value.ToString() + " " + operacao.ToString();
            txtExec.Visible = true;
            if (click == 1)
            {
                txtExec.Text += " " + value2.ToString();
                lblIgual.Visible = true;
            }
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            if (click == 0)
            {
                value2 = double.Parse(txtVisor.Text);
                
            }
            click = 0;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            click = 1;
            mudaLabel();
            Calcular(operacao);
            txtVisor.Text = value.ToString();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtVisor.Text);
            operacao = "+";
            txtVisor.Text = value.ToString();
            mudaLabel();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtVisor.Text);
            operacao = "-";
            txtVisor.Text = value.ToString();
            mudaLabel();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtVisor.Text);
            operacao = "*";
            txtVisor.Text = value.ToString();
            mudaLabel();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtVisor.Text);
            operacao = "/";
            txtVisor.Text = value.ToString();
            mudaLabel();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "1";
            }
            else
            {
                txtVisor.Text += "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "2";
            }
            else
            {
                txtVisor.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "3";
            }
            else
            {
                txtVisor.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "4";
            }
            else
            {
                txtVisor.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "5";
            }
            else
            {
                txtVisor.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "6";
            }
            else
            {
                txtVisor.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "7";
            }
            else
            {
                txtVisor.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "8";
            }
            else
            {
                txtVisor.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == value.ToString())
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "9";
            }
            else
            {
                txtVisor.Text += "9";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "0";
            }
            else
            {
                txtVisor.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            value = 0;
            value2 = 0;
            txtVisor.Text = "0";
            txtExec.Text = "";
            txtExec.Visible = false;
            lblIgual.Visible = false;
        }

        private void lblValue2_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtExec.Visible = false;
            lblIgual.Visible = false;
        }
    }
}