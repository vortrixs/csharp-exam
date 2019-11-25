using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Models
{
	public class Member : IModel<MemberEntity>
	{
		public MemberEntity Create()
		{
			throw new NotImplementedException();
		}

		public MemberEntity Read(int id)
		{
			throw new NotImplementedException();
		}

		public List<MemberEntity> Read()
		{
			throw new NotImplementedException();
		}

		public MemberEntity Update()
		{
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}
	}
}