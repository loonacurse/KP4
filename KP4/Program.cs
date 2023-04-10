using kp4;
using MathNet.Numerics.LinearAlgebra;
Matrix<double> m15 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.23,-0.14, 0.06,-0.12},
    {0.12, 0, 0.32,-0.18},
    {0.08,-0.12,0.23,0.32},
    { 0.25,0.22,0.14,0}
});
Vector<double> v15 = Vector<double>.Build.Dense(new double[] { -1.21, 0.72, 0.58, -1.56 });
Matrix<double> m16 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.14,0.23, 0.18,0.17},
    {0.12, -0.14, 0.08,0.09},
    {0.16,0.24,0,-0.35},
    { 0.23,-0.08,0.05,0.25}
});
Vector<double> v16 = Vector<double>.Build.Dense(new double[] { 1.42, 0.83, -1.21, -0.65 });
Matrix<double> m23 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0,0.17, -0.33,0.18},
    {0, 0.18, 0.43,-0.08},
    {0.22,0.18,0.21,0.007},
    { 0.08,0.07,0.21,0.04}
});
Vector<double> v23 = Vector<double>.Build.Dense(new double[] { 1.2, -0.33, -0.48, 1.2 });
Matrix<double> m24 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {0.03,-0.05, 0.22,-0.33},
    {0.22, 0.55, -0.08,0.07},
    {0.33,0.13,-0.08,-0.05},
    { 0.08,0.17,0.29,0.33}
});
Vector<double> v24 = Vector<double>.Build.Dense(new double[] { -0.43, 1.8, 0.8, -1.7 });
Task1 Slar15 = new Task1(15, m15, v15);
Slar15.SampleIterationMethod();
Task1 Slar16 = new Task1(16, m16, v16);
Slar16.SampleIterationMethod();
Task1 Slar23 = new Task1(23, m23, v23);
Slar23.SampleIterationMethod();
Task1 Slar24 = new Task1(24, m24, v24);
Slar24.SampleIterationMethod();

Matrix<double> A15 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {5.452, 0.401, 0.758,0.123},
    {0.785, 2.654, 0.687,0.203},
    {0.402,0.244,4.456,0.552},
    {0.210,0.514,0.206,4.568}
});
Vector<double> B15 = Vector<double>.Build.Dense(new double[] { 0.886, 0.356, 0.342, 0.452 });
Matrix<double> A16 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {2.923, 0.220,0.159,0.328},
    {0.363,4.123,0.268,0.327},
    {0.169,0.271,3.906,0.295},
    {0.241,0.319,0.257,3.862}
});
Vector<double> B16 = Vector<double>.Build.Dense(new double[] { 0.605, 0.496, 0.590, 0.896 });
Matrix<double> A23 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {3.476,0.259,0.376,0.398},
    {0.425,4.583,0.417,0.328},
    {0.252,0.439,3.972,0.238},
    {0.265,0.291,0.424,3.864}
});
Vector<double> B23 = Vector<double>.Build.Dense(new double[] { 0.871, 0.739, 0.644, 0.581 });
Matrix<double> A24 = Matrix<double>.Build.DenseOfArray(new double[,]{
    {3.241,0.197,0.643,0.236},
    {0.257,3.853,0.342,0.427},
    {0.324,0.317,2.793,0.238},
    {0.438,0.326,0.483,4.229}
});
Vector<double> B24 = Vector<double>.Build.Dense(new double[] { 0.454, 0.371, 0.465, 0.822 });
SLAR slar15 = new SLAR(A15, B15);
SLAR slar16 = new SLAR(A16, B16);
SLAR slar23 = new SLAR(A23, B23);
SLAR slar24 = new SLAR(A24, B24);
slar15.JacobiMethod();
slar16.JacobiMethod();
slar23.JacobiMethod();
slar24.JacobiMethod();
Console.WriteLine($"{slar16.answers.ToString()}\n Кiлькiсть iтерацiй:{slar15.count}\n Похибки на 3 iтерацiї: \n{slar15.ThirdIterations}");
Console.WriteLine($"{slar16.answers.ToString()}\n Кiлькiсть iтерацiй:{slar16.count}\n Похибки на 3 iтерацiї: \n{slar16.ThirdIterations}");
Console.WriteLine($"{slar23.answers.ToString()}\n Кiлькiсть iтерацiй:{slar23.count}\n Похибки на 3 iтерацiї: \n{slar23.ThirdIterations}");
Console.WriteLine($"{slar24.answers.ToString()}\n Кiлькiсть iтерацiй:{slar24.count}\n Похибки на 3 iтерацiї: \n{slar24.ThirdIterations}");
slar15.GausMethod();
slar16.GausMethod();
slar23.GausMethod();
slar24.GausMethod();
Console.WriteLine($"{slar16.answers.ToString()}\n Кiлькiсть iтерацiй:{slar15.count}\n Похибки на 3 iтерацiї: \n{slar15.ThirdIterations}");
Console.WriteLine($"{slar16.answers.ToString()}\n Кiлькiсть iтерацiй:{slar16.count}\n Похибки на 3 iтерацiї: \n{slar16.ThirdIterations}");
Console.WriteLine($"{slar23.answers.ToString()}\n Кiлькiсть iтерацiй:{slar23.count}\n Похибки на 3 iтерацiї: \n{slar23.ThirdIterations}");
Console.WriteLine($"{slar24.answers.ToString()}\n Кiлькiсть iтерацiй:{slar24.count}\n Похибки на 3 iтерацiї: \n{slar24.ThirdIterations}");