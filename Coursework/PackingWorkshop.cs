using System;
using System.IO;

namespace Coursework
{
    public class PackingWorkshop
    {
        private Product product;

        private string specialization;
        private int packageCount = 0;
        private double totalPrice = 0;
        private double totalPackedPrice = 0;
        private double markupPercentage = 20;

        public PackingWorkshop(string specialization, Product product)
        {
            this.specialization = specialization;
            this.product = product;
        }
        
        public void startPacking(DigitalScale scale)
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

            product.QuantityKg -= weightOnScale;

            if (weightOnScale < product.PackageWeight)
            {
                product.QuantityKg += weightOnScale;
                scale.ResetWeight();
                MessageBox.Show("Not enough weight for a package.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int newPackages = (int)(weightOnScale / product.PackageWeight);
            double usedWeight = newPackages * product.PackageWeight;
            double leftover = weightOnScale - usedWeight;

            UpdateTotals(newPackages, usedWeight);
            product.QuantityKg += leftover;
            scale.ResetWeight();

            MessageBox.Show($"Packed {newPackages} packages. Returned {leftover} kg to stock.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTotals(int newPackages, double usedWeight)
        {
            packageCount += newPackages;
            totalPrice += usedWeight * product.UnitPrice;

            double costPerPackage = product.PackageWeight * product.UnitPrice;
            double pricePerPackageWithMarkup = costPerPackage * (1 + markupPercentage / 100.0);
            totalPackedPrice += newPackages * pricePerPackageWithMarkup;
        }

        // Гетери
        public int PackageCount => packageCount;
        public double TotalPrice => totalPrice;

        public string ProductName => product.Name;
        public double ProductQuantity => product.QuantityKg;
        public double UnitPrice => product.UnitPrice;
        public double PackageWeight => product.PackageWeight;

        public double TotalPackedPrice => totalPackedPrice;
        public double MarkupPercentage => markupPercentage;

    }
}
