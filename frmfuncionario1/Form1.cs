namespace frmfuncionario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();

            funcionarios.Nome =txtNome.Text;
            funcionarios.CPF = txtCPF.Text;
            funcionarios.Dias_Trabalhados = double.Parse(txtDiasTrabalhadas.Text);
            funcionarios.Valor_diaria = double.Parse(txtValorDiaria.Text);

            funcionarios.CalcularSalario();
            txtSalario.Text =funcionarios.Salario.ToString();
            txtValorIR.Text = funcionarios.ValorIR.ToString();
            txtSalario_Liquido.Text=funcionarios.Salario_Liquido.ToString();

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_Liquido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}