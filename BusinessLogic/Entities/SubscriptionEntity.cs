using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
	class SubscriptionEntity
	{
		internal enum Types 
		{ 
			Day = 0,
			Night = 1,
			Weekend = 2,
			AllInclusive = 3,
		}

		internal enum PaymentPeriods
		{
			Monthly = 0, 
			Quarterly = 1, 
			Yearly = 2,
		}

		public int ID { get; set; }

		public int Type { get; set; }

		public double Price { get; set; }

		public int PaymentPeriod { get; set; }

		public int MemberEntityID { get; set; }
	}
}
