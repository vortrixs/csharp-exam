using BusinessLogic.Entities;
using BusinessLogic.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Http;

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
		[ProducesResponseType(StatusCodes.Status200OK)]
		[HttpGet]
        public List<SubscriptionEntity> Get()
        {
			return context.Subscriptions.ToList();
        }

		// GET: api/Subscriptions/5
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpGet("{id}")]
        public object Get(int id)
        {
			SubscriptionEntity sub = context.Subscriptions.Find(id);

			if (null == sub)
				return NotFound();

			return sub;
        }

		// POST: api/Subscriptions
		[ProducesResponseType(StatusCodes.Status200OK)]
		[HttpPost]
        public SubscriptionEntity Post([FromBody] SubscriptionEntity entity)
        {
			context.Subscriptions.Add(entity);

			context.SaveChanges();

			return entity;
        }

		// PATCH: api/Subscriptions/5
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpPatch("{id}")]
        public object Patch(int id, [FromBody] JsonPatchDocument<SubscriptionEntity> entity)
        {
			SubscriptionEntity sub = context.Subscriptions.Find(id);

			if (null == sub)
				return NotFound();

			entity.ApplyTo(sub);

			context.Subscriptions.Update(sub);

			context.SaveChanges();

			return sub;
        }

		// DELETE: api/ApiWithActions/5
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[HttpDelete("{id}")]
        public object Delete(int id)
        {
			SubscriptionEntity sub = context.Subscriptions.Find(id);

			if (null == sub)
				return NotFound();

			context.Subscriptions.Remove(sub);

			context.SaveChanges();

			return NoContent();
        }
    }
}
