namespace Domain.Event.Enums;

public class EventStatus : SmartEnum<EventStatus>
{
    public EventStatus(string name, int value) : base(name, value)
    {
    }

    public static readonly EventStatus PendingApproval = new(nameof(PendingApproval), 1);
    public static readonly EventStatus NewlyAdded = new(nameof(NewlyAdded), 2);
    public static readonly EventStatus Paid = new(nameof(Paid), 3);
    public static readonly EventStatus Canceled = new(nameof(Canceled), 4);
    public static readonly EventStatus OutOfDate = new(nameof(OutOfDate), 5);
}
