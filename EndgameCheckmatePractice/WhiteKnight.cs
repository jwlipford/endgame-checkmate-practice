using System;
using System.Collections.Generic;
using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteKnight : ChessPiece
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get
            {
                return Image.FromFile(@"..\..\images\white_knight.png");
            }
        }

        public override byte MAX_ATTACKS { get { return 8; } }

        public WhiteKnight(ChessSquare square) : base(square) { }

        private static readonly sbyte[,] POSSIBLE_RELATIVE_MOVES = new sbyte[8, 2]
        // 8 pairs, each representing the relative coordinates of a square this knight can move to
        // (unless another white piece is on the square or the square is off the board)
        {
            {2,-1}, {2,1}, {1,2}, {-1,2}, {-2,1}, {-2,-1}, {-1,-2}, {1,-2}
        };

        public override void FindMoves(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            for (int p = 0; p <= 7; ++p)
            {
                int c = this.Square.COL + POSSIBLE_RELATIVE_MOVES[p, 0];
                int r = this.Square.ROW + POSSIBLE_RELATIVE_MOVES[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                {
                    ChessSquare square = squares[c, r];
                    if (square.Piece == null || !square.Piece.WHITE)
                        this.Moves.Add(square);
                }
            }
        }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            for (int p = 0; p <= 7; ++p)
            {
                int c = this.Square.COL + POSSIBLE_RELATIVE_MOVES[p, 0];
                int r = this.Square.ROW + POSSIBLE_RELATIVE_MOVES[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                {
                    ChessSquare square = squares[c, r];
                    // Unlike in FindMoves, add square even if a white piece is on it.
                    this.Moves.Add(square);
                    square.WhiteAttacked = true;
                }
            }
        }
    }
}
