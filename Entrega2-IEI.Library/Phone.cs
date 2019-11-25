﻿namespace Entrega2_IEI.Library
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        internal PhoneNameFormat NameFormat { get; set; }
        public string Name => $"{Brand} {Model} - {PriceFormat(Price)} - {PriceFormat(Discount)}";

        public double Price { get; set; }
        public double Discount { get; set; }

        public string Description { get; set; }

        public Phone(string brand, string model, double price = default, double discount = default, string description = default)
        {
            Brand = brand;
            Model = model;

            Price = price;
            Discount = discount;

            Description = description;
            NameFormat = description == null ? PhoneNameFormat.BrandModel : PhoneNameFormat.Description;
        }

        private static string PriceFormat(double price) => string.Format("{0:C2}", price); 
    }
}
