using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	interface IModel<IEntity>
	{
		public IEntity Create();

		// Returns a single record
		public IEntity Read(int id);

		// Returns all records
		public List<IEntity> Read();

		public IEntity Update();

		public void Delete();
	}
}
