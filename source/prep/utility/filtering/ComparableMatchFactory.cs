using System;

namespace prep.utility.filtering
{
  public class ComparableMatchFactory<ItemToFilter, PropertyType> where PropertyType
                                                                    : IComparable<PropertyType>

  {
    PropertyAccessor<ItemToFilter, PropertyType> accessor;

    public ComparableMatchFactory(PropertyAccessor<ItemToFilter, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<ItemToFilter> greater_than(PropertyType value)
    {
      return new DynamicCondition<ItemToFilter>(x => accessor(x).CompareTo(value) > 0);
    }

    public IMatchAn<ItemToFilter> between(PropertyType start, PropertyType end)
    {
      return
        new DynamicCondition<ItemToFilter>(x => accessor(x).CompareTo(start) >= 0 && accessor(x).CompareTo(end) <= 0);
    }
  }
}