using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        //metodo para retornar a bonificação
        public override Double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        //metodo para realizar o aumento de salario
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public GerenteDeConta(decimal cpf) : base(cpf, 4000)//passando os parametros obrigatorios da classe base
        {

        }

    }
}
