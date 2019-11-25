using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Models;
using BusinessLogic.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitnessWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        // GET: api/Members
        [HttpGet]
        public MemberEntity Get()
        {
			return new Member().Read();
        }

        // GET: api/Members/5
        [HttpGet("{id}", Name = "Get")]
        public Member Get(int id)
        {
			return new Member().Read(id);
        }

        // POST: api/Members
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Members/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
