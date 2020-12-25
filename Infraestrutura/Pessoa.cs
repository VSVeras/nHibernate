using FluentNHibernate.Mapping;

namespace Infraestrutura
{
    public class Pessoa : ClassMap<Dominio.Pessoa>
    {
        public Pessoa()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome).Not.Nullable().Length(255);
            Map(x => x.Endereco).Length(255);
            Map(x => x.Cep).Length(255);
            Map(x => x.Email).Length(255);
            Map(x => x.DataCadastro).Not.Nullable();
            Map(x => x.Status).CustomType<int>();
            References(x => x.Departamento).Not.Nullable();
            HasManyToMany(x => x.Grupos);
            HasMany(x => x.Telefones).Cascade.All();
        }
    }
}
