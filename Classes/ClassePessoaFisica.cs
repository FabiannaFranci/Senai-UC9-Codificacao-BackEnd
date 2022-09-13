namespace Projetos_Senai.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string? cpf { get; set; }
        public DateOnly DataDeNascimento { get; set; }
        
    }
}