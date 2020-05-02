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
            throw new NotImplementedException();
        }

        public override void FindMoves(ChessSquare[,] squares)
        {
            // THIS CODE DOES NOT YET ACCOUNT FOR OTHER PIECES BLOCKING MOVEMENT
            this.Moves.Clear();
            base.findMovesInDirection(squares, dir: 0);
            base.findMovesInDirection(squares, dir: 2);
            base.findMovesInDirection(squares, dir: 4);
            base.findMovesInDirection(squares, dir: 6);
        }
    }
}
