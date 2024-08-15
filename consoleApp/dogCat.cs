using System;
public class dogCat
{
  public static void main(String[] args)
  {
    //ourAnimals Array
    string animalSpecies = "";
    string animalId = "";
    string animalAge = "";
    string animalPhysicalDescription = "";
    string animalPersonalityDescription = "";
    string animalNickname = "";

    //data entry variable
    int maxPets = 8;
    string? readResult;
    string menuSelection = "";
    int petCount = 0;
    string anotherPet = "y";
    bool validEntry = false;
    int petAge = 0;

    //array to store runtime data
    string[,] ourAnimals = new string[maxPets, 6];

    for (int i = 0; i < maxPets; i++)
    {
      switch (i)
      {
        case 0:
          animalSpecies = "dog";
          animalId = "d1";
          animalAge = "2";
          animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
          animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
          animalNickname = "lola";
          break;
        case 1:
          animalSpecies = "dog";
          animalId = "d2";
          animalAge = "9";
          animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
          animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
          animalNickname = "loki";
          break;
        case 2:
          animalSpecies = "cat";
          animalId = "c3";
          animalAge = "1";
          animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
          animalPersonalityDescription = "friendly";
          animalNickname = "Puss";
          break;
        case 3:
          animalSpecies = "cat";
          animalId = "c4";
          animalAge = "?";
          animalPhysicalDescription = "";
          animalPersonalityDescription = "";
          animalNickname = "";
          break;
        default:
          animalSpecies = "";
          animalId = "";
          animalAge = "";
          animalPhysicalDescription = "";
          animalPersonalityDescription = "";
          animalNickname = "";
          break;
      }

      ourAnimals[i, 0] = "ID #: " + animalId;
      ourAnimals[i, 1] = "Species: " + animalSpecies;
      ourAnimals[i, 2] = "Age: " + animalAge;
      ourAnimals[i, 3] = "Nickname: " + animalNickname;
      ourAnimals[i, 4] = "PhysicalDescription: " + animalPhysicalDescription;
      ourAnimals[i, 5] = "PersonalityDescription: " + animalPersonalityDescription;
    }

    do
    {
      Console.Clear();
      Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
      Console.WriteLine(" 1. List all of our current pet information");
      Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
      Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
      Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
      Console.WriteLine(" 5. Edit an animal’s age");
      Console.WriteLine(" 6. Edit an animal’s personality description");
      Console.WriteLine(" 7. Display all cats with a specified characteristic");
      Console.WriteLine(" 8. Display all dogs with a specified characteristic");
      Console.WriteLine();
      Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

      readResult = Console.ReadLine();
      if (readResult != null)
      {
        menuSelection = readResult.ToLower();
      }

      switch (menuSelection)
      {
        case "1":
          for (int i = 0; i < maxPets; i++)
          {
            if (ourAnimals[i, 0] != "ID #: ")
            {
              Console.WriteLine();
              for (int j = 0; j < 6; j++)
              {
                Console.WriteLine(ourAnimals[i, j].ToString());
              }
            }
          }
          Console.WriteLine("\n\rPress the Enter key to continue.");
          readResult = Console.ReadLine();
          break;

        case "2":
          anotherPet = "y";
          petCount = 0;
          for (int i = 0; i < maxPets; i++)
          {
            if (ourAnimals[i, 0] != "ID #: ")
            {
              petCount += 1;
            }
          }

          if (petCount < maxPets)
          {
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
          }

          while (anotherPet == "y" && petCount < maxPets)
          {
            // get species (cat or dog) - string animalSpecies is a required field 
            do
            {
              Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalSpecies = readResult.ToLower();
                if (animalSpecies != "dog" && animalSpecies != "cat")
                {
                  validEntry = false;
                }
                else
                {
                  validEntry = true;
                }
              }
            } while (validEntry == false);
            animalId = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

            // get the pet's age. can be ? at initial entry.
            do
            {
              Console.WriteLine("Enter the pet's age or enter ? if unknown");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalAge = readResult;
                if (animalAge != "?")
                {
                  validEntry = int.TryParse(animalAge, out petAge);
                }
                else
                {
                  validEntry = true;
                }
              }
            } while (validEntry == false);

            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
            do
            {
              Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalPhysicalDescription = readResult.ToLower();
                if (animalPhysicalDescription == "")
                {
                  animalPhysicalDescription = "tbd";
                }
              }
            } while (validEntry == false);

            // get a description of the pet's personality - animalPersonalityDescription can be blank.
            do
            {
              Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalPersonalityDescription = readResult.ToLower();
                if (animalPersonalityDescription == "")
                {
                  animalPersonalityDescription = "tbd";
                }
              }
            } while (validEntry == false);

