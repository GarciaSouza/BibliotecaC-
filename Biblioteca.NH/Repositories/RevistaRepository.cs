using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using System.Collections.Generic;

namespace Biblioteca.NH.Repositories
{
    public class RevistaRepository : IRevistaRepository
    {
        public void Add(Revista entity)
        {
            using (NHibernate.ISession session = NHibernateHelper.OpenSession())
            {
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }
        }

        public IList<Revista> GetAll()
        {
            using (NHibernate.ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Revista>().List();
            }
        }

        public Revista GetById(int id)
        {
            using (NHibernate.ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Revista>().Where(l => l.ID == id).SingleOrDefault();
            }
        }

        public void Remove(Revista entity)
        {
            using (NHibernate.ISession session = NHibernateHelper.OpenSession())
            {
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            }
        }

        public void Update(Revista entity)
        {
            using (NHibernate.ISession session = NHibernateHelper.OpenSession())
            {
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(entity);
                    transaction.Commit();
                }
            }
        }
    }
}
