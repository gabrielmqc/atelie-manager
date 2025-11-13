namespace Manager.Domain.Models;

public class ClientBO : AbstractEntityVO<long?>
{
    public ClientBO(long? id, DateTime createdAt, DateTime updatedAt, string name, string email, string phone,
        AddressVO address) : base(id, createdAt, updatedAt)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
    }

    public string Name { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public AddressVO Address { get; private set; }
}