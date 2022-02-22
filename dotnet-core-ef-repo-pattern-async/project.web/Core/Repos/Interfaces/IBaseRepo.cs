using project.web.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.web.Core.Repos.Interfaces
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();
        /// <summary>
        /// Get by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(Guid id);
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="entity"></param>
        Task InsertAsync(T entity);

        /// <summary>
        /// Insert collection
        /// </summary>
        /// <param name="entities"></param>
        Task InsertManyAsync(ICollection<T> entities);
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        Task UpdateAsync(T entity);
        /// <summary>
        /// Update collection
        /// </summary>
        /// <param name="entities"></param>
        Task UpdateManyAsync(ICollection<T> entities);
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        Task DeleteAsync(Guid id);
    }
}
