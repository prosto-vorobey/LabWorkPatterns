﻿using System;

public class MatrixSymmetry : AMatrix
{
    /*    private OrdinaryVector[] _vectors;
        public override IVector[] GetMatrixVector(int cols, int rows)
        {
            _vectors = new OrdinaryVector[cols];
            for (int i = 0; i < cols; i++)
            {
                _vectors[i] = new OrdinaryVector(rows);

            }
            return _vectors;

        }
        public override void Draw(IMatrix matrix,IDrawerMatrix drawerMatrix)
        {
            for (int i = 0; i < matrix.NumColumns; i++)
            {
                for (int j = 0; j < matrix.NumRows; j++)
                {
                    int num = matrix.Get(i, j);
                    drawerMatrix.DrawCellBorder(i, j, GetLenghtMaxVal(matrix));
                    drawerMatrix.DrawContent(num.ToString(), i, j, GetLenghtMaxVal(matrix));

                }

            }
            base.Draw(matrix, drawerMatrix);

        }*/
    public override void Accept(IMatrixVisitor drawerMatrix)
    {
        throw new NotImplementedException();
    }

    protected override IVector[] GetVector()
    {
        throw new NotImplementedException();
    }
}
