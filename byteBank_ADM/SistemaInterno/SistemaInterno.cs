using byteBank_ADM.Funcionarios;
using byteBank_ADM.Parceiria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel autenticavel, string login, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(login,senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta ou usuario invalido");
                return false;
            }
        }
    }
}
