using System.Reflection;
using FluentNHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using System.Configuration;
using ECommercial.Core.DataAccess.NHibernate.Helpers;

namespace ECommercial.DataAccess.Helpers
{
    public class PostgreSqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(PostgreSQLConfiguration.Standard
            .ConnectionString(ConfigurationManager.ConnectionStrings["ECommercialContext"].ToString()))
            .Mappings(t=>t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}