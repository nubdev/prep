namespace prep.utility.filtering
{
  public class DynamicCondition<Item> : IMatchAn<Item>
  {
    Condition<Item> condition;

    public DynamicCondition(Condition<Item> condition)
    {
      this.condition = condition;
    }

    public bool matches(Item item)
    {
      return condition(item);
    }
  }
}