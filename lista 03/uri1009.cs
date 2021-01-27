using System;

class MainClass {
  public static void Main (string[] args) {
    Console.ReadLine();
    double s = double.Parse(Console.ReadLine());
    double v = double.Parse(Console.ReadLine());
    double r = s + v * 15/100;
    Console.WriteLine($"TOTAL = R$ {r:0.00}");
  }
}