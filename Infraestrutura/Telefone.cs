using FluentNHibernate.Mapping;

namespace Infraestrutura
{
    public class Telefone : ClassMap<Dominio.Telefone>
    {
        public Telefone()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.CodigoDDD).Not.Nullable().Length(255);
            Map(x => x.Numero).Not.Nullable();
            References(x => x.Pessoa);
        }
    }
}
