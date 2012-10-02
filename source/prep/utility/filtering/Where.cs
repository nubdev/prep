using System;
using prep.collections;

namespace prep.utility.filtering
{
  public class Where<ItemToFilter>
  {
    public static MatchFactory<ItemToFilter, PropertyType> has_a<PropertyType>(
      PropertyAccessor<ItemToFilter, PropertyType> accessor)
    {
      return new MatchFactory<ItemToFilter, PropertyType>(accessor);
    }

    public static ComparableMatchFactory<ItemToFilter, PropertyType> has_an<PropertyType>(
      PropertyAccessor<ItemToFilter, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
    {
      return new ComparableMatchFactory<ItemToFilter, PropertyType>(accessor);
    }
  }
}