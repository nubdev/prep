using System;

namespace prep.utility.filtering
{
  public static  class DateFilteringExtensions
  {
    public static IMatchAn<Item> between<Item>(this MatchCreationExtensionPoint<Item, DateTime> extension_point,
                                               int start, int end)
    {
      return extension_point.create_using(
        Where<DateTime>.has_a(x => x.Year).between(start, end)); 
    }
  }
}