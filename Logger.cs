namespace knightmoves;

public class ShoppingCart
{
    private readonly Logger _logger;

    public ShoppingCart(Logger logger)
    {
        _logger = logger;
    }

    public void AddItem(string item)
    {
        _logger.Log(item);
    }
}
