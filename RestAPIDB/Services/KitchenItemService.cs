using RestAPIDB.Data;
using RestAPIDB.Interfaces;
using RestAPIDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIDB.Services
{
    public class KitchenItemService<T> : IKitchenItemService<T> where T : Item
    {
        private readonly DataContext _context;

        public KitchenItemService(DataContext context)
        {
            _context = context;
        }

        public void Create(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var kitchenItem = _context.Set<T>().FirstOrDefault(i => i.Id == id);

            if (kitchenItem == null)
            {
                throw new KeyNotFoundException();
            }
            _context.Remove(kitchenItem);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var kitchenItem = _context.Set<T>().FirstOrDefault(i => i.Id == id);

            if (kitchenItem == null)
            {
                throw new KeyNotFoundException();
            }

            return kitchenItem;
        }

        public void Update(int id, T t)
        {
            var kitchenItemToReplace = _context.Set<T>().FirstOrDefault(i => i.Id == id);

            if (kitchenItemToReplace == null)
            {
                throw new KeyNotFoundException();
            }
            kitchenItemToReplace.Id = t.Id;
        }
    }
}
