using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Number
    {
        // Захищене поле значення
        protected double value;

        // Конструктори
        public Number() { }

        public Number(double val)
        {
            value = val;
        }

        // Віртуальний метод друку
        public override string ToString()
        {
            return $"Number: {value}";
        }

        // Властивість для доступу до значення
        public virtual double Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}
