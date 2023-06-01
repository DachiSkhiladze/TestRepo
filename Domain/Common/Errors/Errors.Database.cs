namespace Domain.Common.Errors;

public static partial class Errors
{
    public static class Database 
    {
        public static Error Unexpected => Error.Unexpected(
            code: "Database.Unexpected",
            description: "An unexpected error has occurred");

        public static Error UpdateDatabase => Error.Failure(
            code: "Database.UpdateDatabase",
            description: "Can't update database 'Event'");

        public static Error InvalidCredentials => Error.Validation(
            code: "Database.InvalidCred",
            description: "Invalid Email or Password");
    }
}
