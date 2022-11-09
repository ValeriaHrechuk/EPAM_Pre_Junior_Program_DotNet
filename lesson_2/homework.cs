using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Введіть кількість зошитів.");
    int copybookAmout = int.Parse(Console.ReadLine());

    Console.WriteLine("Ввудіть вартість зошита.");
    double copybookPrice = double.Parse(Console.ReadLine());

    Console.WriteLine("Введіть кількість ручок.");
    int penAmout = int.Parse(Console.ReadLine());

    Console.WriteLine("Введіть вартість ручки.");
    double penPrice = double.Parse(Console.ReadLine());

    Console.WriteLine("Скільки у Петрика грошей?");
    double totalMoney = double.Parse(Console.ReadLine());

    double totalPrice = penAmout * penPrice + copybookAmout * copybookPrice;
    double moneyDeposit = totalMoney - totalPrice;

    Console.WriteLine("Всього Петрик має {0} грн", totalMoney);
    Console.WriteLine("Загальна сума покупки {0} грн", totalPrice);

    if (moneyDeposit > 0)
    {
      Console.WriteLine("У Петрика залишиться {0} грн :)", moneyDeposit);

    }
    else if (moneyDeposit == 0)
    {
      Console.WriteLine("Петрик зможе це купити, але в нього не залишиться грошей :|");

    }
    else
    {
      Console.WriteLine("Петрик не може собі то дозволити... Петрику не вистачає {0} грн :(", Math.Abs(moneyDeposit));
    }

  }
}
