using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        //metodo para retornar a bonificação. 100% do salario do Diretor
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        //metodo para realizar o aumento de salario
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public Diretor(decimal cpf):base(cpf, 5000) //passando os parametros obrigatorios da classe base
        {

        }
    }
}
