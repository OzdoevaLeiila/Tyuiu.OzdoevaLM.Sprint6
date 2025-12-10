

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.OzdoevaLM.Sprint6.Task3.V4.Lib
{
    public class DataService : ISprint6Task3V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            byte i = 1;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] % 2 == 0)
                    matrix[i, j] = 0;
            }
            return matrix;
        }
    }
}
