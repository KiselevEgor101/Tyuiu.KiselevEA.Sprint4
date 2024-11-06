using Tyuiu.KiselevEA.Sprint4.Task1.V13.Lib;
namespace Tyuiu.KiselevEA.Sprint4.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Киселев Е. А. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Киселев Егор Алексеевич | СМАРТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* произведение ряда по формуле.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите колво элементов");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsarry = new int[len];
            for (int i = 0; i < len; i++)

            {
                Console.Write("Введите значение " + i + "элемента массива");
                numsarry[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsarry[i] + "/t");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Итоговый массив:");


            int res = ds.Calculate(numsarry);
            Console.WriteLine(res);



            Console.ReadKey();
        }
    }
}
