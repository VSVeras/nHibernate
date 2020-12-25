using FluentNHibernate.Mapping;

namespace Infraestrutura
{
    public class Grupo : ClassMap<Dominio.Grupo>
    {
        public Grupo()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable().Length(255);
            Map(x => x.Descricao).Length(255);
            Map(x => x.DataCadastro).Not.Nullable();
            HasManyToMany(x => x.Pessoas);
        }
    }
}
