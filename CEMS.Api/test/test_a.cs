namespace interfaceTest {
  public enum colour {
    red, green, blue
  };

class SampleClass {
    static void Main(string[] args)
    {
      // colour c = colour.blue;
      string input = Console.ReadLine();

      if (!input)
        Console.WriteLine("Please enter a value");

      if (Enum.TryParse(input, true, out colour c))
      {
        switch (c)
        {
          case colour.red:
            Console.WriteLine(colour.red);
            break;
          case colour.blue:
            Console.WriteLine(colour.blue);
            break;
          case colour.green:
            Console.WriteLine(colour.green);
            break;

        }
      }
      else
      {
        Console.WriteLine("Please choose a valid colour");
      }

        
    }
  }
}