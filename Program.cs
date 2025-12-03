// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");
Console.WriteLine("Which file do you want to run? (1-12)");
string? input = Console.ReadLine();

switch (input) 
{
    case "1":
       one.Run();
        break;
    case "2":
        two.Run();
        break;
    case "3":
  three.Run();
        break;
    case "4":
       four.Run();
        break;
    case "5":
       five.Run();
        break;
    case "6":
  six.Run();
        break;
    case "7":
       seven.Run();
        break;
    case "8":
        eight.Run();
        break;
    case "9":
  nine.Run();
        break;
    case "10":
       ten.Run();
        break;
    case "11":
        eleven.Run();
        break;
    case "12":
  twelve.Run();
        break;
    default:
        Console.WriteLine("Invalid file");
        break;
}


