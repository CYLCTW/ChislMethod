﻿using System;

namespace ChislMethod
{
    class Program
    {
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
            ChislMethod6 F = new ChislMethod6(A, A, A, A, A);
            Console.WriteLine( F.X1[14]);
            Console.WriteLine("Hello    World!");
           
        }
    }
}
