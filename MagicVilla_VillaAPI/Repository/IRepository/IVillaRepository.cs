using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository
    {
        Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>> filter = null);
        Task<Villa> GetAsync(Expression<Func<Villa,bool>> filter = null, bool tracked=true);
        Task CreateAsync(Villa entity);
        Task UpdateAsync(Villa entity);
        Task UpdatePartialAsync(Villa entity);
        Task Remove(Villa entity);
        Task SaveAsync();
    }
}
