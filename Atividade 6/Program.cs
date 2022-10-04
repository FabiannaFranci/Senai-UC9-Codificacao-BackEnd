
using System.Globalization;
using Projetos_Senai.Classes;

// Pessoa Jurídica
Endereco novoEndPJ = new Endereco();
novoEndPJ.Logradouro = ("Rua Antônio das Flores");
novoEndPJ.Numero = 83;
novoEndPJ.Complemento = ("De frente ao restaurante Flor De Liz");
novoEndPJ.EnderecoComercial = true;

PessoaJuridica novaPJ = new PessoaJuridica();
novaPJ.Cpnj = ("23.453.654/0001-34");
novaPJ.Nome = ("Carlo's Company");
novaPJ.Rendimento = 1000000.0f;
novaPJ.RazaoSocial = ("Carlo's Company Ltda");
novaPJ.Endereco = novoEndPJ;

PessoaJuridica metodosPJ = new PessoaJuridica();

// Pessoa Física
Endereco novoEndPF = new Endereco();
novoEndPF.Logradouro = ("Rua São Luís");
novoEndPF.Numero = 60;
novoEndPF.Complemento = ("Ao lado da banca Jorge Amado");
novoEndPF.EnderecoComercial = false;


PessoaFisica novaPF = new PessoaFisica();

novaPF.Nome  = ("Fabi");
novaPF.Rendimento = 5000.00f;
novaPF.cpf = ("994.778.983.98");
novaPF.DataDeNascimento = new DateTime(2001, 12, 09);
novaPF.Endereco = novoEndPF;

PessoaFisica metodosPF = new PessoaFisica();
Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine(@$"
===========================================
|   Bem vindo ao sistema de cadastro de   |
|     Pessoa Jurídidica e Pessoa Física   |                                          
===========================================
");
Console.ResetColor();
Util.MetodosUteis("Sistema Inicializando", 500, 5);
Console.Clear();
string? opcoes; 

do 
{
Console.ForegroundColor = ConsoleColor.DarkYellow;   
Console.WriteLine(@$"
 Escolha uma opção abaixo
==========================
|    1 - Pessoa Jurídica |
|    2 - Pessoa Física   |
|    0 - Sair            |                                     
==========================
");
Console.ResetColor();

opcoes = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta; 
Thread.Sleep(500);
 
    switch (opcoes)
    {
        
        case "1":

Console.WriteLine(@$"
Nome da Empresa: {novaPJ.Nome}
Razão Social: {novaPJ.RazaoSocial}
Rendimento Mensal: {novaPJ.Rendimento.ToString("C", new CultureInfo("pt-BR"))}
Cnpj: {novaPJ.Cpnj}
Cnpj: {(metodosPJ.ValidarCnpj(novaPJ.Cpnj) ? "Válido" : "Inválido")}
Endereço: {novaPJ.Endereco.Logradouro} nº{novaPJ.Endereco.Numero}
Complemento: {novaPJ.Endereco.Complemento}
Comercial: {novaPJ.Endereco.EnderecoComercial}
Imposto à ser pago: {metodosPJ.PagarImposto(novaPJ.Rendimento).ToString("C", new CultureInfo("pt-BR"))}");


    
        
        break;
        case "2":
            
Console.WriteLine(@$"
Nome: {novaPF.Nome}
CPF: {novaPF.cpf}
Data de Nascimento: {novaPF.DataDeNascimento}
Rendimento Mensal: {novaPF.Rendimento.ToString("C", new CultureInfo("pt-BR"))}
Endereço: {novaPF.Endereco.Logradouro} nº{novaPF.Endereco.Numero}
Complemento: {novaPF.Endereco.Complemento}
Comercial: {(novaPF.Endereco.EnderecoComercial ? "Sim" : "Não")}
Imposto à ser pago: {metodosPF.PagarImposto(novaPF.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
Maior de idade: {(metodosPF.ValidarDataNasc(novaPF.DataDeNascimento) ? "Sim" : "Não")}
Maior de idade - string: {(metodosPF.ValidarDataNasc("09/12/2001") ? "Sim" : "Não")}");

 
        break; 
        case "0":
    Console.WriteLine($"Obrigada por utilizar nosso sistema.");
        break;
        default:
    Console.WriteLine($"Opção inválida, escolha outra.");
        break;
       
    }
Console.ResetColor();
Thread.Sleep(500);
Console.ForegroundColor = ConsoleColor.Green;     
Console.WriteLine("Aperte ENTER para continuar");
Console.ReadLine(); 
Console.ResetColor();
Console.Clear();

}while (opcoes != "0");
Console.Clear();
Util.MetodosUteis("Sistema Finalizando", 500, 5);



