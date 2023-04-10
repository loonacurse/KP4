using System;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

/*Matrix<double> M15 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.23,-0.14, 0.06,-0.12},
    {0.12, 0, 0.32,-0.18},
    {0.08,-0.12,0.23,0.32},
    { 0.25,0.22,0.14,0}
});
Vector<double> B15 = Vector<double>.Build.Dense(new double[] { -1.21, 0.72, 0.58, -1.56 });
Matrix<double> M16 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.14,0.23, 0.18,0.17},
    {0.12, -0.14, 0.08,0.09},
    {0.16,0.24,0,-0.35},
    { 0.23,-0.08,0.05,0.25}
});
Vector<double> B16 = Vector<double>.Build.Dense(new double[] { 1.42, 0.83, -1.21, -0.65 });
Matrix<double> M23 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0,0.17, -0.33,0.18},
    {0, 0.18, 0.43,-0.08},
    {0.22,0.18,0.21,0.007},
    { 0.08,0.07,0.21,0.04}
});
Vector<double> B23 = Vector<double>.Build.Dense(new double[] { 1.2, -0.33, -0.48, 1.2 });
Matrix<double> M24 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.03,-0.05, 0.22,-0.33},
    {0.22, 0.55, -0.08,0.07},
    {0.33,0.13,-0.08,-0.05},
    { 0.08,0.17,0.29,0.33}
});
Vector<double> B24 = Vector<double>.Build.Dense(new double[] { -0.43, 1.8, 0.8, -1.7 });
void SampleIteration(int variant, Matrix<double> m, Vector<double> v)
{
    double v_1 = v[0] / m[0, 0];
    double v_2 = v[1] / m[1, 1];
    double v_3 = v[2] / m[2, 2];
    double v_4 = v[3] / m[3, 3];
    double x1 = 0, x2 = 0, x3 = 0, x4 = 0;
    double xk1, xk2, xk3, xk4;
    int k = 0;
    var flag = true;
    for (int i = 0; flag && i < m.RowCount; i++)
    {
        for (int j = 0; j < m.ColumnCount; j++)
        {
            if (m[i, j] == 0 && i == j) { flag = false; break; }
        }
    }
    if (flag == true)
    {

        do
        {

            k++;
            xk1 = x1; xk2 = x2; xk3 = x3; xk4 = x4;
            x1 = (v[0] - m[0, 1] * v_2 - m[0, 2] * v_3 - m[0, 3] * v_4) / m[0, 0];
            x2 = (v[1] - m[1, 0] * v_1 - m[1, 2] * v_3 - m[1, 3] * v_4) / m[1, 1];
            x3 = (v[2] - m[2, 0] * v_1 - m[2, 1] * v_2 - m[2, 3] * v_4) / m[2, 2];
            x4 = (v[3] - m[3, 0] * v_1 - m[3, 1] * v_2 - m[3, 2] * v_3) / m[3, 3];
            v_1 = x1; v_2 = x2; v_3 = x3; v_4 = x4;
        }
        while (Math.Abs(x1 - xk1) <= 1E-3 || Math.Abs(x2 - xk2) <= 1E-3 || Math.Abs(x3 - xk3) <= 1E-3 || Math.Abs(x4 - xk4) <= 1E-3);
        Console.WriteLine($"\n\n\n\t\t\tДля варiанту {variant}\n\nx1 --> {x1}\nx2 --> {x2}\nx3 --> {x3}\nx4 --> {x4}\n\nIтерацiя --> {k}");
        if (m.L2Norm() < 1) { Console.WriteLine("\n\n\tУмова збiжностi виконана успiшно\n\n"); }
        else { Console.WriteLine("\n\n\tУмова збiжностi не виконується\n\n"); }

    }
    else
    {
        Console.WriteLine($"\n\n\t\t\tДля варiанту {variant}\n\n\tДана слар не задовольняє умову для виконання методом iтерацiй\n\n\tIснує aii=0\n\n");
    }

}
SampleIteration(15, M15, B15);
SampleIteration(16, M16, B16);
SampleIteration(23, M23, B23);
SampleIteration(24, M24, B24);
*/