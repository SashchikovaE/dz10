using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov12
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            double real = a.Real + b.Real;
            double imaginary = a.Imaginary + b.Imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            double real = a.Real - b.Real;
            double imaginary = a.Imaginary - b.Imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
            double imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
            return new ComplexNumber(real, imaginary);
        }
        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }
        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            string sign = Imaginary >= 0 ? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            ComplexNumber other = (ComplexNumber)obj;
            return Real == other.Real && Imaginary == other.Imaginary;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
