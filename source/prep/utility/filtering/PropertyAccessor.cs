namespace prep.utility.filtering
{
  public delegate PropertyType PropertyAccessor<in Item, out PropertyType>(Item item);
}