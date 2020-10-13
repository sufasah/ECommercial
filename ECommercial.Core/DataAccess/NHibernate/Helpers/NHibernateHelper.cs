using System;
using NHibernate;

namespace ECommercial.Core.DataAccess.NHibernate.Helpers
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;

        public virtual ISessionFactory SessionFactory{
            get{return _sessionFactory ?? (_sessionFactory=InitializeFactory());}
        }
        protected abstract ISessionFactory InitializeFactory();

        public virtual ISession openSession(){
            return SessionFactory.OpenSession();
        }

        public void Dispose()// TO USE USING(var x = this.openSession()){} KEYWORD WITHOUT COMPILER ERROR
        {
            
            GC.SuppressFinalize(this);
        }
    }
}