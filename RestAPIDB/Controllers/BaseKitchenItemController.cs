using Microsoft.AspNetCore.Mvc;
using RestAPIDB.Data;
using RestAPIDB.Interfaces;
using RestAPIDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseKitchenItemController<T> : ControllerBase where T : KitchenItem
    {
        private readonly IKitchenItemRepository<T> _kitchenItemRepository;

        public BaseKitchenItemController(IKitchenItemRepository<T> kitchenItemRepository)
        {
            _kitchenItemRepository = kitchenItemRepository;
        }

        [HttpPost]
        public void Create(T t)
        {
            _kitchenItemRepository.Create(t);
        }

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            _kitchenItemRepository.DeleteById(id);
        }

        [HttpGet]
        public Task<List<T>> GetAll()
        {
            return _kitchenItemRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Task<T> GetById(int id)
        {
            return _kitchenItemRepository.GetById(id);
        }

        [HttpPut]
        public void Update(int id, T t)
        {
            _kitchenItemRepository.Update(id, t);
        }
    }
}
