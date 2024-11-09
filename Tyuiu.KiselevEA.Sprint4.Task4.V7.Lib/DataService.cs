using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KiselevEA.Sprint4.Task4.V7.Lib
{
    public class DataService : ISprint4Task4V7
    {
        public int Calculate(int[,] matrix)
        {

            int[,] array = new int[5, 5];
            int sumOdd = 0;

            for (int i = 0; i < 5; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = int.Parse(input[j]);
                }
            }

            // Суммирование нечетных элементов
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] % 2 != 0) // Проверка на нечётное число
                    {
                        sumOdd += array[i, j];
                    }
                }
            }
            return sumOdd;
        }
    }
}
