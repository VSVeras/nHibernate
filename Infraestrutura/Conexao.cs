using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Infraestrutura
{
    public class Conexao
    {
        public static ISessionFactory Criar()
        {

            var sessionFactory = Fluently.Configure()
                 .Mappings(x => x.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly())
                   .Conventions.Add<CustomPrimaryKeyConvention>()
                    .Conventions.Add<CustomForeignKeyConvention>()
                    .Conventions.Add<CustomManyToManyTableNameConvention>())
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(conexao => conexao.FromConnectionStringWithKey("dbConnectioString"))
                .ShowSql()
                )
                .ExposeConfiguration(configuracao =>
                {
                    configuracao.SetProperty("command_timeout", "45");
                    new SchemaExport(configuracao).Drop(true, true);
                    new SchemaExport(configuracao).Create(true, true);
                })
                .BuildSessionFactory();

            return sessionFactory;
        }
    }
}