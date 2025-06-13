using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class RealNumber : Number
    {
        private double minRange;
        private double maxRange;

        // Конструктори
        public RealNumber() : base(0.0)
        {
            MinRange = 0.0;
            MaxRange = 1.0;
        }

        public RealNumber(double val, double min, double max) : base(val)
        {
            MaxRange = max;
            MinRange = min;
            MaxRange = max;
            Value = val;
        }

        // Властивості
        public override double Value
        {
            get => value;
            set
            {
                if (!IsInRange(value))
                    throw new ArgumentOutOfRangeException(nameof(value), "Value out of range");
                this.value = value;
            }
        }

        public double MinRange
        {
            get => minRange;
            set
            {
                if (value > maxRange)
                    throw new ArgumentException("Min range cannot be greater than max range");
                minRange = value;
            }
        }

        public double MaxRange
        {
            get => maxRange;
            set
            {
                if (value < minRange)
                    throw new ArgumentException("Max range cannot be less than min range");
                maxRange = value;
            }
        }

        // Перевірка діапазону
        public bool IsInRange(double val)
        {
            return val >= minRange && val <= maxRange;
        }

        // Дробова частина
        public double GetFractionalPart()
        {
            return value - Math.Floor(value);
        }

        // Ціла частина (доступ за індексом 0)
        public int GetIntegerPart()
        {
            return (int)Math.Floor(value);
        }

        // Арифметичні оператори
        public static RealNumber operator +(RealNumber a, RealNumber b)
        {
            double result = a.value + b.value;
            double newMin = Math.Min(a.minRange, b.minRange);
            double newMax = Math.Max(a.maxRange, b.maxRange);
            newMin = Math.Min(newMin, result);
            newMax = Math.Max(newMax, result);
            return new RealNumber(result, newMin, newMax);
        }

        public static RealNumber operator -(RealNumber a, RealNumber b)
        {
            double result = a.value - b.value;
            double newMin = Math.Min(a.minRange, b.minRange);
            double newMax = Math.Max(a.maxRange, b.maxRange);
            newMin = Math.Min(newMin, result);
            newMax = Math.Max(newMax, result);
            return new RealNumber(result, newMin, newMax);
        }

        public static RealNumber operator *(RealNumber a, RealNumber b)
        {
            double result = a.value * b.value;

            double[] bounds = new double[]
            {
                a.minRange * b.minRange,
                a.minRange * b.maxRange,
                a.maxRange * b.minRange,
                a.maxRange * b.maxRange
            };

            double newMin = Math.Min(Math.Min(bounds[0], bounds[1]), Math.Min(bounds[2], bounds[3]));
            double newMax = Math.Max(Math.Max(bounds[0], bounds[1]), Math.Max(bounds[2], bounds[3]));

            newMin = Math.Min(newMin, result);
            newMax = Math.Max(newMax, result);

            return new RealNumber(result, newMin, newMax);
        }

        public static RealNumber operator /(RealNumber a, RealNumber b)
        {
            if (b.value == 0)
                throw new DivideByZeroException("Division by zero");

            if (b.minRange <= 0 && b.maxRange >= 0)
                throw new InvalidOperationException("Division range includes zero");

            double result = a.value / b.value;

            double[] bounds = new double[]
            {
                a.minRange / b.minRange,
                a.minRange / b.maxRange,
                a.maxRange / b.minRange,
                a.maxRange / b.maxRange
            };

            double newMin = Math.Min(Math.Min(bounds[0], bounds[1]), Math.Min(bounds[2], bounds[3]));
            double newMax = Math.Max(Math.Max(bounds[0], bounds[1]), Math.Max(bounds[2], bounds[3]));

            newMin = Math.Min(newMin, result);
            newMax = Math.Max(newMax, result);

            return new RealNumber(result, newMin, newMax);
        }

        // Перевизначений метод ToString
        public override string ToString()
        {
            return $"RealNumber: {value:F2}, Range: [{minRange:F2}, {maxRange:F2}]";
        }
    }
}
