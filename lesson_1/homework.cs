using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Введіть кількість ручок.");
    int penAmount = int.Parse(Console.ReadLine());
    Console.WriteLine("Кількість ручок = {0} шт.", penAmount);

    Console.WriteLine("Введіть вартість ручки.");
    double penPrice = double.Parse(Console.ReadLine());
    Console.WriteLine("Вартість ручки = {0} грн", penPrice);

    Console.WriteLine("Введіть кількість зошитів.");
    int copybookAmount = int.Parse(Console.ReadLine());
    Console.WriteLine("Кількість зошитів = {0} шт.", copybookAmount);

    Console.WriteLine("Введіть вартість зошита.");
    double copybookPrice = double.Parse(Console.ReadLine());
    Console.WriteLine("Вартість зошита = {0} грн", copybookPrice);

    double totalPrice = penAmount * penPrice + copybookAmount * copybookPrice;
    Console.WriteLine("Загальна сума покупки = {0} грн", totalPrice);
  }
}
