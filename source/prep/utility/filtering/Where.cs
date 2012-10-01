namespace prep.utility.filtering
{
  public class Where<ItemToFilter>
  {
    public static PropertyAccessor<ItemToFilter,PropertyType> has_a<PropertyType>(PropertyAccessor<ItemToFilter,PropertyType> accessor)
    {
      return accessor;
    }
  }
}