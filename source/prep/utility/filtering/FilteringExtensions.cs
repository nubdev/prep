namespace prep.utility.filtering
{
  public static class FilteringExtensions
  {
    public static IMatchAn<ItemToFilter> equal_to<ItemToFilter, PropertyType>(
      this PropertyAccessor<ItemToFilter, PropertyType> accessor,
      PropertyType value)
    {
      return new DynamicCondition<ItemToFilter>(x => accessor(x).Equals(value));
    }
  }
}