using System;

namespace Lab3_3
{
	class Program
	{
		static void Main()
		{
            	Console.WriteLine("Enter the operation sign:");
           	char op = (char)Console.Read();
            	Console.ReadLine();
            
            	bool ok = true;
            	switch (op)
            	{
                	case '+': Console.WriteLine("Add operation"); break;
                	case '-': Console.WriteLine("Subtraction operation"); break;
                	case '*': Console.WriteLine("Multiplication operation"); break;
                	case '/': Console.WriteLine("Division operation"); break;
                	default: ok = false; break;
            	}
            
            	if (ok == false) Console.WriteLine("Invalid operation");
            	Console.ReadKey();
        	}
	}
}
