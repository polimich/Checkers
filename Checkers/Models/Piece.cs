using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Models
{
    public class Piece
    {
        public int Type { get; set; } // 1 - normal, 2 - Dáma
        public int Color { get; set; } // 0 - černá, 1 = červená

        public Piece( int type, int color)
        {
            Color = color;
            Type = type;
        }
    }
}
