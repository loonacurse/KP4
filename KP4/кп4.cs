using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace kp4
{
    public class Task1
    {
        public Matrix<double> matrix { get; set; }
        public Vector<double> vector { get; set; }
        public int Variant { get; set; }

        public Task1(int variant, Matrix<double> matrix, Vector<double> vector)
        {
            this.matrix = matrix;
            this.vector = vector;
            this.Variant = variant;
        }
        public void SampleIterationMethod()
        {
            double v_1 = vector[0] / matrix[0, 0];
            double v_2 = vector[1] / matrix[1, 1];
            double v_3 = vector[2] / matrix[2, 2];
            double v_4 = vector[3] / matrix[3, 3];
            double x1 = 0, x2 = 0, x3 = 0, x4 = 0;
            double xk1, xk2, xk3, xk4;
            int k = 0;
            var flag = true;
            for (int i = 0; flag && i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    if (matrix[i, j] == 0 && i == j) { flag = false; break; }
                }
            }
            if (flag == true)
            {

                do
                {

                    k++;
                    xk1 = x1; xk2 = x2; xk3 = x3; xk4 = x4;
                    x1 = (vector[0] - matrix[0, 1] * v_2 - matrix[0, 2] * v_3 - matrix[0, 3] * v_4) / matrix[0, 0];
                    x2 = (vector[1] - matrix[1, 0] * v_1 - matrix[1, 2] * v_3 - matrix[1, 3] * v_4) / matrix[1, 1];
                    x3 = (vector[2] - matrix[2, 0] * v_1 - matrix[2, 1] * v_2 - matrix[2, 3] * v_4) / matrix[2, 2];
                    x4 = (vector[3] - matrix[3, 0] * v_1 - matrix[3, 1] * v_2 - matrix[3, 2] * v_3) / matrix[3, 3];
                    v_1 = x1; v_2 = x2; v_3 = x3; v_4 = x4;
                }
                while (Math.Abs(x1 - xk1) <= 1E-3 || Math.Abs(x2 - xk2) <= 1E-3 || Math.Abs(x3 - xk3) <= 1E-3 || Math.Abs(x4 - xk4) <= 1E-3);
                Console.WriteLine($"\n\n\n\t\t\tДля варiанту {Variant}\n\nx1 --> {x1}\nx2 --> {x2}\nx3 --> {x3}\nx4 --> {x4}\n\nIтерацiя --> {k}");
                if (matrix.L2Norm() < 1) { Console.WriteLine("\n\n\tУмова збiжностi виконана успiшно\n\n"); }
                else { Console.WriteLine("\n\n\tУмова збiжностi не виконується\n\n"); }

            }
            else
            {
                Console.WriteLine($"\n\n\t\t\tДля варiанту {Variant}\n\n\tДана слар не задовольняє умову для виконання методом iтерацiй\n\n\tIснує aii=0\n\n");
            }
        }
    }
    public class SLAR
    {
        
        public Vector<double> answers { get; set; }
        public double count { get; set; }
        public Vector<double> ThirdIterations { get; set; }
        public Matrix<double> matrix { get; set; }
        public Vector<double> vector { get; set; }
        public SLAR(Matrix<double> matrix, Vector<double> vector)
        {
            this.matrix = matrix;
            this.vector = vector;
        }
       
        public SLAR() { }
        public SLAR JacobiMethod()
        {
            double X0 = 0;
            double X_1 = X0, X_2 = X0, X_3 = X0, X_4 = X0;
            double XLast_1, XLast_2, XLast_3, XLast_4;
            double dx = double.MaxValue;
            double epsilon = 0.001;
            double count = 0;
            while (Math.Abs(dx) > epsilon)
            {
                XLast_1 = X_1;
                XLast_2 = X_2;
                XLast_3 = X_3;
                XLast_4 = X_4;
                X_1 = (1 / matrix[0, 0]) * (vector[0] - matrix[0, 1] * XLast_2 - matrix[0, 2] * XLast_3 - matrix[0, 3] * XLast_4);
                X_2 = (1 / matrix[1, 1]) * (vector[1] - matrix[1, 0] * XLast_1 - matrix[1, 2] * XLast_3 - matrix[1, 3] * XLast_4);
                X_3 = (1 / matrix[2, 2]) * (vector[2] - matrix[2, 0] * XLast_1 - matrix[2, 1] * XLast_2 - matrix[2, 3] * XLast_4);
                X_4 = (1 / matrix[3, 3]) * (vector[3] - matrix[3, 0] * XLast_1 - matrix[3, 1] * XLast_2 - matrix[3, 2] * XLast_3);
                double[] range = { X_1 - XLast_1, X_2 - XLast_2, X_3 - XLast_3, X_4 - XLast_4 };
                double max = range.Max();
                dx = max;
                count++;
                if (count == 3)
                {
                    ThirdIterations = Vector<double>.Build.Dense(new double[] { Math.Abs(X_1 - XLast_1), Math.Abs(X_2 - XLast_2), Math.Abs(X_3 - XLast_3), Math.Abs(X_4 - XLast_4) });
                }
            }
            this.count = count;
            answers = Vector<double>.Build.Dense(new double[] { X_1, X_2, X_3, X_4 });

            return this;
        }
        public SLAR GausMethod()
        {
            double X0 = 0;
            double X_1 = X0, X_2 = X0, X_3 = X0, X_4 = X0;
            double XLast_1, XLast_2, XLast_3, XLast_4;
            double dx = double.MaxValue;
            double epsilon = 0.001;
            double count = 0;
            while (Math.Abs(dx) > epsilon)
            {
                XLast_1 = X_1;
                XLast_2 = X_2;
                XLast_3 = X_3;
                XLast_4 = X_4;
                X_1 = (1 / matrix[0, 0]) * (vector[0] - matrix[0, 1] * XLast_2 - matrix[0, 2] * XLast_3 - matrix[0, 3] * XLast_4);
                X_2 = (1 / matrix[1, 1]) * (vector[1] - matrix[1, 0] * X_1 - matrix[1, 2] * XLast_3 - matrix[1, 3] * XLast_4);
                X_3 = (1 / matrix[2, 2]) * (vector[2] - matrix[2, 0] * X_1 - matrix[2, 1] * X_2 - matrix[2, 3] * XLast_4);
                X_4 = (1 / matrix[3, 3]) * (vector[3] - matrix[3, 0] * X_1 - matrix[3, 1] * X_2 - matrix[3, 2] * X_3);
                double[] range = { X_1 - XLast_1, X_2 - XLast_2, X_3 - XLast_3, X_4 - XLast_4 };
                double max = range.Max();
                dx = max;
                count++;
                if (count == 3)
                {
                    ThirdIterations = Vector<double>.Build.Dense(new double[] { Math.Abs(X_1 - XLast_1), Math.Abs(X_2 - XLast_2), Math.Abs(X_3 - XLast_3), Math.Abs(X_4 - XLast_4) });
                }
            }
            this.count = count;
            answers = Vector<double>.Build.Dense(new double[] { X_1, X_2, X_3, X_4 });
            return this;
        }

    }

}
