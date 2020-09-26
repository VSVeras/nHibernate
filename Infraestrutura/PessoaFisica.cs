using FluentNHibernate.Mapping;

namespace Infraestrutura
{
    public class PessoaFisica : SubclassMap<Dominio.PessoaFisica>
    {
        public PessoaFisica()
        {
            Map(x => x.Cpf).Not.Nullable().Length(14);
            Map(x => x.Nacionalidade).Length(255);
        }
    }
}