namespace Domain.Event.Enums;

public class FilterType : SmartEnum<FilterType>
{
    public FilterType(string name, int value) : base(name, value)
    {
    }

    public static readonly FilterType Music = new(nameof(Music), 1);
    public static readonly FilterType Food = new(nameof(Food), 2);
    public static readonly FilterType Sport = new(nameof(Sport), 3);
    public static readonly FilterType Camping = new(nameof(Camping), 4);
    public static readonly FilterType Education = new(nameof(Education), 5);
    public static readonly FilterType PlansForTwo = new(nameof(PlansForTwo), 6);
    public static readonly FilterType Sightseeing = new(nameof(Sightseeing), 7);
    public static readonly FilterType Other = new(nameof(Other), 8);
}
