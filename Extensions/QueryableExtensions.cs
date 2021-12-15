using System;
using System.Linq;
using System.Linq.Expressions;

namespace meet_up_4_git.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ConditionalWhere<T>(
            this IQueryable<T> source,
            Func<bool> condition,
            Expression<Func<T, bool>> predicate)
        {
            if (condition()) 
                return source.Where(predicate);
            

            return source;
        }

        public static IQueryable<T> ConditionalWhere<T>(
            this IQueryable<T> source,
            bool condition,
            Expression<Func<T, bool>> predicate)
        {
            if (condition)
                return source.Where(predicate);
            

            return source;
        }

        public static IOrderedQueryable<T> ConditionalOrderBy<T, TKey>(
            this IQueryable<T> source,
            bool condition,
            bool isDescending,
            Expression<Func<T, TKey>> predicate)
        {
            if (!condition)
                return source as IOrderedQueryable<T>;

            if (isDescending)
                return source.OrderByDescending(predicate);

            return source.OrderBy(predicate);
        }
    }
}