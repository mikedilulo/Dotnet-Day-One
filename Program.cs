using System;
using System.Collections.Generic;

namespace rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Game!");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($"Welcome to the game {name}, now lets play!");
      bool validating = true;
      while (validating)
      {
        Console.WriteLine("Press the Q key to exit out of the game or press any other key to play");
        //NOTE ConsoleKeyInfo - Logs out of the game 
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Q)
        {
          validating = false;
        }
        else
        {
          Console.Clear();
          Console.WriteLine("What is your choice?");
          string choice = Console.ReadLine();
          List<string> playerChoice = new List<string>();
          playerChoice.Add("Rock");
          playerChoice.Add("Paper");
          playerChoice.Add("Scissors");
          Random rnd = new Random();
          int computerOption = rnd.Next(playerChoice.Count);
          Dictionary<int, string> computerChoice = new Dictionary<int, string>() {
          {0, "rock"},
          {1, "scissors"},
          {2, "paper"}
          //NOTE I would have to do all the comparisons 
      };
          //NOTE Computer Option is what is assigned to the random number
          if (choice == computerChoice[computerOption])
          {
            Console.WriteLine("You have tied the game");
            validating = false;
          }
          else
          {
            Console.WriteLine("Yo");
          }
        }
      }
    }
  }
}
