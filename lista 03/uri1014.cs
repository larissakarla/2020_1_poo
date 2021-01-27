using System;

class MainClass {
  public static void Main (string[] args) {
    int X = int.Parse(Console.ReadLine());
    double Y = double.Parse(Console.ReadLine());
    double C = X / Y;
    Console.WriteLine($"{C:.000} km/l");
  }
}