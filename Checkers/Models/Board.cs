using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Models
{
    public class Board
    {
        private const int Lenght = 8;
        private const int Width = 8;
        private Piece[,] Storage;
        public Board()
        {
            this.Storage = new Piece[Lenght, Width];
        }
    }
}
