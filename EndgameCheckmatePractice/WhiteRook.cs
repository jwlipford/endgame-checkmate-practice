using System;
using System.Collections.Generic;
using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteRook : ChessPiece
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get
            {
                return Image.FromFile(@"..\..\images\white_rook.png");
                // This relative filepath works!
            }
        }

        public override byte MAX_ATTACKS { get { return 14; } }

        public WhiteRook(ChessSquare square) : base(square) { }

        public override void FindAttacks(ChessSquare[,] squares)
        {
            base.FindAttacksInDirection(squares, dir: 0);
            base.FindAttacksInDirection(squares, dir: 2);
            base.FindAttacksInDirection(squares, dir: 4);
            base.FindAttacksInDirection(squares, dir: 6);
        }

        public override void FindMoves(ChessSquare[,] squares)
        {
            this.Moves.Clear();
            base.FindMovesInDirection(squares, dir: 0);
            base.FindMovesInDirection(squares, dir: 2);
            base.FindMovesInDirection(squares, dir: 4);
            base.FindMovesInDirection(squares, dir: 6);
        }
    }
}
