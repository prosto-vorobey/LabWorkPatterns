static class NumLenght
{
    public static int GetLenght(int num)
    {
        int numLenght = 1;
        while (num / 10 != 0)
        {
            num /= 10;
            numLenght++;

        }
        return numLenght;

    }

}
