using System;
using System.Collections.Generic;
using ParkAnimals.Models;

namespace Tracker
{
  public class Program
  {
  public static List<Animals> AnimalList = new List<Animals>(){};
    public static void Main()
    {

      Console.WriteLine("Would you like to add and animal or show the animals? [add or show]" );
      string answer = Console.ReadLine();
      if ( answer == "add")
      {
        AddAnimal();
        Main();
      }
      else if (answer == "show")
      {
        Console.WriteLine("See the Animals in the Park");
        ShowAnimals();
      }
      else {
        Console.WriteLine("We Can't help you");
      }
    }
      static void AddAnimal()
      {
        Console.WriteLine("Enter the name of the new Park Animal: ");
        string newAnimalType = Console.ReadLine();
      
        Console.WriteLine("Enter the amount of this animal in the park: ");
        string stringInputAmount = Console.ReadLine();
        int inputAmount = int.Parse(stringInputAmount);
        Console.WriteLine("Is this animal safe? [yes or no] ");
        string inputSafe = Console.ReadLine();

        Animals inputAnimal = new Animals(newAnimalType, inputAmount, inputSafe);
        AnimalList.Add(inputAnimal);
      }
      static void ShowAnimals()
      {
        foreach (Animals creatures in AnimalList)
        {
          Console.WriteLine("----------------------------");
          Console.WriteLine("Animal: " + creatures.GetAnimalType());
          Console.WriteLine("Type of Animal: " + creatures.GetAnimalAmount());
          Console.WriteLine("Is this creature safe? " + creatures.GetSafe());
        }
      }

      

    }
  }
