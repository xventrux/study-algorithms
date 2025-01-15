namespace Algorithms.Library.Interfaces
{
    /// <summary>
    /// Контракт, определяющий поиск.
    /// </summary>
    /// <typeparam name="TIn">Тип входных данных.</typeparam>
    /// <typeparam name="TParam">Тип искомого значения.</typeparam>
    public interface ISearcher<in TParam>
        where TParam : IComparable<TParam>
    {
        /// <summary>
        /// Выполняет поиск.
        /// </summary>
        /// <param name="array">Массив элементов, в котором нужно выполнить поиск.</param>
        /// <returns>Индекс найденного элемента.</returns>
        /// <exception cref="ArgumentNullException">Вызывается, если передаваемый массив или искомое значение равны <c>null</c>.</exception>
        public int Search(TParam[] array, TParam target);
    }
}
