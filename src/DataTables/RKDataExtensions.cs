using RazorKit.DataTables.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RazorKit.DataTables
{
    /// <summary>
    /// Includes ToDataResult extension
    /// </summary>
    public static class RKDataExtensions
    {
        /// <summary>
        /// Executes IQueryable list and returns DataResult includes data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="request"></param>
        /// <returns>DataResult</returns>
        public static DataResult<T> ToDataResult<T>(this IQueryable<T> query, DataRequest request) where T : class
        {
            var result = new DataResult<T>
            {
                draw = request.Draw
            };
            result.recordsTotal = result.recordsFiltered = query.Count();

            foreach (var item in request.Filters)
            {
                var exp = GetExpression<T>(item.Operand, item.Field, item.Value);
                if (exp != null)
                {
                    query = query.Where(exp);
                }
            }

            var listExp = new List<FilterDef>();

            if (!string.IsNullOrEmpty(request.Search?.Value))
            {
                foreach (var item in request.Columns.Where(a => a.Searchable))
                {
                    ParameterExpression param = Expression.Parameter(typeof(T), "t");
                    MemberExpression member = Expression.Property(param, item.Name);
                    var operand = member.Type == typeof(string) ? DataOperand.Contains : DataOperand.Equal;
                    listExp.Add(new FilterDef { Operand = operand, Field = item.Name, Value = request.Search.Value, Operator = DataOperator.Or });
                }
            }

            foreach (var item in request.Columns.Where(a => a.Searchable == true && !string.IsNullOrEmpty(a.Search.Value)))
            {
                ParameterExpression param = Expression.Parameter(typeof(T), "t");
                MemberExpression member = Expression.Property(param, item.Name);
                var operand = member.Type == typeof(string) ? DataOperand.Contains : DataOperand.Equal;
                listExp.Add(new FilterDef { Operand = operand, Field = item.Name, Value = item.Search.Value, Operator = DataOperator.And });
            }

            if (listExp.Any())
            {
                Expression<Func<T, bool>> exp = null;
                exp = ExpressionBuilder.GetExpression<T>(listExp);
                if (exp != null) query = query.Where(exp);
            }

            if (listExp.Any() || request.Filters.Any())
            {
                result.recordsFiltered = query.Count();
            }

            if (request.Draw > 0)
            {
                if (!request.Order.Any())
                {
                    query = query.OrderBy(request.Columns[0].Name ?? request.Columns[1].Name);
                }
                else
                {
                    query = request.Order[0].Dir != "asc"
                        ? query.OrderByDescending<T>(request.Columns[request.Order[0].Column].Name)
                        : query.OrderBy<T>(request.Columns[request.Order[0].Column].Name);

                    for (var i = 1; i < request.Order.Count(); i++)
                    {
                        query = request.Order[i].Dir != "asc"
                            ? query.ThenByDescending<T>(request.Columns[request.Order[i].Column].Name)
                            : query.ThenBy<T>(request.Columns[request.Order[i].Column].Name);
                    }
                }

                if (request.Length != -1)
                {
                    query = query.Skip(request.Start).Take(request.Length);
                }
            }

            result.data = query.ToList();
            return result;
        }

        private static Expression<Func<T, bool>> GetExpression<T>(DataOperand operand, string field, string value)
        {
            return ExpressionBuilder
                .GetExpression<T>(new FilterDef
                {
                    Operand = operand,
                    Field = field,
                    Value = value,
                });
        }

        private static IOrderedQueryable<T> OrderBy<T>(
            this IQueryable<T> query,
            string memberName)
        {
            return query.OrderByCreate<T>(memberName, nameof(OrderBy));
        }

        private static IOrderedQueryable<T> ThenBy<T>(
            this IQueryable<T> query,
            string memberName)
        {
            return query.OrderByCreate<T>(memberName, nameof(ThenBy));
        }

        private static IOrderedQueryable<T> OrderByDescending<T>(
            this IQueryable<T> query,
            string memberName)
        {
            return query.OrderByCreate<T>(memberName, nameof(OrderByDescending));
        }

        private static IOrderedQueryable<T> ThenByDescending<T>(
            this IQueryable<T> query,
            string memberName)
        {
            return query.OrderByCreate<T>(memberName, nameof(ThenByDescending));
        }

        private static IOrderedQueryable<T> OrderByCreate<T>(this IQueryable<T> query, string memberName, string direction)
        {
            var typeParams = new ParameterExpression[] { Expression.Parameter(typeof(T), "") };
            var pi = typeof(T).GetProperty(memberName);
            return (IOrderedQueryable<T>)query.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable),
                    direction,
                    new Type[] { typeof(T), pi.PropertyType },
                    query.Expression,
                    Expression.Lambda(Expression.Property(typeParams[0], pi), typeParams))
            );
        }
    }
}
