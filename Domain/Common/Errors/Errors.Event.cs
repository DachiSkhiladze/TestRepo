namespace Domain.Common.Errors;

public static partial class Errors
{
    public static class Event
    {
        public static Error Unexpected => Error.Unexpected(
            code: "Event.Unexpected",
            description: "An unexpected error has occurred");

        public static Error AddEvent => Error.Failure(
            code: "Event.AddEvent",
            description: "Can't add event to database");

        public static Error AddPaidEvent => Error.Failure(
            code: "Event.AddPaidEvent",
            description: "Can't add paid event to database");

        public static Error NotExist => Error.NotFound(
            code : "Event.NotExist",
            description : "Can't find an event"
            );
        public static Error NotExistPicture => Error.NotFound(
            code : "Event.NotExistPicture",
            description : "Can't find pictures for event"
            );
    }
}
