using System;

namespace prep.utility.filtering
{
  public static class FilteringExtensions
  {
    public static IMatchAn<Item> equal_to<Item,PropertyType>(this MatchCreationExtensionPoint<Item,PropertyType> extension_point,PropertyType value)
    {
      return equal_to_any(extension_point,value);
    }

    public static IMatchAn<Item> equal_to_any<Item,PropertyType>(this MatchCreationExtensionPoint<Item,PropertyType> extension_point,params PropertyType[] values)
    {
      return create_using(extension_point, new EqualToAny<PropertyType>(values));
    }


    public static IMatchAn<Item> create_using<Item,PropertyType>(this MatchCreationExtensionPoint<Item,PropertyType> extension_point,IMatchAn<PropertyType> real_matcher)
    {
      return new PropertyMatch<Item, PropertyType>(extension_point.accessor, real_matcher);
    }

     
    public static IMatchAn<Item> greater_than<Item,PropertyType>(this MatchCreationExtensionPoint<Item,PropertyType> extension_point,PropertyType value) where PropertyType : IComparable<PropertyType>
    {
      return create_using(extension_point,new IsGreaterThan<PropertyType>(value));
    }


    public static IMatchAn<Item> between<Item,PropertyType>(this MatchCreationExtensionPoint<Item,PropertyType> extension_point,PropertyType start, PropertyType end) where PropertyType : IComparable<PropertyType>
    {
      return
        create_using(extension_point,new IsBetween<PropertyType>(start, end));
    }
     
  }
}
