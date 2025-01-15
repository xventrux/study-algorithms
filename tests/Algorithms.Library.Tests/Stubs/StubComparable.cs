namespace Algorithms.Library.Tests
{
    internal class StubComparable : IComparable<StubComparable>
    {
        public int CompareTo(StubComparable? other)
        {
            throw new NotImplementedException();
        }
    }
}
