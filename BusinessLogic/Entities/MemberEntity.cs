using BusinessLogic.Enums;
using System;

namespace BusinessLogic.Entities
{
	public class MemberEntity
	{
		public int Id { get; private set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public Gender Gender { get; set; }

		public int Age { get; set; }

		public int ZipCode { get; set; }

		public DateTime MembershipStart { get; set; } = new DateTime();

		public DateTime? MembershipEnd { get; set; } = null;

		public virtual SubscriptionEntity Subscription { get; set; }
	}
}
