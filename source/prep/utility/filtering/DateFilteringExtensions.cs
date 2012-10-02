using System;

namespace prep.utility.filtering
{
  public static  class DateFilteringExtensions
  {
    public static IMatchAn<Item> between<Item>(this IProvideAccessToCreatingSpecifications<Item, DateTime> extension_point,
                                               int start, int end)
    {
      return extension_point.create_matcher_from(
        Where<DateTime>.has_a(x => x.Year).between(start, end)); 
    }
  }
}
