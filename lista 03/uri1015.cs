using System;

class MainClass {
  public static void Main (string[] args) {
    string[] l1 = Console.ReadLine().Split(' ');
    string[] l2= Console.ReadLine().Split(' ');
    double x1 = double.Parse(l1[0]);
    double y1 = double.Parse(l1[1]);
    double x2 = double.Parse(l2[0]);
    double y2 = double.Parse(l2[1]);
    double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 -y1) * (y2 - y1));
    Console.WriteLine($"{d:0.0000}");
  }
}