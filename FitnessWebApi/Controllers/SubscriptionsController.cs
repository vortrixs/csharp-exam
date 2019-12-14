using BusinessLogic.Entities;
using BusinessLogic.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

namespace FitnessWebApi.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
		private readonly FitnessApiContext context;
		
		public SubscriptionsController(FitnessApiContext context)
		{
			this.context = context;
		}

        // GET: api/Subscriptions
        [HttpGet]
        public List<SubscriptionEntity> Get()
        {
			return context.Subscriptions.ToList();
        }

        // GET: api/Subscriptions/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
			SubscriptionEntity sub = context.Subscriptions.Find(id);

			if (null == sub)
				return NotFound();

			return sub;
        }

        // POST: api/Subscriptions
        [HttpPost]
        public SubscriptionEntity Post([FromBody] SubscriptionEntity entity)
        {
			context.Subscriptions.Add(entity);

			context.SaveChanges();

			return entity;
        }

        // PATCH: api/Subscriptions/5
        [HttpPatch("{id}")]
        public SubscriptionEntity Patch(int id, [FromBody] JsonPatchDocument<SubscriptionEntity> entity)
        {
			SubscriptionEntity sub = context.Subscriptions.Find(id);

			entity.ApplyTo(sub);

			context.Subscriptions.Update(sub);

			context.SaveChanges();

			return sub;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public object Delete(int id)
        {
			SubscriptionEntity sub = context.Subscriptions.Find(id);

			context.Subscriptions.Remove(sub);

			context.SaveChanges();

			return NoContent();
        }
    }
}
