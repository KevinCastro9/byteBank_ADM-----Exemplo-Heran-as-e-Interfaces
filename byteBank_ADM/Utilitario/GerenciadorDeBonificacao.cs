using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {

        private double _totalDeBonificacoes;

        public double TotalDeBonificacoes { get { return this._totalDeBonificacoes; } private set { this._totalDeBonificacoes = value; } }

        //metodo para gerar a bonificação do funcionario
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacoes += funcionario.GetBonificacao();
        }

    }
}
