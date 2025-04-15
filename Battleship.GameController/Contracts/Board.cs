using System;
using System.Numerics;

namespace Battleship.GameController.Contracts;

    /// <summary>
    /// Basic definition of a Board
    /// </summary>

public class Board {
    public int Height;
    public int  Width;

    public Dictionary<Tuple<Letters, int>, Position> LocationGrid = new Dictionary<Tuple<Letters, int>, Position>();

    public Board (int height,int width)
    {
        this.Height = height;
        this.Width = width;
        for (int w = 1; w < width; w ++)
        {
            for (int h = 1; h < height; h ++ )
            {
                this.LocationGrid.Add(new Tuple<Letters, int>((Letters)w,h), new Position((Letters)height, width));
            }
        }
    }
}

