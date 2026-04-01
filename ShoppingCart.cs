namespace knightmoves;

public class ShoppingCart
{
    private readonly Logger _logger;
    public List<string> Items { get; }

    public ShoppingCart(Logger logger)
    {
        _logger = logger;
        Items = new List<string>();
    }

    public void AddItem(string item)
    {
        Items.Add(item);
        _logger.Log($"Added item '{item}' to cart");
    }
}
