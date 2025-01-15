using Algorithms.Library.Interfaces;

namespace Algorithms.Library.Tests
{
    public class BinarySearcherTests
    {
        /// <summary>
        /// ����� ����� � �������.
        /// ��������� ���������� ���������, ��� ������� ����� � �������.
        /// </summary>
        [Test]
        public void Search_NumberInArray_Correct()
        {
            // Arrange
            ISearcher<int> searcher = new BinarySearcher<int>();
            int[] array = { 1, 2, 3 };
            int target = 3;
            int expectedValue = 2;
            
            // Act
            int index = searcher.Search(array, target);

            Assert.That(index, Is.EqualTo(expectedValue));
        }

        /// <summary>
        /// ����� ����� � �������.
        /// ��������� -1, ��� ������ ��������������� � ������� �����.
        /// </summary>
        [Test]
        public void Search_NumberNotExistInArray_NotFoundValue()
        {
            // Arrange
            ISearcher<int> searcher = new BinarySearcher<int>();
            int[] array = { 1, 2, 3 };
            int target = 4;
            int expectedValue = -1;

            // Act
            int index = searcher.Search(array, target);

            Assert.That(index, Is.EqualTo(expectedValue));
        }

        /// <summary>
        /// ����� ����� � �������.
        /// ��������� <see cref="ArgumentNullException"/>, ��� ������� ������ <c>null</c>.
        /// </summary>
        [Test]
        public void Search_NullArray_ThrowsException()
        {
            // Arrange
            ISearcher<int> searcher = new BinarySearcher<int>();
            int[] array = null;
            int target = 4;

            // Act-assert
            Assert.Throws<ArgumentNullException>(() => searcher.Search(array, target));
        }

        /// <summary>
        /// ����� ����� � �������.
        /// ��������� <see cref="ArgumentNullException"/>, ��� ������� �������� ������ <c>null</c>.
        /// </summary>
        [Test]
        public void Search_NullTarget_ThrowsException()
        {
            // Arrange
            ISearcher<StubComparable> searcher = new BinarySearcher<StubComparable>();
            StubComparable[] array = { new StubComparable(), new StubComparable() };
            StubComparable target = null;

            // Act-assert
            Assert.Throws<ArgumentNullException>(() => searcher.Search(array, target));
        }
    }
}