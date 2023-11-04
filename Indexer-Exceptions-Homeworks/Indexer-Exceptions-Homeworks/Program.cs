
using System;
using Indexer_Exceptions_Homeworks;
using Indexer_Exceptions_Homeworks.Models;
using Indexer_Exceptions_Homeworks.Models.Helpers.Constant;




DataList<Person> employees = new();

employees.Add(new Person { Id = 1, FullName = "Semed Huseynov", Age = 26 });
employees.Add(new Person { Id = 2, FullName = " Temirli Besaret", Age = 25 });
employees.Add(new Person { Id = 3, FullName = "Nergiz Mammadzada", Age = 25 });

var employee = employees.GetById(2);

//Console.WriteLine(employee.FullName +" " + employee.Age);





static void GetFactorial(int n)
{
    try
    {
        int number = 1;
        while (n != 1)
        {
            number = number * n;
            n = n - 1;
        }
        if (number > 1)
        {
            Console.WriteLine(number);
        }
        else
        {
            throw new(FactorialMessage.OperationIsIncorrect);
        }

    }
    catch (Exception ex)
    {
       Console.WriteLine(ex.Message);
    }
}


//GetFactorial(-4);
   