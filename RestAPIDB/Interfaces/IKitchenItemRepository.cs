using RestAPIDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIDB.Interfaces
{
    public interface IKitchenItemRepository<T> where T: KitchenItem
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task DeleteById(int id);
        Task Create(T t);
        Task Update(int id, T t);

    }
}
