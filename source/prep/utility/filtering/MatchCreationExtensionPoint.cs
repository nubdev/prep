namespace prep.utility.filtering
{
  public class MatchCreationExtensionPoint<ItemToMatch, PropertyType>
  {
    public PropertyAccessor<ItemToMatch, PropertyType> accessor { get; set; }

    public object not
    {
      get { throw new System.NotImplementedException(); }
    }

    public MatchCreationExtensionPoint(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }
  }
}