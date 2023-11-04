using System;
using Indexer_Exceptions.Models;

namespace Indexer_Exceptions.Services.Interface
{
	public interface IPersonService
	{
		Person GetById(int? id);
	}
}

