namespace prep.utility.filtering
{
  public interface IProvideAccessToCreatingSpecifications<ItemToMatch, PropertyType>
  {
    IMatchAn<ItemToMatch> create_matcher_from(IMatchAn<PropertyType> real_matcher);
  }
}