# Binary search
## Описание
**Бинарный поиск** гораздо более эффективный в сравнении с линейным поиском.  
Бинарный поиск основан на идее деления данных на половины и последующем поиске в одной из них с последующим делением.
## Визуализация
![Визуализация алгоритма бинарного поиска](../images/binary-search.gif)
## Код на c#
```cs
public class BinarySearcher<TParam> : ISearcher<TParam>
    where TParam : IComparable<TParam>
{
    private const int _notFoundValue = -1;

    public int Search(TParam[] sortedArray, TParam target)
    {
        ValidateInput(sortedArray, target);

        int left = 0;
        int right = sortedArray.Length - 1;

        while (left <= right)
        {
            int mid = GetMiddleNumber(left, right);
            int comparison = sortedArray[mid].CompareTo(target);
            if (comparison == 0)
            {
                return mid;
            }
            else if (comparison < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return _notFoundValue;
    }

    private void ValidateInput(TParam[] sortedArray, TParam target)
    {
        if (sortedArray is null)
            throw new ArgumentNullException(nameof(sortedArray));

        if (target is null)
            throw new ArgumentNullException(nameof(target));
    }
    
    private int GetMiddleNumber(int left, int right) 
        => left + (right - left) / 2;
}
```