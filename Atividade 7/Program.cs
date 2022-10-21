
using System.Globalization;
using Projetos_Senai.Classes;

Endereco novoEndPJ = new Endereco();
PessoaJuridica novaPJ = new PessoaJuridica();
PessoaJuridica metodosPJ = new PessoaJuridica();

Endereco novoEndPF = new Endereco();
PessoaFisica novaPF = new PessoaFisica();
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
//Console.Clear();
string? opcoesDoMenu;
bool dataValida;
bool cpfValido;
bool cnpjValido;
string? verificarSeEnderecoEComercialPF;
string? verificarSeEnderecoEComercialPJ;


do
{
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(@$"
 Escolha uma opção abaixo
==========================
|    1 - Pessoa Física   |
|    2 - Pessoa Jurídica |
|    0 - Sair            |
==========================
");
Console.ResetColor();

opcoesDoMenu = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Thread.Sleep(500);

    switch (opcoesDoMenu)
    {
        case "1":
        string? opcaoMenuPF;
        do
        {
            Console.WriteLine(@$"
Escolha uma opção abaixo
======================================
|    1 - Cadastrar Pessoa Física     |
|    2 - Acessar lista               |
|    0 - Sair                        |
======================================
");
        opcaoMenuPF = Console.ReadLine();

            switch(opcaoMenuPF){
                case "1":
                Console.Write("Digite seu nome: ");
                novaPF.Nome = Console.ReadLine();
                Console.Write("Digite seu CPF: ");
                do
                {
                    string? cpfQuestion = Console.ReadLine();
                    cpfValido = novaPF.ValidarCpf(cpfQuestion);
                    if(cpfValido){
                        novaPF.cpf = cpfQuestion;
                        Console.WriteLine(cpfValido);
                    }
                    else{
                        Console.WriteLine("CPF inválido, tente novamente.");
                    }


                } while (cpfValido == false);

                Console.Write("Data de Nascimento DD/MM/AAAA: ");


                do
                {
                    string? dataNasc = Console.ReadLine();
                    dataValida = novaPF.ValidarDataNasc(dataNasc);
                    if(dataValida){
                        novaPF.DataDeNascimento = Convert.ToDateTime(dataNasc);


                    }
                    else{
                        Console.WriteLine("Data inválida, escreva outra");
                    }

                } while (dataValida == false);

                Console.Write("Digite seu rendimento mensal");
                novaPF.Rendimento = float.Parse(Console.ReadLine());

                Console.Write("Digite seu endereço:");
                novoEndPF.Logradouro = Console.ReadLine();

                Console.Write("Nº:");
                novoEndPF.Numero = Console.ReadLine();

                Console.Write("Complemento:");
                novoEndPF.Complemento = Console.ReadLine();

                do
                { 
                    Console.Write("Comercial? [S/N]:  ");
                    verificarSeEnderecoEComercialPF = Console.ReadLine().ToLower();
                    if(verificarSeEnderecoEComercialPF  == "s")
                    {
                        novoEndPF.EnderecoComercial = true;
                    }
                    else if(verificarSeEnderecoEComercialPF  == "n")
                    {
                        novoEndPF.EnderecoComercial = false;
                    }
                    else
                    {
                        Console.WriteLine("Inválido, tente novamente.");
                    }
                    
                } while (verificarSeEnderecoEComercialPF  != "s" || verificarSeEnderecoEComercialPF != "n");

            break;

                case "2":
                    Console.WriteLine(@$"
                    Nome: {novaPF.Nome}
                    CPF: {novaPF.cpf}
                    Data de Nascimento: {novaPF.DataDeNascimento}
                    Rendimento: {novaPF.Rendimento}
                    Imposto à pagar: {metodosPF.PagarImposto(novaPF.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
                    Endereço Comercial?: {(novoEndPF.EnderecoComercial? "Sim" : "Não")}
                    ");
                            
                break;

                }
        }while (opcaoMenuPF != "0");
        break;
    
        case "2":
        string? opcaoMenuPJ;
        do
        {
                       Console.WriteLine(@$"
Escolha uma opção abaixo
======================================
|    1 - Cadastrar Pessoa Jurídica   |
|    2 - Acessar lista               |
|    0 - Sair                        |
======================================
");
            opcaoMenuPJ = Console.ReadLine();
            switch (opcaoMenuPJ)
            {
                case "1":
                Console.WriteLine("Digite seu nome: ");
                novaPJ.Nome = Console.ReadLine();
                Console.WriteLine("Razão Social: ");
                novaPJ.RazaoSocial = Console.ReadLine();
                Console.WriteLine("Rendimento Mensal: ");
                novaPJ.Rendimento = float.Parse(Console.ReadLine());
                
                do
                {
                    Console.WriteLine("Digite seu Cnpj: ");
                    string? cnpjQuestion = Console.ReadLine();
                    cnpjValido = novaPJ.ValidarCnpj(cnpjQuestion);
                    if (cnpjValido == true){
                        novaPJ.Cpnj = cnpjQuestion;
                    }
                    else{
                        Console.WriteLine("Cnpj inválido, digite novamente");
                    }
                }while (cnpjValido == false);
                Console.WriteLine("Digite seu endereço: ");
                novoEndPJ.Logradouro = Console.ReadLine();
                Console.WriteLine("Nº: ");
                novoEndPJ.Numero = Console.ReadLine();
                Console.WriteLine("Complemento: ");
                novoEndPJ.Complemento = Console.ReadLine();
                do
                {
                    
                    Console.WriteLine("Endereço é comercial?: ");
                    verificarSeEnderecoEComercialPJ = Console.ReadLine().ToLower();
                    if(verificarSeEnderecoEComercialPJ == "s"){
                        novoEndPJ.EnderecoComercial = true;
                    }
                    else if(verificarSeEnderecoEComercialPJ == "n"){
                        novoEndPJ.EnderecoComercial = false;
                    }
                    else{
                        System.Console.WriteLine("Inválido, tente novamente.");
                    }
                    
                    
                } while (verificarSeEnderecoEComercialPJ != "s"|| verificarSeEnderecoEComercialPJ  != "n");
                
                



                
            break;

            case "2":
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
            }
        }while (opcaoMenuPJ == "0");
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


}while (opcoesDoMenu != "0");
Console.Clear();
Util.MetodosUteis("Sistema Finalizando", 500, 5);



