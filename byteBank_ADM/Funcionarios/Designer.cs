using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        //metodo para retornar a bonificação
        public override Double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        //metodo para realizar o aumento de salario
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public Designer(decimal cpf) : base(cpf, 3000)//passando os parametros obrigatorios da classe base
        {

        }
    }
}
