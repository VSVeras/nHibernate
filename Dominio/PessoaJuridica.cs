
namespace Dominio
{
    public class PessoaJuridica : Pessoa
    {
        public virtual string Cnpj { get; set; }
        public virtual string WebSite { get; set; }
    }
}
