using System.Collections.Generic;
using System.Drawing;
using System;

namespace EndgameCheckmatePractice
{
    class BlackKing : King
    {
        public override bool WHITE { get { return false; } }

        public override Image ICON
        {
            get { return Image.FromFile(@"..\..\images\black_king.png"); }
        }

        private readonly Random RANDOM;

        public BlackKing(ChessSquare square) : base(square)
        {
            this.RANDOM = new Random();
        }

        public ChessSquare ChooseMove()
        // Call this method after calling findMoves. If the black king can capture one or more
        // unprotected pieces, it randomly chooses between them and returns its choice's square.
        // If it can move nowhere, it returns null, indicating checkmate or stalemate (depending
        // on whether this.Square.WhiteAttacked). Otherwise, it chooses and returns a random square
        // it can move to.
        {
            if (this.Moves.Count == 0)
                return null;
            List<ChessSquare> unprotecteds = new List<ChessSquare>(capacity: this.Moves.Count);
            foreach (ChessSquare square in this.Moves)
                if (square.Piece != null && square.Piece.WHITE)
                    unprotecteds.Add(square);
                    // If square was WhiteAttacked, it would not have been in this.Moves in the
                    // first place.
            if (unprotecteds.Count == 0)
                return this.Moves[this.RANDOM.Next(this.Moves.Count)];
            else
                return unprotecteds[this.RANDOM.Next(unprotecteds.Count)];
        }
    }
}
