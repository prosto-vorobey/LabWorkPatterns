using System;
using System.Windows.Forms;

static class Client
{
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        //IMatrix ordMatrix = new OrdinaryMatrix(7, 9);
        //IMatrix disMatrix = new DischargedMatrix(10, 10);
        //MatrixInitiator.FillMatrix(ordMatrix, 33, 99);
        //MatrixInitiator.FillMatrix(disMatrix, 72, 99);
        //MatrixStatistic matStat1 = new MatrixStatistic(ordMatrix);
        //MatrixStatistic matStat2 = new MatrixStatistic(disMatrix);
        //matStat1.ShowAllMatrixStatistic();
        //matStat2.ShowAllMatrixStatistic();
        Application.Run(new ClientForm());

    }

}
