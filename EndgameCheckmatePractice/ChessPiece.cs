using System;
using System.Collections.Generic;
using System.Drawing;

namespace EndgameCheckmatePractice
{
    public abstract class ChessPiece
    {
        public abstract bool WHITE { get; }
        // True if this piece is white, false if black

        public abstract Image ICON { get; }
        // 64*64 PNG icon with transparency

        public abstract byte MAX_ATTACKS { get; }
        // Maximum number of squares this piece can attack at once (for example, 14 for Rook)

        public ChessSquare Square;
        // Square this piece is currently on

        public List<ChessSquare> Attacks { get; }
        // List of all squares attacked or guarded by this piece.

        public List<ChessSquare> Moves { get; }
        // List of all squares this piece can move to. This is different from Attacks for two
        // reasons: First, pieces of the same color as this piece may be attacked/guarded by this
        // piece without this piece being able to move to those pieces' squares immediately.
        // Second, a rook, bishops, or queen may attack squares behind a piece of the opposite
        // color without being able to move to those squares because it would have to stop to take
        // that piece.

        public void Move(ChessSquare newSquare)
        // Removes this ChessPiece from its current Square and moves it to newSquare. The Squares'
        // images are automatically updated in that class
        {
            if (this.Square != null)
                this.Square.Piece = null;
            this.Square = newSquare;
            this.Square.Piece = this;
        }

        public abstract void FindAttacks(ChessSquare[,] squares);
        // Finds what Squares are attacked by this piece. Sets this.Attacks accordingly, and sets
        // WhiteAttacked/BlackAttacked to true for attacked Squares.

        public abstract void FindMoves(ChessSquare[,] squares);
        // Finds what Squares this piece can move to. Sets this.Moves accordingly.

        public ChessPiece(ChessSquare square)
        {
            this.Move(square);
            this.Attacks = new List<ChessSquare>(capacity: MAX_ATTACKS);
            this.Moves = new List<ChessSquare>(capacity: MAX_ATTACKS);
        }

        protected void findMovesInDirection(ChessSquare[,] squares, byte dir)
        // Adds to this.Moves (without clearing this.Moves first, unlike FindMoves()) by finding
        // the squares along an orthogonal or diagonal ray in direction dir that a piece moving
        // in that direction would be able to move to. In other words, finds the squares that a
        // queen moving in direction dir would be able to move to without being blocked or leaving
        // the board. This method is only applicable to queens, rooks, bishops.
        // dir stores a value from 0 to 7. From square (3,3) in the center, dir 0 points to (7,3),
        // dir 1 points to (7,7), ..., dir 7 points to (7,0).
        {
            if (dir < 0)
                throw new ArgumentException("dir < 0");
            if (dir > 7)
                throw new ArgumentException("dir > 7");

            int dc = 0, dr = 0; // change in coordinates per square in line
            switch(dir)
            {
                case 0: case 1: case 7: dc = 1; break;
                case 3: case 4: case 5: dc = -1; break;
                // In cases 2 and 6, keep previous value 0
            }
            switch(dir)
            {
                case 1: case 2: case 3: dr = 1; break;
                case 5: case 6: case 7: dr = -1; break;
                // In cases 0 and 4, keep previous value 0
            }

            int c = this.Square.COL + dc;
            int r = this.Square.ROW + dr;
            while (c >= 0 && r >= 0 && c <= 7 && r <= 7)
            {
                ChessSquare square = squares[c, r];
                if (square.Piece != null && (square.Piece.WHITE == this.WHITE))
                    break;
                this.Moves.Add(square);
                if (square.Piece != null)
                    break;
                c += dc;
                r += dr;
            }
        }
    }
}
