using System;
using System.Collections.Generic;
using System.Numerics;

namespace ChislMethod
{
    class Program
    {    public class Stroka
        {
            public double Y;
            public double X1;
            public double X2;
            public double X3;
            public double X4;
            public Stroka(double Y, double X1, double X2, double X3, double X4)
            {
                this.Y = Y;
                this.X1 = X1;
                this.X2 = X2;
                this.X3 = X3;
                this.X4 = X4;
            }
        }
        class ChislMethod6
        {
            public double[] Y = new double[25];
            public double[] X1 = new double[25];
            public double[] X2 = new double[25];
            public double[] X3 = new double[25];
            public double[] X4 = new double[25];
             public ChislMethod6(double [] eY, double[] eX1, double[] eX2, double[] eX3, double[] eX4)
            {
                for(int i=0; i<25; i++)
                {
                    Y[i] = eY[i];
                    X1[i] = eX1[i];
                    X2[i] = eX2[i];
                    X3[i] = eX3[i];
                    X4[i] = eX4[i];
                }
            }

        }
        static void Main(string[] args)
        {
            
            double[] A = new double[25];
            for (int i = 0; i < 25; i++)
            {
                A[i] = i;
            }
            List<Stroka> nen = new List<Stroka>();
            for (int i = 0; i < 25; i++)
            {
                Stroka kek = new Stroka(i, i, i,i,i);
                nen.Add(kek);
            }
            ChislMethod6 F = new ChislMethod6(A, A, A, A, A);
            Console.WriteLine( F.X1[14]);
            Console.WriteLine("Hello    World!");
           
        }
    }
}
