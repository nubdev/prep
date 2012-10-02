using System;

namespace prep.utility.ranges
{
  public interface Range<in T> where T  :IComparable<T>
  {
    bool contains(T value); 
  }
}