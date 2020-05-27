using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteMann : ChessPiece
    // This is a fairy piece! It moves 1 square in any direction -- like a King, except it can move
    // into attack. Though it does not jump because it only moves 1 square, it can still be modeled
    // as a leaper.
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_fairy_mann; }
        }

        public override byte MAX_ATTACKS { get { return 8; } }

        public WhiteMann(ChessSquare square) : base(square) { }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            for (int p = 0; p <= 7; ++p)
            {
                int c = this.Square.COL + DIRECTIONS[p, 0];
                int r = this.Square.ROW + DIRECTIONS[p, 1];
                if (c >= 0 && r >= 0 && c <= 7 && r <= 7)
                    squares[c, r].WhiteAttacked = true;
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
                    if (square.Piece == null || !square.Piece.WHITE)
                        this.Moves.Add(square);
                }
            }
        }
    }
}
