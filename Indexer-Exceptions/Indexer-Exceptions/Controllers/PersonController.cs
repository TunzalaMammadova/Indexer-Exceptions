using System;
using Indexer_Exceptions.Services;
using Indexer_Exceptions.Services.Interface;

namespace Indexer_Exceptions.Controllers
{
	public class PersonController
	{
		private readonly IPersonService _personService;

		public PersonController()
		{
			_personService = new PersonService();
		}

		public void GetById()
		{
			try
			{
                Console.WriteLine("Add person id");
                int id = int.Parse(Console.ReadLine());

                var reesponse = _personService.GetById(id);

                var res = $"{reesponse.Id} - {reesponse.Fullname} - {reesponse.Age}";

                Console.WriteLine(res);
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

