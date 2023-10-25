using System;

public class MatrixInitiator
{
    public static void FillMatrix(IMatrix matrix, int valNotNull, int valMax)
    {
        int cols = matrix.NumColumns;
        int rows = matrix.NumRows;
        int dimension = cols * rows;
        try
        {
            if (valNotNull > dimension)
            {
                throw new IndexOutOfRangeException("Введённое количество ненулевых элементов превышает размерность матрицы.");

            }
            if ((valNotNull == 0) && (valMax != 0))
            {
                throw new Exception("У нулевой матрицы максимальное значение должно быть равно 0.");

            }
            int rndCol, rndRow;
            Random rnd = new Random();
            int count = valNotNull;
            rndCol = rnd.Next(cols);
            rndRow = rnd.Next(rows);
            matrix.Set(rndCol, rndRow, valMax);
            count--;
            while (count != 0)
            {
                rndCol = rnd.Next(cols);
                rndRow = rnd.Next(rows);
                int rndVal = rnd.Next(valMax);
                if (matrix.Get(rndCol, rndRow) == 0 && rndVal != 0)
                {
                    matrix.Set(rndCol, rndRow, rndVal);
                    count--;

                }

            }

        }
        catch (Exception ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }

    }

}
