using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Helpers
{
	internal class Storage
	{
		public Storage()
		{
			// Set up connection
		}

		public int Create(string[] data)
		{
			return 0;
		}

		public List<string[]> Read()
		{
			return new List<string[]>();
		}

		public string[] Read(int id)
		{
			string[] arr = { "" };

			return arr;
		}

		public int Update(int id, string[] data)
		{
			return 0;
		}

		public bool Delete(int id)
		{
			return true;
		}
	}
}
