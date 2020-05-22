using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndgameCheckmatePractice
{
    abstract class ChessLeaper : ChessPiece
    // A chess piece such as a knight, that leaps
    {
        protected abstract sbyte[,] POSSIBLE_RELATIVE_MOVES { get; }
        // This array should have dimensions [MAX_ATTACKS,2]. Each column should be a pair
        // representing the relative coordinates {COL,ROW} of a square this piece can move to
        // (unless another piece of the same color is on the square or the square is off the
        // board). For example, a Knight's possible relative moves are {{2,-1}, {2,1}, ...}.

        public override sealed byte MAX_ATTACKS
        {
            get { return (byte)(POSSIBLE_RELATIVE_MOVES.GetUpperBound(0) + 1); }
        }

        public ChessLeaper(ChessSquare square) : base(square)
        {
            if (POSSIBLE_RELATIVE_MOVES.GetUpperBound(1) != 1) // If not a [_,2] array
                throw new Exception(
                    "POSSIBLE_RELATIVE_MOVES's 2nd dimension does not have length 2");
        }

        public override void FindMoves(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            for (int p = MAX_ATTACKS - 1; p >= 0; --p)
            {
                int c = this.Square.COL + POSSIBLE_RELATIVE_MOVES[p, 0];
                int r = this.Square.ROW + POSSIBLE_RELATIVE_MOVES[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                {
                    ChessSquare square = squares[c, r];
                    if (square.Piece == null || square.Piece.WHITE != this.WHITE)
                        this.Moves.Add(square);
                }
            }
        }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            for (int p = MAX_ATTACKS - 1; p >= 0; --p)
            {
                int c = this.Square.COL + POSSIBLE_RELATIVE_MOVES[p, 0];
                int r = this.Square.ROW + POSSIBLE_RELATIVE_MOVES[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                    squares[c, r].WhiteAttacked = true;
            }
        }
    }
}
