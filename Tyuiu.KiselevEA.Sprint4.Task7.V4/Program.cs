using Tyuiu.KiselevEA.Sprint4.Task7.V4.Lib;
namespace Tyuiu.KiselevEA.Sprint4.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Киселев Е. А. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Киселев Егор Алексеевич | СМАРТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов,                 *");
            Console.WriteLine("* длина которых меньше 7                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            
            string str = "382976421897";

            int index = 0;

            Console.WriteLine("/nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} /t");
                    index++;
                }
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int res = ds.Calculate(rows,columns,str);

            Console.WriteLine(res);



            Console.ReadKey();
        }
    }
}
