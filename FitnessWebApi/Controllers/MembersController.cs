using BusinessLogic.Entities;
using BusinessLogic.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using Microsoft.Data.Sqlite;

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
		public List<MemberEntity> Get([FromQuery] string sort)
		{
			List<MemberEntity> members = context.Members.ToList();

			switch (sort)
			{
				case "age":
					members = members.OrderBy(m => m.Age).ToList();
					break;
				case "zipcode":
					members = members.OrderBy(m => m.ZipCode).ToList();
					break;
			}
				

			return members;
		}

		// GET: api/Members/5
		[HttpGet("{id}")]
		public object Get(int id)
		{
			MemberEntity member = context.Members.Find(id);

			if (null == member)
				return NotFound();

			return member;
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
			MemberEntity member = context.Members.Find(id);

			context.Members.Remove(member);

			context.SaveChanges();

			return NoContent();
		}

		// GET: api/Members
		[HttpGet("search")]
		public object Search([FromQuery] Dictionary<string, string> parameters)
		{
			if (0 == parameters.Count())
				return BadRequest();

			List<SqliteParameter> sqlParams = new List<SqliteParameter>();

			string search = "";

			foreach (KeyValuePair<string,string> row in parameters)
			{
				string append = " AND ";

				if (false == search.ToString().Contains("WHERE"))
				{
					append = " WHERE ";
				}

				sqlParams.Add(new SqliteParameter($"@filter{row.Key}Value", row.Value));

				search += append + $"{row.Key}=@filter{row.Key}Value";
			}

			IQueryable<MemberEntity> sql = context.Members.FromSqlRaw(
				"SELECT * FROM `members`" + search, sqlParams.ToArray()
			);

			return sql.ToList();
		}
	}
}
