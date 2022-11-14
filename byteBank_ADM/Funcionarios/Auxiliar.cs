using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        //metodo para retornar a bonificação
        public override Double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        //metodo para realizar o aumento de salario
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public Auxiliar(decimal cpf): base(cpf, 2000)//passando os parametros obrigatorios da classe base
        {

        }
    }
}
