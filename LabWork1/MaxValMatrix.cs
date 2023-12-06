public static class MaxValMatrix
{
    public static int GetLenghtMaxVal(IMatrix matrix)
    {
        int valMax = new MatrixStatistic(matrix).ValMax;
        int maxValLenght = NumLenght.GetLenght(valMax);
        return maxValLenght;

    }

}