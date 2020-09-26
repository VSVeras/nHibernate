using FluentNHibernate.Mapping;

namespace Infraestrutura
{
    public class Departamento : ClassMap<Dominio.Departamento>
    {
        public Departamento()
        {
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable().Length(255);
            Map(x => x.Descricao).Length(255);
            Map(x => x.DataCadastro).Not.Nullable();
            HasMany(m => m.Pessoas);
        }
    }
}
