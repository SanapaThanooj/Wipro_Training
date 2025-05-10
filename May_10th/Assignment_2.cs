using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_10th
{
     class ChatBot
    {
        public void Respond(String Greeting) 
        {
            Console.WriteLine("Hello! How can I assist you today?" + Greeting);
        }
        public void Respond(String question, bool formal)
        {
            if (formal)
            { 
                Console.WriteLine("thanks you for Question. Regarding :" + question);
            }
            else
            {
                Console.WriteLine("cool question" + question);
            }

        }
        public String Respond( int number)
        {
            return "Your number is " + number + ".Here's a fun fact:" + number +" squared is" + number * number;
        }
    }
}

using May_10th;

class Program
{
    static void Main(string[] args)
    {
        ChatBot chatBot = new ChatBot();
        chatBot.Respond("Hello");
        chatBot.Respond("Explain inheritance in c#?", true);
        chatBot.Respond("5");

    }
}