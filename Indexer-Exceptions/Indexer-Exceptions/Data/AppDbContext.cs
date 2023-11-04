using System;
using Indexer_Exceptions.Models;

namespace Indexer_Exceptions.Data
{
	public class AppDbContext
	{
		public Person[] People()
		{
			return new Person[]
			{
				new Person
				{
					Id = 1,
					Fullname = "Meryem Eliyeva",
					Age = 23
				},

				new Person
				{
					Id = 2,
					Fullname = "Metanet Abbasova",
					Age = 21
				},

				new Person
				{
					Id = 100,
					Fullname = "Haciaga Ehmedov",
					Age = 28
				}

			};
		}
	}
}

