using System;
using System.Windows.Forms;

static class Client
{
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        IMatrix ordMatrix = new OrdinaryMatrix(7, 9);
        IMatrix disMatrix = new DischargedMatrix(10, 10);
        MatrixInitiator.FillMatrix(ordMatrix, 33, 99);
        MatrixInitiator.FillMatrix(disMatrix, 72, 99);
        MatrixStatistic matStat1 = new MatrixStatistic(ordMatrix);
        MatrixStatistic matStat2 = new MatrixStatistic(disMatrix);
        matStat1.ShowAllMatrixStatistic();
        matStat2.ShowAllMatrixStatistic();
        //Console.ReadLine();
        //IMatrix symMatrix = new SymmetryMatrix(5);
        //int[,] symMat = new int[5, 5] { { 0, 10, 2, 0, 5 }, {10, 4, 1, 0, 0}, {2, 1, 3, 2, 2}, {0, 0, 2, 4, 3}, {5, 0, 2, 3, 0} };
        //symMatrix.WriteMatrix(symMat);
        //MatrixStatistic matStat3 = new MatrixStatistic(symMatrix);
        //Console.WriteLine($"Статистика по заданной разреженной матрице.\n" +
        //    $"Сумма всех значений: {matStat3.ValSumm}\n" +
        //    $"Среднее значение: {matStat3.ValAver}\n" +
        //    $"Максимальное значение: {matStat3.ValMax}\n" +
        //    $"Число ненулевых значений: {matStat3.ValNotNull}\n");
        Application.Run(new ClientForm());

    }

}
