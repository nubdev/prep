using System;

namespace prep.utility.filtering
{
  public class IsBetween<T> : IMatchAn<T> where T : IComparable<T>
  {
    T end;
    T start;

    public IsBetween(T end, T start)
    {
      this.end = end;
      this.start = start;
    }

    public bool matches(T item)
    {
      return item.CompareTo(start) >= 0 && item.CompareTo(end) <= 0;
    }
  }
}