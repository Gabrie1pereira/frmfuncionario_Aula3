using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmfuncionario1
{
    public class Funcionarios
    {
       
            public string Nome { get; set; } = string.Empty;
            public string CPF { get; set; } = string.Empty;

            public double Valor_Hora { get; set; } 

            public double Hora  { get; set; }

            public double Salario { get; private set; }

            public void CalcularSalario()
            {
             Salario = Valor_Hora * Hora;
            }
        }
}
