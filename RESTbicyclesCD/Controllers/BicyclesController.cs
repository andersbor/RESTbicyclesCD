using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RESTbicyclesCD.Managers;
using RESTbicyclesCD.Models;

namespace RESTbicyclesCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {
        private readonly  BicyclesManager _manager = new BicyclesManager();

        // GET: api/<BicyclesController>
        [HttpGet]
        public IEnumerable<Bicycle> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BicyclesController>/5
        [HttpGet("{id}")]
        public Bicycle Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BicyclesController>
        // kommentar
        [HttpPost]
        public Bicycle Post([FromBody] Bicycle value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BicyclesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BicyclesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
