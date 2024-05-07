using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.Statistics;

namespace ИМ_лаба11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double mean, variance, empMean, empVariance, meanErr, varErr;
        double minznach, maxznach, chi_chi = 0;
        int size, k;
        double dlina;
        double[] norm;
        double[] interval;
        int[] stat;
        double[] freq;
        double[] p = { 3.841, 16.919, 45.722, 124.342 }; //2, 9,  30, 99
        Random rnd = new Random();

        public double GenerateRandomNormal(double mean, double variance)
        {
            double sum = 0;
            double a;
            
            for (int i = 0; i < 12; i++)
            { 
                
                a = rnd.NextDouble();
                sum += a; // Генерация равномерно распределенной случайной величины и ее суммирование
                
            }
            sum -= 6;

            double z = sum * Math.Sqrt(12.0 / 12);

            // Преобразование нормализованной величины в нужное среднее значение и стандартное отклонение
            return mean + Math.Sqrt(variance) * z;

        }
        public void NormGeneration()
        {
            norm = new double[size];
            for (int i = 0; i < size; i++)
            {
                norm[i] = 0;
            }
            for (int i = 0; i < size; i++)
            {
                norm[i] = GenerateRandomNormal(mean, variance);
            }

            minznach = norm.Min();
            maxznach = norm.Max();

        }

        public void IntervaGeneration()
        {
            //k = Math.Sqrt(size);

            k = (int)Math.Sqrt(size);
            k += 1;
            numericUpDown1.Value = k-1;
            dlina = Math.Abs(maxznach - minznach) / k;
            interval = new double[k];


            
            for (int i = 0; i < k; i++)
            {
                interval[i] = minznach + i * dlina;
            }
        }

        public void StatGeneration()
        {
            stat = new int[k];
            for (int i = 0; i < size; i++) //считаем частоты
            {
                for (int j = 1; j < k; j++)
                {
                    if (norm[i] < minznach + j * dlina)
                    {
                        stat[j - 1]++;
                        break;
                    }
                }

            }
            
        }
        public void DM()
        {
            for (int jj = 0; jj < 5; jj++)
            {
                empMean = norm.Average();
                empVariance = norm.Variance();

            }
            meanErr = Math.Abs(empMean - mean);
            varErr = Math.Abs(empVariance - variance);
            meanErr = meanErr / mean * 100; 
            varErr = varErr / variance * 100;

            error_mean.Value = (decimal)meanErr;
            error_var.Value = (decimal)varErr;

            emp_mean.Value = (decimal)empMean;
            emp_var.Value = (decimal)empVariance;

        }
        public double chi()
        {
            
            double a = 0;
            double b = 0;
            var distribution = new Normal(mean, Math.Sqrt(variance));

            for (int i = 0; i < k; i++)
            {
                a = minznach + i * dlina;
                b = a + dlina;
                
                //функция плоности вер-ти 
                double probabilityA = distribution.CumulativeDistribution(a);
                double probabilityB = distribution.CumulativeDistribution(b);

                // Вероятность интервала - разность между значениями PDF в верхнем и нижнем пределах интервала
                double intervalProbability = probabilityB - probabilityA;
                chi_chi += (stat[i] * stat[i]) / (size * intervalProbability);

            }
            chi_chi -= size;
            chi_emp.Value = (decimal)chi_chi;
            return chi_chi;
        }

        public void FreqGeneraton()
        {
            freq = new double[k];

            for (int i = 0; i < k; i++)
            {
                freq[i] = (double)stat[i] / (double)size;

            }

        }
        public void DrawGistogram()
        {
            double[] xGistogramValue = new double[k];
            for (int jj = 0; jj < k; jj++)
            {
                xGistogramValue[jj] = minznach + dlina * jj;

            }
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < k; i++) chart1.Series[0].Points.AddXY(xGistogramValue[i], freq[i]);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            Series s = new Series();
            mean = (double)mean_numeric.Value;
            variance = (double)variance_numeric.Value;
            size = (int)size_numeric.Value;

            NormGeneration();
            IntervaGeneration();
            StatGeneration();
            FreqGeneraton();
            DrawGistogram();
            DM();
            double chi_chi = chi();
            if (k == 4)
            {
                if (chi_chi > p[0]) { label8.Text = "распределение нормальное"; }
                else { label8.Text = "распределение НЕ нормальное"; }

            }
            if (k == 11)
            {
                if (chi_chi > p[1]) { label8.Text = "распределение нормальное"; }
                else { label8.Text = "распределение НЕ нормальное"; }

            }
            if (k == 32)
            {
                if (chi_chi > p[2]) { label8.Text = "распределение нормальное"; }
                else { label8.Text = "распределение НЕ нормальное"; }
                    
            }

            if (k == 101)
            {
                if (chi_chi < p[3]) { label8.Text = "распределение нормальное"; }
                else { label8.Text = "распределение НЕ нормальное"; }

            }
        }


    }
}
