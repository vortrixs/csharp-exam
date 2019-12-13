using BusinessLogic.Entities;
using BusinessLogic.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace FitnessWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MembersController : ControllerBase
	{
		private readonly FitnessApiContext context;
		public MembersController(FitnessApiContext context)
		{
			this.context = context;
		}

		// GET: api/Members
		[HttpGet]
		public List<MemberEntity> Get()
		{
			return context.Members.ToList();
		}

		// GET: api/Members/5
		[HttpGet("{id}")]
		public MemberEntity Get(int id)
		{
			return context.Members.Find(id);
		}

		// POST: api/Members
		[HttpPost]
		public MemberEntity Post([FromBody] MemberEntity entity)
		{
			context.Members.Add(entity);

			context.SaveChanges();

			return entity;
		}

		// PATCH: api/Members/5
		[HttpPatch("{id}")]
		public MemberEntity Patch(int id, [FromBody] JsonPatchDocument<MemberEntity> entity)
		{
			var member = context.Members.Find(id);

			entity.ApplyTo(member);

			context.Members.Update(member);

			context.SaveChanges();

			return member;
		}

		// DELETE: api/Members/5
		[HttpDelete("{id}")]
		public object Delete(int id)
		{
			MemberEntity entity = context.Members.Find(id);

			context.Members.Remove(entity);

			context.SaveChanges();

			return NoContent();
		}
	}
}
