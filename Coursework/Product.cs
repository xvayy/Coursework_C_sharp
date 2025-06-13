using System;

namespace Coursework
{
    public class Product
    {
        private string name;
        private double quantityKg;
        private double unitPrice;
        private double packageWeight;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Product name cannot be empty.");
                name = value;
            }
        }

        public double QuantityKg
        {
            get => quantityKg;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity must be non-negative.");
                quantityKg = value;
            }
        }

        public double UnitPrice
        {
            get => unitPrice;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Unit price must be non-negative.");
                unitPrice = value;
            }
        }

        public double PackageWeight
        {
            get => packageWeight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Package weight must be positive.");
                packageWeight = value;
            }
        }

        public Product(string name, double quantityKg, double unitPrice, double packageWeight)
        {
            Name = name;
            QuantityKg = quantityKg;
            UnitPrice = unitPrice;
            PackageWeight = packageWeight;
        }
    }
}