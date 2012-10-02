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
  }

  public class MatchFactory<Item, PropertyType>
  {
    PropertyAccessor<Item, PropertyType> accessor;

    public MatchFactory(PropertyAccessor<Item, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<Item> equal_to(PropertyType value)
    {
      return new DynamicCondition<Item>(x => accessor(x).Equals(value));
    }

    public IMatchAn<Movie> equal_to_any(params PropertyType[] values)
    {
      throw new System.NotImplementedException();
    }
  }
}