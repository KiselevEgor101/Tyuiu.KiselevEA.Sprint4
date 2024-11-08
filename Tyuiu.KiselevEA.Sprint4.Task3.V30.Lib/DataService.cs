using System.Xml.Linq;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KiselevEA.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;

            int maxElement = array[2, 0];

            for (int j = 1; j < 5; j++)
            {
                if (array[2, j] > maxElement)
                {
                    maxElement = array[2, j];
                }
            }
            return maxElement;
        }
    }
}
