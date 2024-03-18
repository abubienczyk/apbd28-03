namespace cwiczenia3.Exceptions;

public class DangerousAcctionException : Exception
{
    public DangerousAcctionException()
    {
    }

    public DangerousAcctionException(string? message) : base(message)
    {
    }

    public DangerousAcctionException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}