using FluentNHibernate.Mapping;

namespace Infraestrutura
{
    public class PessoaJuridica : SubclassMap<Dominio.PessoaJuridica>
    {
        public PessoaJuridica()
        {
            Map(x => x.Cnpj).Not.Nullable().Length(18);
            Map(x => x.WebSite).Length(255);
        }
    }
}
