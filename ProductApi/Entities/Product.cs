using AutoDB.Mongo.Entities;

namespace ProductApi.Entities;
public class Product : BaseEntityMongo
{
    public string Name { get; set; }
    public string Description { get; set; }

    public double Price { get; set; }
}

