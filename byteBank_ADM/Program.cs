using byteBank_ADM.Funcionarios;
using byteBank_ADM.Parceiria;
using byteBank_ADM.SistemaInterno;
using byteBank_ADM.Utilitario;

#region
//Funcionario funcionarioJoao = new Funcionario(12345678911, 2000);
//funcionarioJoao.Nome = "João";

//Diretor diretorMaria = new Diretor(12345678999);
//diretorMaria.Nome = "Maria";

//Console.WriteLine(funcionarioJoao.Nome);
//Console.WriteLine(funcionarioJoao.GetBonificacao());
//Console.WriteLine("----------------------------------");
//Console.WriteLine(diretorMaria.Nome);
//Console.WriteLine(diretorMaria.GetBonificacao());
//Console.WriteLine("----------------------------------");

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(funcionarioJoao);
//gerenciador.Registrar(diretorMaria);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacoes);
//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//Console.WriteLine("----------------------------------");

//funcionarioJoao.AumentarSalario();
//diretorMaria.AumentarSalario();

//Console.WriteLine("Novo Salario João: " + funcionarioJoao.Salario);
//Console.WriteLine("Novo Salario Maria: " + diretorMaria.Salario);

#endregion

UsarSistema();
//CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciadorDeBonificacao = new GerenciadorDeBonificacao();

    Designer designerBruna = new Designer(12345678901);
    designerBruna.Nome = "Bruna";

    Diretor diretorMaria = new Diretor(12332112312);
    diretorMaria.Nome = "Maria";

    Auxiliar auxiliarCamila = new Auxiliar(99999999999);
    auxiliarCamila.Nome = "Camila";

    GerenteDeConta gerenteDeContaLarissa = new GerenteDeConta(11122222211);
    gerenteDeContaLarissa.Nome = "Larissa";

    gerenciadorDeBonificacao.Registrar(gerenteDeContaLarissa);
    gerenciadorDeBonificacao.Registrar(auxiliarCamila);
    gerenciadorDeBonificacao.Registrar(diretorMaria);
    gerenciadorDeBonificacao.Registrar(designerBruna);

    Console.WriteLine("Total de bonificação: " + gerenciadorDeBonificacao.TotalDeBonificacoes);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor diretorIngrid = new Diretor(12345678901);
    diretorIngrid.Nome = "Ingrid";
    diretorIngrid.Login = "Ingrid";
    diretorIngrid.Senha = "123";

    GerenteDeConta gerenteDeContaLarissa = new GerenteDeConta(12312312312);
    gerenteDeContaLarissa.Nome = "Larissa";
    gerenteDeContaLarissa.Login = "Larissa";
    gerenteDeContaLarissa.Senha = "111";

    ParceiroComercial parceiroComercialLeticia = new ParceiroComercial();
    parceiroComercialLeticia.Login = "Leticia";
    parceiroComercialLeticia.Senha = "999";

    sistema.Logar(diretorIngrid, "Ingrid", "123");
    sistema.Logar(gerenteDeContaLarissa, "Larissa", "111");
    sistema.Logar(parceiroComercialLeticia, "Leticia", "999");

}