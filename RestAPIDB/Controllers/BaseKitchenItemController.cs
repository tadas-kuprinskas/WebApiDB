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
        private readonly IKitchenItemService<T> _kitchenItemService;

        public BaseKitchenItemController(IKitchenItemService<T> kitchenItemService)
        {
            _kitchenItemService = kitchenItemService;
        }

        [HttpPost]
        public void Create(T t)
        {
            _kitchenItemService.Create(t);
        }

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            _kitchenItemService.DeleteById(id);
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return _kitchenItemService.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _kitchenItemService.GetById(id);
        }

        [HttpPut]
        public void Update(int id, T t)
        {
            _kitchenItemService.Update(id, t);
        }
    }
}
