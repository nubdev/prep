namespace prep.utility.filtering
{
  public class NegatingMatchCreationExtensionPoint<ItemToMatch, PropertyType> :
    IProvideAccessToCreatingSpecifications<ItemToMatch, PropertyType>
  {
    IProvideAccessToCreatingSpecifications<ItemToMatch, PropertyType> original;

    public NegatingMatchCreationExtensionPoint(IProvideAccessToCreatingSpecifications<ItemToMatch, PropertyType> original)
    {
      this.original = original;
    }

    public IMatchAn<ItemToMatch> create_matcher_from(IMatchAn<PropertyType> real_matcher)
    {
      return original.create_matcher_from(real_matcher).not();
    }
  }
}