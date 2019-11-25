using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
	public class MemberEntity : IEntity
	{
		public int ID { get; private set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public MemberGender Gender { get; set; }

		public int Age { get; set; }

		public int ZipCode { get; set; }

		public DateTime MembershipStart { get; set; }

		public DateTime? MembershipEnd { get; set; } = null;

		public int? SubscriptionEntityID { get; set; } = null;

		public MemberEntity() { }

		public MemberEntity(string firstname, string lastname, MemberGender gender, int age, int zipcode, DateTime membershipstart)
		{
			FirstName = firstname;
			LastName = lastname;
			Gender = gender;
			Age = age;
			ZipCode = zipcode;
			MembershipStart = membershipstart;
		}

		public string[] ToArray()
		{
			string[] data =
			{
				FirstName,
				LastName,
				Gender.ToString(),
				Age.ToString(),
				ZipCode.ToString(),
				MembershipStart.ToString(),
				MembershipEnd.ToString(),
				SubscriptionEntityID.ToString(),
			};

			return data;
		}
	}
}
