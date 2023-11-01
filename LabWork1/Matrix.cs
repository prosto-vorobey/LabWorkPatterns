﻿using System;

public interface IMatrix
{
    int NumColumns { get; }
    int NumRows { get; }
    int Get(int col, int row);
    void Set(int col, int row, int val);
    void Draw(IDrawerMatrix drawerMatrix);
    IMatrix GetComponent();

}
public abstract class AMatrix : IMatrix
{
    public int NumColumns
    {
        get;
        protected set;

    }
    public int NumRows
    {
        get;
        protected set;

    }
    public virtual void Set(int col, int row, int val)
    {
        try
        {
            if (col > NumColumns)
            {
                throw new IndexOutOfRangeException("Введённое положение столбца выходит за границы матрицы.");

            }
            if (row > NumRows)
            {
                throw new IndexOutOfRangeException("Введённое положение строки выходит за границы матрицы.");

            }
            GetMatrixVector()[col].Set(row, val);

        }
        catch (Exception ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }

    }
    public int Get(int col, int row)
    {
        int val = 0;
        try
        {
            val = GetMatrixVector()[col].Get(row);

        }
        catch (Exception ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }
        return val;

    }
    public virtual void Draw(IDrawerMatrix drawerMatrix)
    {
        drawerMatrix.DrawBorder(NumColumns, NumRows, GetLenghtMaxVal());

    }
    public IMatrix GetComponent()
    {
        return this;

    }
    protected abstract IVector[] GetMatrixVector();

    protected int GetLenghtMaxVal()
    {
        int valMax = new MatrixStatistic(this).ValMax;
        int maxValLenght = NumLenght.GetLenght(valMax);
        return maxValLenght;

    }

}
