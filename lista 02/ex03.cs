using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int p = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int s = int.Parse(Console.ReadLine());
    int m = (p * 2 + s * 3) / 5;
    Console.WriteLine($"Média parcial = {m}");
  }
}