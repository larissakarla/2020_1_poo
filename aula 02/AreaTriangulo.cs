using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a base do triângulo");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a altura do triângulo");
    double h = double.Parse(Console.ReadLine());
    double a = b * h / 2;
    Console.WriteLine($"Área = {a:0.00}");
  }
}
