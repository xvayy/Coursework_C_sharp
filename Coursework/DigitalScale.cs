using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{

    // Для запису кожного зважування 
    public struct WeighingEntry
    {
        public double Mass { get; set; }
        public double Error { get; set; }
    }

    [Serializable]
    public class DigitalScale
    {
        private RealNumber weight;
        private double weighingError;
        private double unitPrice;
        private int id;

        private List<WeighingEntry> weighingLog = new List<WeighingEntry>();

        public DigitalScale()
        {
            id = 0;
            weight = new RealNumber(0.0, 0.0, 100.0);
            weighingError = 0.01;
            unitPrice = 0.0;
        }

        public DigitalScale(int id, double weightVal, double min, double max, double error, double price)
        {
            if (error < 0) throw new ArgumentException("Error margin cannot be negative");
            if (price < 0) throw new ArgumentException("Unit price cannot be negative");

            this.id = id;
            weight = new RealNumber(weightVal, min, max);
            weighingError = error;
            unitPrice = price;
        }

        // Властивості
        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                    throw new ArgumentException("ID cannot be negative");
                id = value;
            }
        }

        public double Weight
        {
            get => weight.Value;
            set => weight.Value = value;
        }

        public double MinWeight
        {
            get => weight.MinRange;
            set => weight.MinRange = value;
        }

        public double MaxWeight
        {
            get => weight.MaxRange;
            set => weight.MaxRange = value;
        }

        public double WeighingError
        {
            get => weighingError;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Weighing error cannot be negative");
                weighingError = value;
            }
        }

        public double UnitPrice
        {
            get => unitPrice;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Unit price cannot be negative");
                unitPrice = value;
            }
        }

        public double MeasuredWeight => Weight + GenerateWeighingError();

        public void ResetWeight() => Weight = 0;

        public double CalculateTotalPrice() => Weight * UnitPrice;

        public void AddWeight(double delta)
        {
            double err = GenerateWeighingError();
            Weight += delta;
            LogWeighing(Weight, err);
        }

        public void SubtractWeight(double delta)
        {
            double err = GenerateWeighingError();
            Weight -= delta;
            LogWeighing(-Weight, err);
        }

        private double GenerateWeighingError()
        {
            var rnd = new Random();
            return rnd.NextDouble() * 2 * weighingError - weighingError; // [-error, +error]
        }

        public void LogWeighing(double mass, double error)
        {
            weighingLog.Add(new WeighingEntry { Mass = mass, Error = error });
        }

        public IReadOnlyList<WeighingEntry> GetWeighingLog() => weighingLog.AsReadOnly();


        public override string ToString()
        {
            return $"[Scale #{id}] Weight: {Weight:F2}kg, ±{weighingError:F4}kg, Price: {unitPrice:F2}/kg";
        }
    }
}
