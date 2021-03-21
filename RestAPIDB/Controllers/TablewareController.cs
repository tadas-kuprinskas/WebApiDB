using Microsoft.AspNetCore.Mvc;
using RestAPIDB.Controllers;
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
    public class TablewareController : BaseKitchenItemController<Tableware>
    {
        public TablewareController(IKitchenItemService<Tableware> context) : base(context)
        {
        }
    }
}
