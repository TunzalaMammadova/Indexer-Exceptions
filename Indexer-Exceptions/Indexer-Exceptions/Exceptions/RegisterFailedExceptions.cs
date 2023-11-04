using System;
using Indexer_Exceptions.Helpers.Constant;

namespace Indexer_Exceptions
{
	public class RegisterFailedExceptions : Exception
	{
		public RegisterFailedExceptions(string msj) : base(msj)
		{

		}

		public RegisterFailedExceptions() : this(AccountMessages.RegisterFailed)
		{

		}
	}
}
	
		