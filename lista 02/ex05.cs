using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um intervalo de tempo no formato HH:MM:SS");
    string t = Console.ReadLine();
    string[] n = t.Split(":");
    double h = double.Parse(n[0]);
    double m = double.Parse(n[1]);
    double s = double.Parse(n[2]);
    
    double total = (h * 3600) + (m * 60) + s;

    double km = 300000 * total;

    Console.WriteLine($"A luz percorreu {km} km nesse intervalo");
  }
}