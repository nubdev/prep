using System;
using prep.utility.ranges;

namespace prep.utility.filtering
{
  public static class FilteringExtensions
  {
    public static IMatchAn<Item> equal_to<Item,PropertyType>(this IProvideAccessToCreatingSpecifications<Item,PropertyType> extension_point,PropertyType value)
    {
      return equal_to_any(extension_point,value);
    }

    public static IMatchAn<Item> equal_to_any<Item,PropertyType>(this IProvideAccessToCreatingSpecifications<Item,PropertyType> extension_point,params PropertyType[] values)
    {
      return create_using(extension_point, new EqualToAny<PropertyType>(values));
    }


    public static IMatchAn<Item> create_using<Item,PropertyType>(this IProvideAccessToCreatingSpecifications<Item,PropertyType> extension_point,IMatchAn<PropertyType> real_matcher)
    {
      return extension_point.create_matcher_from(real_matcher);
    }

    public static IMatchAn<Item> greater_than<Item,PropertyType>(this IProvideAccessToCreatingSpecifications<Item,PropertyType> extension_point,PropertyType value) where PropertyType : IComparable<PropertyType>
    {
      return create_using(extension_point,new IsGreaterThan<PropertyType>(value));
    }


    public static IMatchAn<Item> between<Item,PropertyType>(this IProvideAccessToCreatingSpecifications<Item,PropertyType> extension_point,PropertyType start, PropertyType end) where PropertyType : IComparable<PropertyType>
    {
      return
        create_using(extension_point,new IsBetween<PropertyType>(start, end));
    }
     
    public static IMatchAn<Item> that_falls_in<Item,PropertyType>(this IProvideAccessToCreatingSpecifications<Item,PropertyType> extension_point,Range<PropertyType> range ) where PropertyType : IComparable<PropertyType>
    {
      return
        create_using(extension_point,new FallsInRange<PropertyType>(range));
    }
  }
}
