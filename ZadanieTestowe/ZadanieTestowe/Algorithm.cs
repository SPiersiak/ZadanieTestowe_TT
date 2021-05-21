using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieTestowe
{
    public class Algorithm
    {
        private double h { get; set; }
        private double b { get; set; }
        private double w { get; set; }
        private int result { get; set; }

        public Algorithm(double h, double b, double w)
        {
            this.h = h;
            this.b = b;
            this.w = w;

            if (b == 1)
                result = -1;
            else if(w < 1.5)
                result = -1;
            else
                result = 0;
        }

        public int NumberOfReflections()
        {
            if (result == -1)
                return result;
            else
            {
                int reflections = 0;
                double x = h * b;
                while (x > w) {
                    if (x >= w)
                    {
                        reflections++;
                        h = x;
                    }
                    x = h * b;
                }
                result = reflections;
                return result;
            }
        } 


    }
}
