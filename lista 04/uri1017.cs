using System;

class MainClass {
  public static void Main (string[] args) {
    double t = double.Parse(Console.ReadLine());
    double v = double.Parse(Console.ReadLine());
    double l = (v / 12) * t;
    Console.WriteLine($"{l:0.000}");
  }
}