using System;
using System.Collections.Generic;
using System.Drawing;

namespace EndgameCheckmatePractice
{
    abstract class ChessPiece
    {
        public readonly bool WHITE;
        // True if this piece is white, false if black

        public ChessSquare Square;
        // Square this piece is currently on

        public List<ChessSquare> Attacks;
        // List of all squares attacked or guarded by this piece (including squares containing
        // other pieces of the same color

        public List<ChessSquare> Moves;
        // List of all squares this piece can move to (not including squares containing other
        // pieces of the same color)

        public Image Icon;
        // 64*64 PNG icon with transparency

        public ChessPiece(bool white, ChessSquare square)
        {
            WHITE = white;
            this.move(square); // Sets this.Square and puts image on form

            // In inherited constructor, assign Attacks and Moves to new lists with capacity equal
            // to the maximum number of squares the piece can attack at once.
        }

        public abstract void attack(ChessSquare[,] squares);
        // Set this.Attacks, set this.Moves, and set WhiteAttacked/BlackAttacked to true for
        // attacked Squares

        public void move(ChessSquare newSquare)
        {
            if(this.Square != null)
                this.Square.Image = null;
            this.Square = newSquare;
            this.Square.Image = this.Icon;
        }
    }
}
