using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    public abstract class King : ChessPiece
    {
        public override byte MAX_ATTACKS { get { return 8; } }

        public King(ChessSquare square) : base(square) { }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            for (int p = 0; p <= 7; ++p) // Do not use p < DIRECTIONS.Length, which = 14
            {
                int c = this.Square.COL + DIRECTIONS[p, 0];
                int r = this.Square.ROW + DIRECTIONS[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                {
                    if (this.WHITE)
                        squares[c, r].WhiteAttacked = true;
                    else
                        squares[c, r].BlackAttacked = true;
                }
            }
        }

        public override void FindMoves(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            for (int p = 0; p <= 7; ++p)
            {
                int c = this.Square.COL + DIRECTIONS[p, 0];
                int r = this.Square.ROW + DIRECTIONS[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                {
                    ChessSquare square = squares[c, r];
                    bool squareBlocked = square.Piece != null && square.Piece.WHITE == this.WHITE;
                    bool squareAttacked = this.WHITE ? square.BlackAttacked : square.WhiteAttacked;
                    if (!(squareBlocked || squareAttacked))
                        this.Moves.Add(square);
                }
            }
        }
    }
}
