using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite seu nome completo:");
    string s = Console.ReadLine();
    string[] n = s.Split(' ');
    string a = (n[0]);
    Console.WriteLine($"Bem vindo ao C#, {a}");
  }
}