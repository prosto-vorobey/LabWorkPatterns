using System;

public interface IDrawMatrixStrategy
{
    void Draw (int val, int col, int row, IDrawerMatrix drawerMatrix);

}