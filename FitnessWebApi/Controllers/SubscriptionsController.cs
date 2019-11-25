using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Entities;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitnessWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        // GET: api/Subscriptions
        [HttpGet]
        public List<SubscriptionEntity> Get()
        {
			return new Subscription().Read();
        }

        // GET: api/Subscriptions/5
        [HttpGet("{id}")]
        public SubscriptionEntity Get(int id)
        {
			return new Subscription().Read(id);
        }

        // POST: api/Subscriptions
        [HttpPost]
        public SubscriptionEntity Post([FromBody] SubscriptionEntity entity)
        {
			return new Subscription().Create(entity);
        }

        // PUT: api/Subscriptions/5
        [HttpPut("{id}")]
        public SubscriptionEntity Put(int id, [FromBody] SubscriptionEntity entity)
        {
			return new Subscription().Update(id, entity);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
			new Subscription().Delete(id);
        }
    }
}
