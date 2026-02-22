using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
  public class Animal
  {
    public string nickname;
    public int age;
    public string habitat;
    public string typeOfFood;
    public string color;

    public Animal(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor)
    {
      nickname = animalNickname;
      age = animalAge;
      habitat = animalHabitat;
      typeOfFood = animalTypeOfFood;
      color = animalColor;
    }

    public virtual string GetInfo()
    {
      return $"nickname: {nickname}\nage: {age}\nhabitat: {habitat}\ntype of food: {typeOfFood}\ncolor: {color}";
    }

    public virtual string GetType()
    {
      return "Animal";
    }
  }

  public class Mammal : Animal
  {
    public bool hasFur;

    public Mammal(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, bool AnimalHasFur) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      hasFur = AnimalHasFur;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nHas fur: {hasFur}";
    }

    public override string GetType()
    {
      return "Mammal";
    }
  }

  public class Bird : Animal
  {
    public float wingSpan;

    public Bird(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, float AnimalWingSpan) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      wingSpan = AnimalWingSpan;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nWing span: {wingSpan}";
    }

    public override string GetType()
    {
      return "Bird";
    }
  }

  public class Fish : Animal
  {
    public string waterType;

    public Fish(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, string AnimalWaterType) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      waterType = AnimalWaterType;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nWater type: {waterType}";
    }

    public override string GetType()
    {
      return "Fish";
    }
  }

  public class Reptile : Animal
  {
    public bool isVenomous;

    public Reptile(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, bool AnimalIsVenomous) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      isVenomous = AnimalIsVenomous;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nIs venomous: {isVenomous}";
    }

    public override string GetType()
    {
      return "Reptile";
    }
  }

  public class Amphibian : Animal
  {
    public int skinMoisture;

    public Amphibian(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, int AnimalSkinMoisture) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      skinMoisture = AnimalSkinMoisture;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nSkin moisture: {skinMoisture}";
    }

    public override string GetType()
    {
      return "Amphibian";
    }
  }

  public sealed class AnimalManager
  {
    public static AnimalManager _instance;
    public List<Animal> _animals;

    public AnimalManager()
    {
      _animals = new List<Animal>();
    }

    public static AnimalManager Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new AnimalManager();
        }
        return _instance;
      }
    }

    public void AddDocument(Animal theAddedAnimal)
    {
      _animals.Add(theAddedAnimal);
      Console.WriteLine("\nAnimal added successfully!");
    }

    public void ShowAllAnimals()
    {
      if (_animals.Count == 0)
      {
        Console.WriteLine("\nNo animals in the list.");
        return;
      }

      Console.WriteLine("\n=== All animal ===");
      for (int animalIndex = 0; animalIndex < _animals.Count; animalIndex++)
      {
        Console.WriteLine($"\n--- Animal #{animalIndex + 1} ({_animals[animalIndex].GetType()}) ---");
        Console.WriteLine(_animals[animalIndex].GetInfo());
      }
    }
  }

  class Program
  {
    static void Main()
    {
      AnimalManager manager = AnimalManager.Instance;
      int modeSelection;
      string nicknameThisAnimal;
      int ageThisAnimal;
      string habitatThisAnimal;
      string colorThisAnimal;
      string propertyThisAnimal;

      Console.Write("Task 2 - OOP in C#\n\r");

      while (true)
      {
        Console.Write("\nselect operating mode: \n1) Mammal\n2) Bird\n3) Fish\n4) Reptile\n5) Amphibian\n6) Show all animal\n0) Exit\nMode selection: ");
        modeSelection = int.Parse(Console.ReadLine());

        if (modeSelection == 0)
        {
          Console.WriteLine("Program terminated.");
          break;
        }

        Animal newAnimal = null;

        if (modeSelection == 1)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter has fur (y/n): ");
          propertyThisAnimal = Console.ReadLine();

          if (propertyThisAnimal == "y")
          {
            newAnimal = new Mammal(nicknameThisAnimal, ageThisAnimal, nicknameThisAnimal, habitatThisAnimal, colorThisAnimal, true);
          }
          else if (propertyThisAnimal == "n")
          {
            newAnimal = new Mammal(nicknameThisAnimal, ageThisAnimal, nicknameThisAnimal, habitatThisAnimal, colorThisAnimal, false);
          }
        }

        else if (modeSelection == 2)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter wing span: ");
          propertyThisAnimal = Console.ReadLine();

          newAnimal = new Bird(nicknameThisAnimal, ageThisAnimal, nicknameThisAnimal, habitatThisAnimal, colorThisAnimal, float.Parse(propertyThisAnimal));
        }

        else if (modeSelection == 3)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter wing span: ");
          propertyThisAnimal = Console.ReadLine();

          newAnimal = new Fish(nicknameThisAnimal, ageThisAnimal, nicknameThisAnimal, habitatThisAnimal, colorThisAnimal, propertyThisAnimal);
        }

        else if (modeSelection == 4)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter wing span: ");
          propertyThisAnimal = Console.ReadLine();

          if (propertyThisAnimal == "y")
          {
            newAnimal = new Reptile(nicknameThisAnimal, ageThisAnimal, nicknameThisAnimal, habitatThisAnimal, colorThisAnimal, true);
          }
          else if (propertyThisAnimal == "n")
          {
            newAnimal = new Reptile(nicknameThisAnimal, ageThisAnimal, nicknameThisAnimal, habitatThisAnimal, colorThisAnimal, false);
          }
        }

        else if (modeSelection == 5)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter wing span: ");
          propertyThisAnimal = Console.ReadLine();

          newAnimal = new Amphibian(nicknameThisAnimal, ageThisAnimal, nicknameThisAnimal, habitatThisAnimal, colorThisAnimal, int.Parse(propertyThisAnimal));
        }

        else if (modeSelection == 6)
        {
          manager.ShowAllAnimals();
          continue;
        }

        else
        {
          Console.WriteLine("\nInvalid mode selected!");
          continue;
        }

        if (newAnimal != null)
        {
          manager.AddDocument(newAnimal);
          Console.WriteLine("\n--- document information ---");
          Console.WriteLine(newAnimal.GetInfo());
        }
      }
    }
  }
}