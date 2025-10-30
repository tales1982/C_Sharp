using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Calculator
{
    public class MathOperation
    {
        public float Add(float a, float b)
        {
            return (a + b);
        }

        public float Subtract(float a, float b)
        {
            return (a - b);
        }

        public float Divide(float a, float b)
        {
            return (a / b);
        }
        public float Multiply(float a, float b)
        {
            return (a * b);
        }

        
        public float Modulo(float a, float b)
        {
            return (a % b);
        }
    }
}