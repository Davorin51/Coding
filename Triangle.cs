using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp3
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public double C
        {
            get
            {
                return this.c;
            }
            set
            {
                this.c = value;
            }
        }
        public double B
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }


        public Triangle()
        {
            A = B = C = 1;
        }
        public Triangle(int a)
        {
            A = B = C = a;
        }
        public Triangle(int a, int b) { A = a; B = C = b; }

    }
}
