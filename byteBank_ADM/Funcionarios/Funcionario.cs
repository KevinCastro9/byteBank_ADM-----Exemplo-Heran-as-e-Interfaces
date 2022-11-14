using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        //propriedades
        public string Nome { get; set; }

        private decimal _cpf;
        public decimal Cpf { get { return this.Cpf; } private set { this._cpf = value.ToString().Length == 11 ? value : this._cpf; } }

        //protected: deixa o campo visivel apenas na classe e nas classes que herdam dela
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        //metodo para retornar a bonificação. 10% do salario do funcionario
        public abstract double GetBonificacao();

        //metodo para realizar o aumento de salario
        public abstract void AumentarSalario();

        public Funcionario(decimal cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }
    }
}
