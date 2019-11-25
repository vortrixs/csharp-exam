using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Helpers
{
	internal class Storage
	{
		private string Connection;

		public Storage(string connection)
		{
			Connection = connection;
		}

		public int Create()
		{
			return 0;
		}

		public List<string[]> Read()
		{
			return new List<string[]>();
		}

		public List<string> Read(int id)
		{
			return new List<string>();
		}

		public int Update()
		{
			return 0;
		}

		public bool Delete()
		{
			return true;
		}
	}
}
