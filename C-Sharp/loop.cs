using System;

class Program 
{
  
  static void Main(string[] args) 
  {
    
    Console.WriteLine("Berapa total benda 1: ");
    int benda_1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLiine("Berapa total benda 2");
    int benda_2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Berapa yang mau dihitung? ");
    int benda_3 = Convert.ToInt32(Console.ReadLine());
      
    for (int i = 0; i < benda_1; i++)
    {
      for (int j = 0; j < benda_2; j++)
      {
        Console.Write(benda_3);
      }
      Console.WriteLine();
    }
  }
}
