using System.Diagnostics;
public static class TopSort
{
    static void Main(string[] args)
    {
        
    }
    /// <summary>
    /// Возвращает отсортированный по возрастанию поток чисел
    /// </summary>
    /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
    /// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
    /// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
    /// <returns>Отсортированный по возрастанию поток чисел.</returns>
    public static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
    {
        int[] arr = inputStream.ToArray();
        int sortFactorCond = sortFactor > arr.Length ? arr.Length : sortFactor;

        if (sortFactor == 0 || maxValue == 0)
        {
            return arr;
        }
        else
        {
            for (int i = 0; i < sortFactorCond; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }
            }
            return arr;
        }
    }
}