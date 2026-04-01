namespace knightmoves;

public class SomeClass
{
    private readonly Logger _logger;

    public SomeClass(Logger logger)
    {
        _logger = logger;
    }

    public void DoSomething(string message)
    {
        _logger.Log(message);
    }
}
