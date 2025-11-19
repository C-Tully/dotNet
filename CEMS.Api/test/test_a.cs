namespace interfaceTest {
  public enum colour {
    red, green, blue
  };

  class SampleClass {
    static void Main(string[] args)
    {
      //Because the potiental input value could be either a number(int) or a word ('red') 
      //We need to handle the input values seperatelly.

      // colour c = colour.blue;
      string input = Console.ReadLine().Trim();

      //Validate input for 
      if (string.IsEmptyOrNull(input))
      {
        Console.WriteLine("Empty Input");
        return;
      }

      //Numbers      
      if (int.TryParse(input, out int numeric) && Enum.IsDefined(typeof(Colour), numeric))
      {
        switch (c)
        {
          case 0:
            Console.WriteLine("0");
            break;
          case 1:
            Console.WriteLine("1");
            break;
          case 2:
            Console.WriteLine("2");
            break;

        }
      }
      else if(Enum.TryParse<colour>(input, true, out colour c))
      {
        //String
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
          default:
            Console.WriteLine("unknown color");
            break;
          
            }
        }
      }
  }
}