using Projetos_Senai.Interface;

namespace Projetos_Senai.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }
        public DateOnly DataDeNascimento { get; set; }

        public override float PagarImposto (float Rendimento){
            if(Rendimento <= 1500){
                return 0 ;
            }
            else if (Rendimento >= 1501 && Rendimento <= 3500){
                return Rendimento * 0.02f;
            }
            else if (Rendimento >= 3501 && Rendimento <= 6000){
                return Rendimento * 0.035f;
            }
            else {
                return Rendimento * 0.05f;
            }
        }

        public bool ValidarDataNasc(DateTime DataDeNascimento)
        {
            throw new NotImplementedException();
        }
    }
}