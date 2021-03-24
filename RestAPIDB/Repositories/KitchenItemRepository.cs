using Microsoft.EntityFrameworkCore;
using RestAPIDB.Data;
using RestAPIDB.Interfaces;
using RestAPIDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIDB.Repositories
{
    public class KitchenItemRepository<T> : IKitchenItemRepository<T> where T : KitchenItem
    {
        private readonly DataContext _context;

        public KitchenItemRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Create(T t)
        {
            _context.Set<T>().Add(t);  //DbSet<TEntity> instance
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var kitchenItem = _context.Set<T>().FirstOrDefault(i => i.Id == id);

            if (kitchenItem == null)
            {
                throw new KeyNotFoundException();
            }
            _context.Set<T>().Remove(kitchenItem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var kitchenItem = await _context.Set<T>().FirstOrDefaultAsync(i => i.Id == id);

            if (kitchenItem == null)
            {
                throw new KeyNotFoundException();
            }

            return kitchenItem;
        }

        public async Task Update(int id, T t)
        {
            var kitchenItemToReplace = await _context.Set<T>().FirstOrDefaultAsync(i => i.Id == id);

            if (kitchenItemToReplace == null)
            {
                throw new KeyNotFoundException();
            }
            kitchenItemToReplace.Id = t.Id;
        }
    }
}
