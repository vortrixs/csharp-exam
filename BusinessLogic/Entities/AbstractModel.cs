using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
	public abstract class AbstractModel
	{
		public int ID { get; private set; }

		abstract public void Create();

		abstract public void Read();

		abstract public void Update();

		abstract public void Delete();
	}
}
