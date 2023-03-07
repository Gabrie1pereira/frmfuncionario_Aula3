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
            funcionarios.CPF =txtCPF.Text;
            funcionarios.Valor_Hora = double.Parse(txtValorhora.Text);
            funcionarios.Hora = double.Parse(txtHorastrabalhadas.Text);
            
            funcionarios.CalcularSalario();
            txtSalario.Text =funcionarios.Salario.ToString();

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}