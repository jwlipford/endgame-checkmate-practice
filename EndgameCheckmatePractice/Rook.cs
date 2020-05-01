using System;
using System.Collections.Generic;
using System.Drawing;

namespace EndgameCheckmatePractice
{
    class Rook : ChessPiece
    {
        public Rook(bool white, ChessSquare square) : base(white, square)
        {
            Attacks = new List<ChessSquare>(capacity: 14);
            Moves = new List<ChessSquare>(capacity: 14);
            // Rook can attack at most 14 squares at once

            if (white)
                Icon = Image.FromFile(
                    @"C:\Users\Jeffrey Lipford\Documents\GitHub\EndgameCheckmatePractice\" +
                    @"EndgameCheckmatePractice\images\white_rook.png"); // MAKE PATH RELATIVE
            square.Image = Icon;
        }

        public override void attack(ChessSquare[,] squares)
        {
            for(byte c = this.Square.COL; c < 8; ++c)
            {
                // ...

            }
        }
    }
}
