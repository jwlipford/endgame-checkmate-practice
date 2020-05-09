using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteQueen : ChessPiece
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Image.FromFile(@"..\..\images\white_queen.png"); }
        }

        public override byte MAX_ATTACKS { get { return 27; } }

        public WhiteQueen(ChessSquare square) : base(square) { }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            for (byte d = 0; d <= 7; ++d)
                FindAttacksInDirection(squares, d);
        }

        public override void FindMoves(ChessSquare[,] squares)
        {
            Moves.Clear();
            for (byte d = 0; d <= 7; ++d)
                FindMovesInDirection(squares, d);
        }
    }
}
