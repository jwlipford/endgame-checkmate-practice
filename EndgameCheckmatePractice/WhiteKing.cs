using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    class WhiteKing : ChessPiece
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get
            {
                return Image.FromFile(@"..\..\images\white_king.png");
            }
        }

        public override byte MAX_ATTACKS { get { return 8; } }

        public WhiteKing(ChessSquare square) : base(square) { }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            MessageBox.Show("WhiteKing.FindAttacks(ChessSquare[,])\nNot impemented!");
        }

        public override void FindMoves(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            for (int p = 0; p <= 7; ++p ) // Do not use p < DIRECTIONS.Length, which = 14
            {
                int c = this.Square.COL + DIRECTIONS[p, 0];
                int r = this.Square.ROW + DIRECTIONS[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                {
                    ChessSquare square = squares[c, r];
                    if (!square.BlackAttacked && (square.Piece == null || !square.Piece.WHITE))
                        this.Moves.Add(square);
                }
            }
        }
    }
}
