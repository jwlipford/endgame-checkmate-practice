using System;
using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteBishop : ChessPiece
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_bishop; }
        }

        public override byte MAX_ATTACKS { get { return 13; } }

        public WhiteBishop(ChessSquare square) : base(square) { }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            base.FindAttacksInDirection(squares, dir: 1);
            base.FindAttacksInDirection(squares, dir: 3);
            base.FindAttacksInDirection(squares, dir: 5);
            base.FindAttacksInDirection(squares, dir: 7);
        }

        public override void FindMoves(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            base.FindMovesInDirection(squares, dir: 1);
            base.FindMovesInDirection(squares, dir: 3);
            base.FindMovesInDirection(squares, dir: 5);
            base.FindMovesInDirection(squares, dir: 7);
        }
    }
}
