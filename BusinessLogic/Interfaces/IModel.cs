using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	interface IModel<IEntity>
	{
		public void Create();

		// Returns a single record
		public IEntity Read(int id);

		// Returns all records
		public List<IEntity> Read();

		public void Update();

		public void Delete();
	}
}
