using System.Transactions;
using System.Reflection;
using FluentNHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using ECommercial.Core.DataAccess.NHibernate.Helpers;
using NHibernate.Tool.hbm2ddl;

namespace ECommercial.DataAccess.NHibarnate.Helpers
{
    public class PostgreSqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            var connectionString = "Server=127.0.0.1;Port=5432;Database=ecommercial;User Id=postgres;Password=123;";
            return Fluently.Configure().Database(PostgreSQLConfiguration.Standard
            .ConnectionString(connectionString).ShowSql())
            .Mappings(t=>t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .BuildSessionFactory();
        }
    }
}