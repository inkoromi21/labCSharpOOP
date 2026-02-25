using System;
using System.Collections.Generic;

namespace OOPLabs
{
  public class Animal
  {
    private string nickname;
    private int age;
    private string habitat;
    private string typeOfFood;
    private string color;

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

    public virtual string GetAnimalType()
    {
      return "Animal";
    }
  }

  public class Mammal : Animal
  {
    private bool hasFur;

    public Mammal(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, bool animalHasFur) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      hasFur = animalHasFur;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nHas fur: {hasFur}";
    }

    public override string GetAnimalType()
    {
      return "Mammal";
    }
  }

  public class Bird : Animal
  {
    private float wingSpan;

    public Bird(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, float animalWingSpan) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      wingSpan = animalWingSpan;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nWing span: {wingSpan}";
    }

    public override string GetAnimalType()
    {
      return "Bird";
    }
  }

  public class Fish : Animal
  {
    private string waterType;

    public Fish(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, string animalWaterType) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      waterType = animalWaterType;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nWater type: {waterType}";
    }

    public override string GetAnimalType()
    {
      return "Fish";
    }
  }

  public class Reptile : Animal
  {
    private bool isVenomous;

    public Reptile(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, bool animalIsVenomous) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      isVenomous = animalIsVenomous;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nIs venomous: {isVenomous}";
    }

    public override string GetAnimalType()
    {
      return "Reptile";
    }
  }

  public class Amphibian : Animal
  {
    private int skinMoisture;

    public Amphibian(string animalNickname, int animalAge, string animalHabitat, string animalTypeOfFood, string animalColor, int animalSkinMoisture) : base(animalNickname, animalAge, animalHabitat, animalTypeOfFood, animalColor)
    {
      skinMoisture = animalSkinMoisture;
    }

    public override string GetInfo()
    {
      return base.GetInfo() + $"\nSkin moisture: {skinMoisture}";
    }

    public override string GetAnimalType()
    {
      return "Amphibian";
    }
  }

  public sealed class AnimalManager
  {
    private static AnimalManager _instance;
    private List<Animal> _animals;

    private AnimalManager()
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

    public void AddAnimal(Animal theAddedAnimal)
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
      for (int animalIndex = 0; animalIndex < _animals.Count; ++animalIndex)
      {
        Console.WriteLine($"\n--- Animal #{animalIndex + 1} ({_animals[animalIndex].GetAnimalType()}) ---");
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
      string typeOfFoodThisAnimal;
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
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          typeOfFoodThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter has fur (y/n): ");
          propertyThisAnimal = Console.ReadLine().ToLower();

          if (propertyThisAnimal == "y" || propertyThisAnimal == "yes")
          {
            newAnimal = new Mammal(nicknameThisAnimal, ageThisAnimal, habitatThisAnimal, typeOfFoodThisAnimal, colorThisAnimal, true);
          }
          else if (propertyThisAnimal == "n" || propertyThisAnimal == "no")
          {
            newAnimal = new Mammal(nicknameThisAnimal, ageThisAnimal, habitatThisAnimal, typeOfFoodThisAnimal, colorThisAnimal, false);
          }
        }

        else if (modeSelection == 2)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          typeOfFoodThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter wing span: ");
          propertyThisAnimal = Console.ReadLine();

          newAnimal = new Bird(nicknameThisAnimal, ageThisAnimal, habitatThisAnimal, typeOfFoodThisAnimal, colorThisAnimal, float.Parse(propertyThisAnimal));
        }

        else if (modeSelection == 3)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          typeOfFoodThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter water type: ");
          propertyThisAnimal = Console.ReadLine();

          newAnimal = new Fish(nicknameThisAnimal, ageThisAnimal, habitatThisAnimal, typeOfFoodThisAnimal, colorThisAnimal, propertyThisAnimal);
        }

        else if (modeSelection == 4)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          typeOfFoodThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter is venomous (y/n):: ");
          propertyThisAnimal = Console.ReadLine().ToLower();

          if (propertyThisAnimal == "y" || propertyThisAnimal == "yes")
          {
            newAnimal = new Reptile(nicknameThisAnimal, ageThisAnimal, habitatThisAnimal, typeOfFoodThisAnimal, colorThisAnimal, true);
          }
          else if (propertyThisAnimal == "n" || propertyThisAnimal == "no")
          {
            newAnimal = new Reptile(nicknameThisAnimal, ageThisAnimal, habitatThisAnimal, typeOfFoodThisAnimal, colorThisAnimal, false);
          }
        }

        else if (modeSelection == 5)
        {
          Console.Write("\nEnter nickname: ");
          nicknameThisAnimal = Console.ReadLine();

          Console.Write("\nEnter age: ");
          ageThisAnimal = int.Parse(Console.ReadLine());

          Console.Write("\nEnter habitat: ");
          habitatThisAnimal = Console.ReadLine();

          Console.Write("\nEnter type of food: ");
          typeOfFoodThisAnimal = Console.ReadLine();

          Console.Write("\nEnter color: ");
          colorThisAnimal = Console.ReadLine();

          Console.Write("\nEnter skin moisture: ");
          propertyThisAnimal = Console.ReadLine();

          newAnimal = new Amphibian(nicknameThisAnimal, ageThisAnimal, habitatThisAnimal, typeOfFoodThisAnimal, colorThisAnimal, int.Parse(propertyThisAnimal));
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
          manager.AddAnimal(newAnimal);
          Console.WriteLine("\n--- animal information ---");
          Console.WriteLine(newAnimal.GetInfo());
        }
      }
    }
  }
}