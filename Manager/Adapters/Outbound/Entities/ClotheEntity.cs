using  Manager.Adapters.Outbound.Enums;


namespace Manager.Adapters.Outbound.Entities;

public class ClotheEntity
{
    public ClotheEntity(long? id, DateTime createdAt, DateTime updatedAt, int type, string size, string color,
        DateTime availability, string imageUrl, double price, ClotheStatusEntity status)
    {
        Id = id;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        Type = type;
        Size = size;
        Color = color;
        Availability = availability;
        ImageUrl = imageUrl;
        Price = price;
        Status = status;
    }

    public long? Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public int Type { get; private set; }

    public string Size { get; private set; }

    public string Color { get; private set; }

    public DateTime Availability { get; private set; }

    public string ImageUrl { get; private set; }

    public double Price { get; private set; }

    public ClotheStatusEntity Status { get; private set; }
}