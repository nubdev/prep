namespace prep.utility.filtering
{
  public class MatchCreationExtensionPoint<ItemToMatch, PropertyType> : IProvideAccessToCreatingSpecifications<ItemToMatch, PropertyType>
  {
    PropertyAccessor<ItemToMatch, PropertyType> accessor;

    public IProvideAccessToCreatingSpecifications<ItemToMatch,PropertyType> not
    {
      get
      {
        return new NegatingMatchCreationExtensionPoint<ItemToMatch, PropertyType>(this);
      }
    }

    public MatchCreationExtensionPoint(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<ItemToMatch> create_matcher_from(IMatchAn<PropertyType> real_matcher)
    {
      return new PropertyMatch<ItemToMatch, PropertyType>(accessor, real_matcher);
    }
  }
}