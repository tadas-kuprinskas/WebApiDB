using Microsoft.AspNetCore.Mvc;
using RestAPIDB.Data;
using RestAPIDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KitchenItemController<T> : ControllerBase where T : Item
    {
        private readonly DataContext _context;

        public KitchenItemController(DataContext context)
        {
            _context = context;
        }

        //    [HttpGet]
        //    public List<T> GetAll()
        //    {
        //        return _context.K
        //    }
    }
}
