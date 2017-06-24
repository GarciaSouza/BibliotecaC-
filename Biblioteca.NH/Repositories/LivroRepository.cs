using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using System.Collections.Generic;

namespace Biblioteca.NH.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public void Add(Livro entity)
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

        public IList<Livro> GetAll()
        {
            using (NHibernate.ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Livro>().List();
            }
        }

        public Livro GetById(int id)
        {
            using (NHibernate.ISession session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Livro>().Where(l => l.ID == id).SingleOrDefault();
            }
        }

        public void Remove(Livro entity)
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

        public void Update(Livro entity)
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
