using System;

class MainClass {
  public static void Main (string[] args) {
    string x = Console.ReadLine();
    string[] n = x.Split(' '); 
    int a = int.Parse(n[0]);
    int b = int.Parse(n[1]);
    int c = int.Parse(n[2]);
   	int MaiorAB = (a + b + Math.Abs( a - b )) / 2;
    int MaiorABC =  (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;
    Console.WriteLine($"{MaiorABC} eh o maior");  
  }
}