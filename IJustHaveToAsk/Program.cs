public static class IJustHaveToAsk
{
    /// <summary>
    /// <para> Отсчитать несколько элементов с конца </para>
    /// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
    /// </summary> 
    /// <typeparam name="T"></typeparam>
    /// <param name="enumerable"></param>
    /// <param name="tailLength">Сколько элеметнов отсчитать с конца  (у последнего элемента tail = 0)</param>
    /// <returns></returns>
    public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
    {
        int count;
        if (enumerable.TryGetNonEnumeratedCount(out int check))
        {
            count = check;
        }
        else
        {
            count = enumerable.Count();
        }

        var enumerator = enumerable.GetEnumerator();

        enumerator.MoveNext();

        //Перебирает все значечния только 1 раз
        for (int i = count-1; i >= 0; i--)
        {
            if (i >= tailLength)
            {
                yield return (enumerator.Current, null);
                enumerator.MoveNext();
            }
            else
            {
                yield return (enumerator.Current, i);
                enumerator.MoveNext();
            }
        }
    }
}
