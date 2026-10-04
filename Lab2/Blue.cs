using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++) {
                answer += (Math.Sin(x * i))/Math.Pow(x,i-1); 

            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            double a = -1;
            // code here
            double p = 1;
            double five = 5.0;
            for(int i = 1; i <= n; i++)
            {
                
                answer += a * five / p;
                a *= (-1);
                five *= 5.0;
                p = p * (i+1);

            }
                
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            // code here
            if (n > 1) {
                answer = 1;
            }
            long a = 0;
            long b = 1;
            for (int t = 2; t <n; t++)
                {
                    long c = a + b;
                    answer += c;
                    (a, b) = (b, c);
                }
            
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int su = 0;

            while (su+a+answer*h  <= L)
            {
                answer++;
                su += a + (answer-1) * h;
                
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem=ch/ zn; 
                i++;
            }
            while (elem>0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S<L)
            {
                S = S * 2;
                answer += h;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            // code here
            double a = 0; 
            int b = 0; 
            int c = 0; 
            double run = S; 
            int days = 1; 
            if (S >= 100.0) 
            { 
                b = 1; 
            }
            if (S > 42.0) 
            { 
                c = 1; 
            } 
            while (b == 0 || c == 0 || a == 0) {
                days++;
                S = S * (1.0 + (I / 100.0)); 
                run += S; 
                if (days == 7) 
                { 
                    a = run; 
                } 
                if (b == 0 && Math.Round(run, 2) >= 100.0) 
                { 
                    b = days; 
                } 
                if (c == 0 && Math.Round(S, 2) > 42.0) 
                { 
                    c = days; 
                } 
            }
            // end
            return (a, b, c);
        }


        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + E; x += h)
            {
                double s = 0;
                double p = 1;
                double f = 1;
                double elem = 1;
                int i = 0;

                while (Math.Abs(elem) >= E)
                {
                    s += elem;

                    i++;
                    p *= x * x;
                    f *= i;

                    elem = (2 * i + 1) * p / f;
                }

                s += elem;

                SS += s;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }

            return (SS, SY);
        }
    }
}