using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
	class MemberEntity
	{
		public int ID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Gender { get; set; }

		public int Age { get; set; }

		public int ZipCode { get; set; }

		public DateTime MembershipStart { get; set; }

		public DateTime? MembershipEnd { get; set; } = null;

		public int? SubscriptionEntityID { get; set; } = null;
	}
}
