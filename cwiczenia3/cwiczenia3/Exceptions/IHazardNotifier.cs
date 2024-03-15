namespace cwiczenia3.Exceptions;

public class IHazardNotifier : Exception
{
    public IHazardNotifier()
    {
    }

    public IHazardNotifier(string? message) : base(message)
    {
    }

    public IHazardNotifier(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}