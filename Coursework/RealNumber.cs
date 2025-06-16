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

        
        // Перевизначений метод
        public override string Info()
        {
            return $"RealNumber: {value:F2}, Range: [{minRange:F2}, {maxRange:F2}]";
        }
    }
}
