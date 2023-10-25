using System;

public class MatrixStatistic
{
    public int ValSumm
    {
        get;

    }
    public float ValAver
    {
        get;

    }
    public int ValMax
    {
        get;

    }
    public int ValNotNull
    {
        get;

    }
    public MatrixStatistic(IMatrix matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.NumColumns; i++)
        {
            for (int j = 0; j < matrix.NumRows; j++)
            {
                int val = matrix.Get(i, j);
                ValSumm += val;
                count++;
                if (val >= ValMax)
                {
                    ValMax = val;

                }
                if (val != 0)
                {
                    ValNotNull++;

                }

            }

        }
        ValAver = (float)ValSumm / count;


    }
    public void ShowAllMatrixStatistic()
    {
        Console.WriteLine($"Статистика по заданной обычной матрице.\n" +
            $"Сумма всех значений: {ValSumm}\n" +
            $"Среднее значение: {ValAver}\n" +
            $"Максимальное значение: {ValMax}\n" +
            $"Число ненулевых значений: {ValNotNull}\n");

    }

}
