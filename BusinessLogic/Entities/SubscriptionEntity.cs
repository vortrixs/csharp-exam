using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
	public class SubscriptionEntity : IEntity
	{
		public int ID { get; set; }

		public SubscriptionTypes Type { get; set; }

		public int Price { get; set; }

		public SubscriptionPaymentPeriod PaymentPeriod { get; set; }

		public int MemberEntityID { get; set; }

		public string[] ToArray()
		{
			throw new NotImplementedException();
		}
	}
}
