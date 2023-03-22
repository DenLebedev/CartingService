using LiteDB;
using System;

namespace CartingService.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string ImageAltText { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Item()
        { 

        }

        [BsonCtor]
        public Item(int _id, string name, string imageURL, string imageAltText, decimal price, int quantity)
        {
            Id = _id;
            Name = name;
            ImageURL = imageURL;
            ImageAltText = imageAltText;
            Price = price;
            Quantity = quantity;
        }
    }
}
