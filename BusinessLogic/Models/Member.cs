using BusinessLogic.Entities;
using BusinessLogic.Helpers;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
	public class Member : IModel<MemberEntity>
	{
		private readonly Storage storage;

		public Member()
		{
			storage = new Storage();
		}

		public MemberEntity Create(MemberEntity entity)
		{
			storage.Create(entity.ToArray());

			return entity;
		}

		public MemberEntity Read(int id)
		{
			// get data using storage.Read(id);

			// Add data to MemberEntity
			var member = new MemberEntity();

			return member;
		}

		public List<MemberEntity> Read()
		{
			var list = new List<MemberEntity>();

			foreach (string[] record in storage.Read())
			{
				var member = new MemberEntity();

				// add data to member

				list.Add(member);
			}

			return list;
		}

		public MemberEntity Update(int id, MemberEntity entity)
		{
			storage.Update(id, entity.ToArray());

			return entity;
		}

		public void Delete(int id)
		{
			storage.Delete(id);
		}
	}
}