using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        protected FuncionarioAutenticavel(decimal cpf, double salario) : base(cpf, salario)
        {
        }

        public bool Autenticar(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login);
        }
    }
}
