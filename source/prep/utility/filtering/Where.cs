using System;

namespace prep.utility.filtering
{
  public class Where<ItemToFilter>
  {
    public static MatchCreationExtensionPoint<ItemToFilter, PropertyType> has_a<PropertyType>(
      PropertyAccessor<ItemToFilter, PropertyType> accessor)
    {
      return new MatchCreationExtensionPoint<ItemToFilter, PropertyType>(accessor);
    }
  }
}