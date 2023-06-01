namespace Domain.Common.Errors;

public static partial class Errors 
{
    public static class City 
    {
        public static Error NotExist => Error.NotFound(
            code: "City.NotExist",
            description: "Can't find the city."
            );
    }
}
