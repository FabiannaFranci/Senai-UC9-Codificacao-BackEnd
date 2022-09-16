// See https://aka.ms/new-console-template for more information
using Projetos_Senai.Classes;


PessoaFisica novaPF = new PessoaFisica();

novaPF.Nome  = ("Fabi");
novaPF.Rendimento = 5000.00f;
novaPF.cpf = ("994.778.983.98");
novaPF.DataDeNascimento = new DateOnly(2001, 12, 09);

Console.WriteLine("==========Pessoa Física==========");

Console.WriteLine(@$"Nome: {novaPF.Nome}
CPF: {novaPF.cpf}
Data de Nascimento: {novaPF.DataDeNascimento}
Rendimento Mensal: R${novaPF.Rendimento}");

Console.WriteLine("==========Pessoa Jurídica==========");

PessoaJuridica novaPJ = new PessoaJuridica();
novaPJ.Cpnj = ("23.453.654/0001-34");
novaPJ.Nome = ("Carlo's Company");
novaPJ.Rendimento = 1000000.0f;
novaPJ.RazaoSocial = ("Carlo's Company Ltda");

Console.Write(@$"Nome da Empresa: {novaPJ.Nome}
Razão Social: {novaPJ.RazaoSocial}
Rendimento Mensal: {novaPJ.Rendimento}
CPNJ: {novaPJ.Cpnj}");


