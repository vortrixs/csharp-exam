using BusinessLogic.Entities;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FitnessWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MembersController : ControllerBase
	{
		// GET: api/Members
		[HttpGet]
		public List<MemberEntity> Get()
		{
			return new Member().Read();
		}

		// GET: api/Members/5
		[HttpGet("{id}")]
		public MemberEntity Get(int id)
		{
			return new Member().Read(id);
		}

		// POST: api/Members
		[HttpPost]
		public MemberEntity Post([FromBody] MemberEntity entity)
		{
			return new Member().Create(entity);
		}

		// PUT: api/Members/5
		[HttpPut("{id}")]
		public MemberEntity Put(int id, [FromBody] MemberEntity entity)
		{
			return new Member().Update(id, entity);
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			new Member().Delete(id);
		}
	}
}
