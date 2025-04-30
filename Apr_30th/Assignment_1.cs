//Given a month number (1—12), print its name.
using System;

public class helloworld
{
    public static void Main(string[] args)
    {
       Console.Write("Month Number:");
       int month = Convert.ToInt32(Console.ReadLine());
       
       switch(month)
       {
            case 1:
                Console.Write("January");
                break;
            case 2:
                Console.Write("february ");
                break;
            case 3:
                Console.Write("March");
                break;    
           case 4:
                Console.Write("April");
                break;
            case 5:
                Console.Write("May");
                break;
            case 6:
                Console.Write("June");
                break;
            case 7:
                Console.Write("July");
                break;
            case 8:
                Console.Write("August");
                break;
            case 9:
                Console.Write("September ");
                break;
            case 10:
                Console.Write("October");
                break;
            case 11:
                Console.Write("November");
                break;
            case 12:
                Console.Write("December");
                break;
            default:
                Console.Write("Invalid");
                break;
       }
        
    }
    
}