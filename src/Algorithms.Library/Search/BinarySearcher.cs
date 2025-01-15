using Algorithms.Library.Interfaces;

namespace Algorithms.Library
{
    /// <summary>
    /// Реализация бинарного поиска.
    /// </summary>
    public class BinarySearcher<TParam> : ISearcher<TParam>
        where TParam : IComparable<TParam>
    {
        /// <summary>
        /// Значение, если элемент не найден.
        /// </summary>
        private const int _notFoundValue = -1;

        /// <summary>
        /// Выполняет бинарный поиск.
        /// </summary>
        /// <param name="sortedArray">Отсортированный по возрастанию массив чисел.</param>
        /// <param name="target"></param>
        /// <returns>Индекс найденного элемента, или <c>-1</c> если элемент не найден.</returns>
        /// <exception cref="ArgumentNullException">Вызывается, если передаваемый массив или искомое значение равны <c>null</c>.</exception>
        /// <remarks>
        /// Сложность <c>O(ln(n))</c>.
        /// </remarks>
        public int Search(TParam[] sortedArray, TParam target)
        {
            ValidateInput(sortedArray, target);

            int left = 0;
            int right = sortedArray.Length - 1;

            while (left <= right)
            {
                // Находим индекс середины массива.
                int mid = GetMiddleNumber(left, right);

                // Сравниваем значения.
                int comparison = sortedArray[mid].CompareTo(target);

                // Если значения равны.
                if (comparison == 0)
                {
                    return mid;
                }
                // Если искомое значение больше.
                else if (comparison < 0)
                {
                    // Сдвигаем левую границу наполовину вправо.
                    left = mid + 1;
                }
                // Если искомое значение меньше.
                else
                {
                    // Сдвигаем правую границу наполовину влево.
                    right = mid - 1;
                }
            }

            return _notFoundValue;
        }

        /// <summary>
        /// Валидация входных данных.
        /// </summary>
        /// <param name="sortedArray">Массив данных.</param>
        /// <param name="target">Искомое значение.</param>
        /// <exception cref="ArgumentNullException">Вызывается, если передаваемый массив или искомое значение равны <c>null</c>.</exception>
        private void ValidateInput(TParam[] sortedArray, TParam target)
        {
            if (sortedArray is null)
                throw new ArgumentNullException(nameof(sortedArray));

            if (target is null)
                throw new ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Возвращает серединный элемент между левой и правой границами.
        /// </summary>
        /// <param name="left">Левая граница.</param>
        /// <param name="right">Правая граница.</param>
        /// <returns>Серединный элемент.</returns>
        private int GetMiddleNumber(int left, int right) 
            => left + (right - left) / 2;
    }
}
