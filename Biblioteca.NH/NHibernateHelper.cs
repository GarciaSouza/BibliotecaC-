using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;

namespace Biblioteca.NH
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            Configuration config = new Configuration().Configure();

            ISessionFactory sessionFactory = Fluently
                .Configure(config)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
                .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}
