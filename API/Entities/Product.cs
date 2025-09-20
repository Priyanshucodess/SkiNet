namespace API.Entities;

public class Product
{
    public long Id { get; set; }
    public required String Name { get; set; }
    public required String Description { get; set; }
    public long Price { get; set; }
    public String? PictureUrl { get; set; }
    public required String Type { get; set; }
    public required String Brand { get; set; }
    public int QuantityInStock { get; set; }
}
