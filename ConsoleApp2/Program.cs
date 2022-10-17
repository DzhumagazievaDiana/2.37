using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1<=k<=180");
        var k=int.Parse(Console.ReadLine());
        string numbers = string.Empty;
        var a1 = k / 2 + k % 2;
        Console.WriteLine("Номер пары цифр ={0}", a1);
            for (int i = 10; i < 100; i++)
            numbers += Convert.ToString(i);
        if (k % 2 == 0)
            Console.WriteLine(numbers.Substring(k - 2, 2));
        else
            Console.WriteLine(numbers.Substring(k - 1, 2));
                Console.WriteLine("Двузначное число ={0}", k);
    
        if (k % 2 != 0)
        {
            var a3 = (k / 2 + 10) / 10;
            Console.WriteLine("Четное число ={0}", a3);
        }
        else
        {
            var a3 = (k / 2 - 1) % 10;
            Console.WriteLine("Нечетное число ={0}", a3);
        }
        Console.ReadKey();

    }
}