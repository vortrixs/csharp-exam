using BusinessLogic.Enums;

namespace BusinessLogic.Entities
{
	public class SubscriptionEntity
	{
		public int Id { get; private set; }

		public SubscriptionTypes Type { get; set; }

		public int Price { get; set; }

		public PaymentPeriod PaymentPeriod { get; set; }

		public int MemberId { get; set; }

		public virtual MemberEntity Member { get; set; }
	}
}
