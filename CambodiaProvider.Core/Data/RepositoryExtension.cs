using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CambodiaProvider.Core.Data
{
    public static class RepositoryExtension
    {
        public static IEnumerable<T> LoadAll<T>(this IRepository<T> rs) where T : BaseEntity
        {
            return rs.Table.AsEnumerable();
        }

        public static IEnumerable<T> Where<T>(this IRepository<T> rs, Func<T, bool> predicate) where T : BaseEntity
        {
            return rs.Table.Where(predicate);
        }

        public static T GetSingle<T>(this IRepository<T> rs, Func<T, bool> predicate) where T : BaseEntity
        {
            return rs.Table.SingleOrDefault(predicate);
        }

        public static T GetFirst<T>(this IRepository<T> rs, Func<T, bool> predicate) where T : BaseEntity
        {
            return rs.Table.FirstOrDefault(predicate);
        }

        public static void Delete<T>(this IRepository<T> rs, object id) where T : BaseEntity
        {
            T entityToDelete = rs.GetById(id);
            if (entityToDelete != null)
            {
                rs.Delete(entityToDelete);
            }
        }

        public static IQueryable<T> Get<T>(
            this IRepository<T> rs,
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "") where T : BaseEntity
        {
            IQueryable<T> query = rs.Table;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = rs.Expand(query, includeProperty.Trim());
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }
    }
}
