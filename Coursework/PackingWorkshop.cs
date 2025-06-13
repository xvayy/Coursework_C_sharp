using System;
using System.IO;

namespace Coursework
{
    public class PackingWorkshop
    {
        private readonly IScaleManager scaleManager;
        private Product product;

        private string specialization;
        //private string productName = "No name";
        //private double productQuantity = 0;
        //private double unitPrice = 0;
        //private double packageWeight = 0;
        private int packageCount = 0;
        private double totalPrice = 0;

        public PackingWorkshop(IScaleManager manager, string specialization, Product product)
        {
            this.scaleManager = manager;
            this.specialization = specialization;
            this.product = product;
        }
        //public PackingWorkshop(IScaleManager manager, string specialization, string productName,
        //                       double quantity, double price, double pkgWeight, int pkgCount)
        //{
        //    this.scaleManager = manager;
        //    this.specialization = specialization;
        //    this.productName = productName;
        //    this.productQuantity = quantity;
        //    this.unitPrice = price;
        //    this.packageWeight = pkgWeight;
        //    this.packageCount = pkgCount;
        //}

        public void DisplayProductInfo()
        {
            string info =
                "=== Product Information ===\n" +
                $"Product name: {product.Name}\n" +
                $"Available amount: {product.QuantityKg} kg\n" +
                $"Unit price: {product.UnitPrice} UAH/kg\n" +
                $"Package weight: {product.PackageWeight} kg\n" +
                $"Packed packages: {packageCount}\n" +
                "============================";
            MessageBox.Show(info, "Product Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool WeighProduct(double amount)
        {
            var scale = scaleManager.GetSelectedScale();
            if (scale == null)
            {
                MessageBox.Show("No scale selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (amount > product.QuantityKg)
            {
                MessageBox.Show("Not enough product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (amount < scale.MinWeight || amount > scale.MaxWeight)
            {
                MessageBox.Show("Amount out of scale range.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Amount must be a positive number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            scale.AddWeight(amount);
            product.QuantityKg -= amount;
            return true;
        }

        public void PackProduct(DigitalScale scale)
        {
            if (scale == null)
            {
                MessageBox.Show("No scale provided.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double weightOnScale = scale.MeasuredWeight;

            if (weightOnScale > product.QuantityKg)
            {
                MessageBox.Show("Not enough product stock to weigh.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Віднімаємо всю масу, що пішла на вагу
            product.QuantityKg -= weightOnScale;

            if (weightOnScale < product.PackageWeight)
            {
                // повертаємо назад все, бо замало для фасування
                product.QuantityKg += weightOnScale;
                scale.ResetWeight();
                MessageBox.Show("Not enough weight for a package.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int newPackages = (int)(weightOnScale / product.PackageWeight);
            double usedWeight = newPackages * product.PackageWeight;
            double leftover = weightOnScale - usedWeight;

            packageCount += newPackages;
            product.QuantityKg += leftover; // повертаємо лише залишок
            totalPrice += usedWeight * product.UnitPrice;

            scale.ResetWeight();

            MessageBox.Show($"Packed {newPackages} packages. Returned {leftover:F2} kg to stock.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GenerateReport(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine($"Product: {product.Name}");
                writer.WriteLine($"Total packed: {packageCount} packages");
                writer.WriteLine($"Remaining product: {product.QuantityKg} kg");
                writer.WriteLine($"Unit price: {product.UnitPrice} UAH/kg");
                writer.WriteLine($"Total value packed: {totalPrice} UAH");
                writer.WriteLine("---");
            }
            MessageBox.Show($"Report saved to {path}", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Гетери
        public DigitalScale? GetSelectedScale() => scaleManager.GetSelectedScale();
        public int PackageCount => packageCount;
        public double TotalPrice => totalPrice;

        public string ProductName => product.Name;
        public double ProductQuantity => product.QuantityKg;
        public double UnitPrice => product.UnitPrice;
        public double PackageWeight => product.PackageWeight;



        // Сетери з валідацією
        public void SetPackageCount(int count)
        {
            if (count < 0) throw new ArgumentException("Package count must be non-negative.");
            packageCount = count;
        }
    }
}
