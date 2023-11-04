using System;
using Indexer_Exceptions_Homeworks.Models.Helpers.Constant;

namespace Indexer_Exceptions_Homeworks.Models
{
	public class FactorialExceptions : Exception
    {
		public FactorialExceptions(string message) : base(message)
		{

		}

		public FactorialExceptions() : this (FactorialMessage.OperationIsIncorrect)
		{

		}
		
	}
}

