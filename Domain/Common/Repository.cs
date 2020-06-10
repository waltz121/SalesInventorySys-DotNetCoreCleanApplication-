using Domain.Utils;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Domain.Common
{
    public abstract class Repository<T>
        where T: AggregateRoot
    {
        public T Find(Expression<Func<T, bool>> predicate)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Query<T>()
                    .Where(predicate).FirstOrDefault();
            }
        }

        public List<T> ListFind(Expression<Func<T, bool>> predicate)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Query<T>()
                    .Where(predicate).ToList();
            }
        }

        public void Save(T aggregateRoot)
        {
            using(ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(aggregateRoot);
                transaction.Commit();
            }
        }
    }
}
