using System.Collections;

namespace AddRemoveExercise
{
  internal class Program
  {
    private static void Main()
    {
      Random random = new();
      Queue queue = new();
      int operationType = 0;

      while (operationType != 3)
      {
        PrintMenu(queue);
        try
        {
          string? input = Console.ReadLine();

          if (!string.IsNullOrEmpty(input) && int.TryParse(input, out operationType))
          {
            switch (operationType)
            {
              case 1: // Add random number
                int randomNumber = random.Next();
                queue.Enqueue(randomNumber);
                break;
              case 2: // Remove
                queue.Dequeue();
                break;
              default:
                break;
            }
          }
          else throw new Exception("Incorrect input!");
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Exception Occurred: {ex.Message}");
        }
      }
    }

    private static void PrintMenu(ICollection collection)
    {
      Console.WriteLine("\nMevcut Liste: ");
      foreach (int item in collection)
        Console.WriteLine(item);
      Console.WriteLine("\nChoose an operation:\n1. Add\n2. Remove\n3. Exit");
    }
  }
}