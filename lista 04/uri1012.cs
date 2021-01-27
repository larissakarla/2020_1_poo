using System;

class MainClass {
  public static void Main (string[] args) {
    string s = Console.ReadLine();
    string[] n = s.Split(' ');
    double A = double.Parse(n[0]);
    double B = double.Parse(n[1]);
    double C = double.Parse(n[2]);

    double T = A * C / 2;
    double CI = 3.14159 * (C*C);
    double TR = ((A + B) * C) / 2;
    double Q = B * B;
    double R = A * B;
    
    Console.WriteLine($"TRIANGULO: {T:0.000}");
    Console.WriteLine($"CIRCULO: {CI:0.000}");
    Console.WriteLine($"TRAPEZIO: {TR:0.000}");
    Console.WriteLine($"QUADRADO: {Q:0.000}");
    Console.WriteLine($"RETANGULO: {R:0.000}");
  }
}