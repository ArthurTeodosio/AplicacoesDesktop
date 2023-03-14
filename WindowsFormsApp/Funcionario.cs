using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public int DiasTrabalhados { get; set; }   
        public double ValorDiaria { get; set; }
        public double SalarioBase { get; private set; }
        public double SalarioLiquido { get; private set; }
        public double ValorIR { get; private set; }

        public void CalcularSalarioBase()
        {
            SalarioBase = (DiasTrabalhados * ValorDiaria);
        }

        public void CalcularSalarioLiquido()
        {
            SalarioLiquido = (SalarioBase - ValorIR);
        }
        
        public void CalcularIR()
        {
            if(SalarioBase <= 1908.98) {
                ValorIR = SalarioBase * 0;
            } else if(SalarioBase <= 2826.65 ) {
                ValorIR = SalarioBase * (7.5/100);
            } else if(SalarioBase <= 3751.05) {
                ValorIR = SalarioBase * (15/100);
            } else {
                ValorIR = SalarioBase * (22.50 / 100);
            }
            
        }

    }
}
