namespace prep.utility.filtering
{
  public class PropertyMatch<Item,PropertyType> : IMatchAn<Item>
  {
    PropertyAccessor<Item, PropertyType> accessor;
    IMatchAn<PropertyType> real_criteria;

    public PropertyMatch(PropertyAccessor<Item, PropertyType> get_the_value, IMatchAn<PropertyType> real_criteria)
    {
      this.accessor = get_the_value;
      this.real_criteria = real_criteria;
    }

    public bool matches(Item item)
    {
      var value = accessor(item);
      return real_criteria.matches(value);
    }
  }
}