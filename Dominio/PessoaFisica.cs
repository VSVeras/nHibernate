
namespace Dominio
{
    public class PessoaFisica : Pessoa
    {
        public virtual string Cpf { get; set; }
        public virtual string Nacionalidade { get; set; }
    }
}
