using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Drakon.Core.Common.Collections
{
    /// <summary>
    /// Generic repository contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<TEntity> : IDisposable
    {
        /// <summary>
        /// Deletes existing entity
        /// </summary>
        /// <param name="entityToDelete"></param>
        void Delete(TEntity entityToDelete);

        /// <summary>
        /// Deletes entity with existed id
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);

        /// <summary>
        /// Returns items with applied filter
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        /// <summary>
        /// Returns item with existed id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(object id);
        
        /// <summary>
        /// Insert new item
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Updates existing entity
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void Update(TEntity entityToUpdate);

        /// <summary>
        /// Inserts new item to repository
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id">Item's identificator</param>
        void Insert(TEntity entity, object id);
    }
}
