namespace Manager.Application.Dtos.Request;

public class CreateClotheRequest
{
    public CreateClotheRequest(int type, string size, string color,
        string imageUrl, double price)
    {
        Type = type;
        Size = size;
        Color = color;
        ImageUrl = imageUrl;
        Price = price;
    }

    public int Type { get; private set; }

    public string Size { get; private set; }

    public string Color { get; private set; }
    
    public string ImageUrl { get; private set; }

    public double Price { get; private set; }

}