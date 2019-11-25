using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
	class SubscriptionEntity
	{
		internal enum Types 
		{ 
			Day, 
			Night, 
			Weekend, 
			AllInclusive,
		}

		internal enum PaymentPeriods
		{
			Monthly, 
			Quarterly, 
			Yearly,
		}

		public int ID { get; set; }

		public int Type { get; set; }

		public double Price { get; set; }

		public int PaymentPeriod { get; set; }

		public int MemberEntityID { get; set; }
	}
}
