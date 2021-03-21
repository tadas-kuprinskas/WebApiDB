using RestAPIDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIDB.Interfaces
{
    public interface IKitchenItemService<T> where T: Item
    {
        List<T> GetAll();
        T GetById(int id);
        void DeleteById(int id);
        void Create(T t);
        void Update(int id, T t);

    }
}
