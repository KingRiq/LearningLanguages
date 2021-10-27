using System;
using System.IO; //because static programs are boring (had to look this up)
namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 

      //ok Ill do something cool maybe?
      Here's what you learned:

      DATA TYPES: int, double
      ARITHMETIC OPERATORS: +, -, *, /
      INCREMENT/DECREMENT: ++, --
      MODULO: % 
      BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max

      Good luck! */
      // I can't assume I know how to do something cool using methods because I have not used methods. To get the formal training I desire I shouldn't assume. I will only used what codeacadem has taught me

      // here goes!
      Console.WriteLine("Please enter your age");
      string input = Console.ReadLine(); //because static programs are boring.
      

      //code academy doesn't accept user input but when I run it in github it will work
      int userAge  = 0;
      userAge = Convert.ToInt32(input);
      Console.WriteLine($"Your age: {userAge}");

      //I will extend the planet stuff because lazy and I could learn more instead
      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge/jupiterYears;

      // Time to Jupiter (it would take to fly to jupiter from earth)
      double journeyToJupiter = 6.142466;

      Console.WriteLine($"On jupiter you are {jupiterAge} years old");


    }
  }
}

