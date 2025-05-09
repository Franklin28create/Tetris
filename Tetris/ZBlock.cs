﻿namespace Tetris
{
    public class ZBlock
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] {new(0,0), new(0,1), new(1,1), new(1,2) },
            new Position[] {new(0, 2), new(1,1), new(1,2), new(2,1) },
            new Position[] {new(1,0), new(1,1), new(2,1), new(2,2) },
            new Position[] {new(1, 0), new(0, 1), new(1, 1), new(0, 2) },
        };
        public int Id => 7;
        protected Position StartOffset => new Position(0, 3);
        protected Position[][] Tiles => tiles;
    }
}
