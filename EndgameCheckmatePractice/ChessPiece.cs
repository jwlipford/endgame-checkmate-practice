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

        public static sbyte[,] DIRECTIONS = new sbyte[8,2]
        // 8 pairs, each representing an orthogonal or diagonal direction as a vector. This array
        // can represent the change in coordinates as a piece moves, the relative coordinates of
        // the squares adjacent to a square, etc.
        {
            {1,0}, {1,1}, {0,1}, {-1,1}, {-1,0}, {-1,-1}, {0,-1}, {1,-1} // no {0,0}
        };

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

        protected void FindMovesInDirection(ChessSquare[,] squares, byte dir)
        // Adds to this.Moves (without clearing this.Moves first, unlike FindMoves()) by finding
        // the squares along an orthogonal or diagonal ray in direction dir that a piece moving
        // in that direction would be able to move to. In other words, finds the squares that a
        // queen moving in direction dir would be able to move to without being blocked or leaving
        // the board. This method is only applicable to queens, rooks, and bishops.
        // dir stores a value from 0 to 7. From square (3,3) in the center, dir 0 points to (7,3),
        // dir 1 points to (7,7), ..., dir 7 points to (7,0). In other words, dir d corresponds to
        // the vector represented by the dth pair in DIRECTIONS, where column comes before row in
        // the pair.
        {
            if (dir < 0)
                throw new ArgumentException("dir < 0");
            if (dir > 7)
                throw new ArgumentException("dir > 7");

            // (dc,dr) = change in coordinates per square in line
            sbyte dc = DIRECTIONS[dir, 0];
            sbyte dr = DIRECTIONS[dir, 1];

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

        protected void FindAttacksInDirection(ChessSquare[,] squares, byte dir)
        // Similar to FindMovesInDirection, but finds Attacks instead of Moves. Also sets
        // WhiteAttacked or BlackAttacked to true for all attacked squares.
        // This method is implemented almost exactly the same as FindMovesInDirection. Only the
        // body of the while loop is different.
        {
            if (dir < 0)
                throw new ArgumentException("dir < 0");
            if (dir > 7)
                throw new ArgumentException("dir > 7");

            // (dc,dr) = change in coordinates per square in line
            sbyte dc = DIRECTIONS[dir, 0];
            sbyte dr = DIRECTIONS[dir, 1];

            int c = this.Square.COL + dc;
            int r = this.Square.ROW + dr;
            while (c >= 0 && r >= 0 && c <= 7 && r <= 7)
            {
                ChessSquare square = squares[c, r];

                // Unlike in FindMovesInDirection, set square.WhiteAttacked or .BlackAttacked.
                if (WHITE)
                    square.WhiteAttacked = true;
                else
                    square.BlackAttacked = true;

                // Unlike in FindMovesInDirection, check for a piece of the same color after adding
                // the square.
                this.Attacks.Add(square);
                if (square.Piece != null && (square.Piece.WHITE == this.WHITE))
                    break;

                // Unlike in FindMovesInDirection, do not check for a piece of the opposite color.
                // The line of attack can move through such a piece.

                c += dc;
                r += dr;
            }
        }
    }
}
