using Indexer_Exceptions;
using Indexer_Exceptions.Controllers;
using Indexer_Exceptions.Helpers.Constant;

#region Indexer
//Library library = new();

//Book book = new();

//book.Name = "test1";

//book.Id = 1;


//library[0] = book;

//Console.WriteLine(library[0].Name);
#endregion



//int a = 5;
//int b = 0;
//int result = a / b;

//Console.WriteLine(result);



try
{
    int[] nums = new int[0];
    nums[2] = 100;

    int a = 5;
    int b = 0;
    int result = a / b;

    Console.WriteLine(result);

}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Salam Aqshin bey");
}





//static void Register (string username , string password)
//{
//    bool isSucces = false;

//	try
//	{
//        if (username == "semed123")
//        {
//            Console.WriteLine(AccountMessages.RegisterSuccess);
//            isSucces = true;
//        }
//        else
//        {
//            throw new RegisterFailedExceptions();
//        }
//    }
//	catch (Exception ex)
//	{
//        Console.WriteLine(ex.Message);
//	}
//    finally
//    {
//        SendEmail(isSucces);
//    }
//}



//Register("semed12","assads");



static void SendEmail(bool isSucces)
{
    if (isSucces)
    {
        Console.WriteLine(AccountMessages.RegisterEmailSuccess);
    }
    else
    {
        Console.WriteLine(AccountMessages.RegisterEmailFailed);
    }
}



static void ShowText(string text)
{
    try
    {
        if (text is null)
        {
            throw new ArgumentNullException();
        }

        else
        {
            Console.WriteLine(text);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

//ShowText(null);

PersonController personController = new();
personController.GetById();