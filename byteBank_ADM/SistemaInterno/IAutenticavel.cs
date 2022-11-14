using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{
    public interface IAutenticavel 
    {
        public string Login { get; set; }
        public string Senha { get; set; }


        //metodo para autenticar o Funcionario no sistema(Apenas diretor e gerente de contas)
        public abstract bool Autenticar(string login, string senha);

    }
}