            // get the pet's nickname. animalNickname can be blank.
            do
            {
              Console.WriteLine("Enter a nickname for the pet");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalNickname = readResult.ToLower();
                if (animalNickname == "")
                {
                  animalNickname = "tbd";
                }
              }
            } while (animalNickname == "");

            ourAnimals[petCount, 0] = "ID #: " + animalId;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            petCount = petCount + 1;

            if (petCount < maxPets)
            {
              Console.WriteLine("Do you want to enter info for another pet (y/n)");
              do
              {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                  anotherPet = readResult.ToLower();
                }
              } while (anotherPet != "y" && anotherPet != "n");
            }
          }

          if (petCount >= maxPets)
          {
            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
          }
          break;

        case "3":
          for (int i = 0; i < maxPets; i++)
          {
            if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ")
            {
              Console.WriteLine($"Please enter an age for the pet with {ourAnimals[i, 0]}");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalAge = readResult;
                ourAnimals[i, 2] = "Age: " + animalAge;
              }

              Console.WriteLine($"Please enter a physical description for the pet with {ourAnimals[i, 0]}");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalPhysicalDescription = readResult;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
              }
            }
          }

          Console.WriteLine("The animal ages and physical descriptions are now complete.");
          Console.WriteLine("Press the Enter key to continue.");
          readResult = Console.ReadLine();
          break;

        case "4":
          for (int i = 0; i < maxPets; i++)
          {
            if (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: ")
            {
              Console.WriteLine($"Please enter a nickname for the pet with {ourAnimals[i, 0]}");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalNickname = readResult;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
              }

              Console.WriteLine($"Please enter a personality description for the pet with {ourAnimals[i, 0]}");
              readResult = Console.ReadLine();
              if (readResult != null)
              {
                animalPersonalityDescription = readResult;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
              }
            }
          }

          Console.WriteLine("The animal nicknames and personality descriptions are now complete.");
          Console.WriteLine("Press the Enter key to continue.");
          readResult = Console.ReadLine();
          break;

        case "5":
          Console.WriteLine("Enter the ID of the pet whose age you want to edit: ");
          readResult = Console.ReadLine();
          if (readResult != null)
          {
            string? searchID = readResult;
            for (int i = 0; i < maxPets; i++)
            {
              if (ourAnimals[i, 0].Contains(searchID))
              {
                Console.WriteLine($"Current age of {searchID}: {ourAnimals[i, 2]}");
                Console.WriteLine("Enter the new age: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                  animalAge = readResult;
                  ourAnimals[i, 2] = "Age: " + animalAge;
                }
              }
            }
          }
          Console.WriteLine("Press the Enter key to continue.");
          readResult = Console.ReadLine();
          break;

        case "6":
          Console.WriteLine("Enter the ID of the pet whose personality description you want to edit:");
          readResult = Console.ReadLine();
          if (readResult != null)
          {
            string? searchId = readResult;
            for (int i = 0; i < maxPets; i++)
            {
              if (ourAnimals[i, 0].Contains(searchId))
              {
                Console.WriteLine($"Current personality of {searchId}: {ourAnimals[i, 5]}");
                Console.WriteLine("Enter the new personality description:");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                  animalPersonalityDescription = readResult;
                  ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                }
              }
            }
          }
          Console.WriteLine("Press the Enter key to continue.");
          readResult = Console.ReadLine();
          break;

        case "7":
          Console.WriteLine("Enter a characteristic to search for (e.g., 'friendly'):");
          readResult = Console.ReadLine();
          if (readResult != null)
          {
            string searchCharacteristic = readResult.ToLower();
            for (int i = 0; i < maxPets; i++)
            {
              if (ourAnimals[i, 1].Contains("cat") && ourAnimals[i, 5].Contains(searchCharacteristic))
              {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {
                  Console.WriteLine(ourAnimals[i, j].ToString());
                }
              }
            }
          }
          Console.WriteLine("\n\rPress the Enter key to continue.");
          readResult = Console.ReadLine();
          break;

        case "8":
          Console.WriteLine("Enter a characteristic to search for (e.g., 'friendly'):");
          readResult = Console.ReadLine();
          if (readResult != null)
          {
            string searchCharacteristic = readResult.ToLower();
            for (int i = 0; i < maxPets; i++)
            {
              if (ourAnimals[i, 1].Contains("dog") && ourAnimals[i, 5].Contains(searchCharacteristic))
              {
                Console.WriteLine();
                for (int j = 0; j < 6; j++)
                {
                  Console.WriteLine(ourAnimals[i, j].ToString());
                }
              }
            }
          }
          Console.WriteLine("\n\rPress the Enter key to continue.");
          readResult = Console.ReadLine();
          break;

        default:
          break;
      }
    } while (menuSelection != "exit");
  }
}