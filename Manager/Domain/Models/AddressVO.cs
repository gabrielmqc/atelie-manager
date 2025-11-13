namespace Manager.Domain.Models;

public class AddressVO
{
    public AddressVO(string address, string city, string state, string zipCode)
    {
        Address = address;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    
    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }
}