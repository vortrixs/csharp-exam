using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
	interface IModel
	{
		public void Create();

		// Returns a single record
		public void Read(int id);

		// Returns all records
		public void Read();

		public void Update();

		public void Delete();
	}
}
