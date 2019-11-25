using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
	public class Subscription : IModel<SubscriptionEntity>
	{
		public SubscriptionEntity Create(SubscriptionEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public SubscriptionEntity Read(int id)
		{
			throw new NotImplementedException();
		}

		public List<SubscriptionEntity> Read()
		{
			throw new NotImplementedException();
		}

		public SubscriptionEntity Update(int id, SubscriptionEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
