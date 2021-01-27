using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo:");
    double b = double.Parse(Console.ReadLine());
    double a = double.Parse(Console.ReadLine());
    double area = b * a;
    double perimetro = (2 * b) + (2 * a);
    double diagonal = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {perimetro:0.00} - Diagonal = {diagonal:0.00}");
  }
}