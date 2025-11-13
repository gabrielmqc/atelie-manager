using Manager.Domain.Enums;

namespace Manager.Domain.Models;

public class ClotheBO : AbstractEntityVO<long?>
{
    public ClotheBO(long? id, DateTime createdAt, DateTime updatedAt, int type, string size, string color,
        string availability, string imageUrl, double price, ClotheStatus status) : base(id, createdAt, updatedAt)
    {
        Type = type;
        Size = size;
        Color = color;
        Availability = availability;
        ImageUrl = imageUrl;
        Price = price;
        Status = status;
    }

    public int Type { get; private set; }

    public string Size { get; private set; }

    public string Color { get; private set; }

    public string Availability { get; private set; }

    public string ImageUrl { get; private set; }

    public double Price { get; private set; }

    public ClotheStatus Status { get; private set; }
}