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

        public List<ChessSquare> Moves { get; }
        // List of all squares this piece can move to. This list does not include squares on which
        // there are pieces of the same color that this piece is protecting.

        public static sbyte[,] DIRECTIONS = new sbyte[8,2]
        // 8 pairs, each representing an orthogonal or diagonal direction as a vector. This array
        // can represent the change in coordinates as a piece moves, the relative coordinates of
        // the squares adjacent to a square, etc.
        {
            {1,0}, {1,1}, {0,1}, {-1,1}, {-1,0}, {-1,-1}, {0,-1}, {1,-1} // no {0,0}
        };

        public void Move(ChessSquare newSquare)
        // Removes this ChessPiece from its current ChessSquare and moves it to newSquare. If a
        // piece is on newSquare, that piece is replaced (captured) by this piece. The two
        // ChessSquares' images are automatically updated in that class through assignment.
        {
            if (this.Square != null)
                this.Square.Piece = null;
            if (newSquare.Piece != null)
                newSquare.Piece.Square = null;
            this.Square = newSquare;
            newSquare.Piece = this;
            // The first 4 lines are just as important as the last 2. Omitting them caused errors.
        }

        public abstract void FindAttacks(ChessSquare[,] squares);
        // Finds what Squares are attacked by this piece. Sets WhiteAttacked/BlackAttacked to true
        // for those Squares.

        public abstract void FindMoves(ChessSquare[,] squares);
        // Finds what Squares this piece can move to. Sets this.Moves to a list of all and only
        // those squares.

        public ChessPiece(ChessSquare square)
        {
            this.Move(square);
            this.Moves = new List<ChessSquare>(capacity: MAX_ATTACKS);
        }

        public override string ToString()
        {
            return this.GetType().Name + " on " + this.Square.ToString();
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
        // Similar to FindMovesInDirection. Sets WhiteAttacked or BlackAttacked to true for all
        // attacked squares in direction dir. The line of attack is blocked by a piece of the same
        // color but, unlike the line of moves, continues beyond a piece of the opposite color.
        // This method is implemented almost exactly the same as FindMovesInDirection. Only the
        // middle of the body of the while loop is different.
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

                if (WHITE)
                    square.WhiteAttacked = true;
                else
                    square.BlackAttacked = true;

                if (square.Piece != null && (square.Piece.WHITE == this.WHITE))
                    break;

                c += dc;
                r += dr;
            }
        }
    }
}
