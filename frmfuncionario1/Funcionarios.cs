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

            public double Valor_diaria { get; set; } 

            public double  Dias_Trabalhados  { get; set; }

            public double Salario { get; private set; }

            public double ValorIR { get; private set; }

            public double Salario_Liquido { get; private set; }

        public void CalcularSalario()
            {
             Salario = Dias_Trabalhados * Valor_diaria;

            if (Salario < 1903.98)
            {
                Salario_Liquido = Salario;
            }
            else if (Salario >= 1903.99 && Salario <= 2826.25)
            {
                ValorIR = (Salario * 7.5) / 100;
                Salario_Liquido = Salario - ValorIR;
            }
            else if (Salario >= 2826.66 && Salario <= 3751.05)
            {
                ValorIR = (Salario * 15) / 100;
                Salario_Liquido = Salario - ValorIR;
            }
            else if (Salario >= 3751.06 && Salario <= 4664.68)
            {
                ValorIR = (Salario * 22.5) / 100;
                Salario_Liquido = Salario - ValorIR;
            }
            }
        }
}
