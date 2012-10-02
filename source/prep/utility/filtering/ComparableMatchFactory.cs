using System;

namespace prep.utility.filtering
{
  public class ComparableMatchFactory<ItemToFilter, PropertyType> 
    :ICreateMatchers<ItemToFilter,PropertyType> where PropertyType
                                                                    : IComparable<PropertyType>

  {
    PropertyAccessor<ItemToFilter, PropertyType> accessor;
    ICreateMatchers<ItemToFilter, PropertyType> original;

    public ComparableMatchFactory(PropertyAccessor<ItemToFilter, PropertyType> accessor, ICreateMatchers<ItemToFilter, PropertyType> original)
    {
      this.accessor = accessor;
      this.original = original;
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

    public IMatchAn<ItemToFilter> equal_to(PropertyType value)
    {
      return original.equal_to(value);
    }

    public IMatchAn<ItemToFilter> equal_to_any(params PropertyType[] values)
    {
      return original.equal_to_any(values);
    }

    public IMatchAn<ItemToFilter> not_equal_to(PropertyType value)
    {
      return original.not_equal_to(value);
    }
  }
}