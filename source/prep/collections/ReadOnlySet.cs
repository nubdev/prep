using System.Collections;
using System.Collections.Generic;

namespace prep.collections
{
  public class ReadOnlySet<T> : IEnumerable<T>
  {
    IList<T> items;

    public ReadOnlySet(IList<T> items)
    {
      this.items = items;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
      return items.GetEnumerator();
    }
  }
}