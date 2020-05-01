using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EndgameCheckmatePractice
{
    class ChessSquare : System.Windows.Forms.PictureBox
    {
        public readonly byte COL, ROW;
        // Column and row, each from 0 to 7, starting from left/bottom

        private readonly Color normalBackColor;
        // Normal background color

        public bool WhiteAttacked, BlackAttacked;
        // Whether at least one white/black piece is attacking this Square

        private ChessPiece piece;
        public ChessPiece Piece
        // The ChessPiece occupying this square, or null if empty
        {
            get
            {
                return piece;
            }
            set
            {
                piece = value;
                Image = null; // PLACEHOLDER -- CHANGE GRAPHICS!
            }
        }

        public ChessSquare(byte col, byte row)
        {
            COL = col;
            ROW = row;
            WhiteAttacked = false;
            BlackAttacked = false;
            Piece = null;

            normalBackColor = (COL % 2 == ROW % 2) ? Color.Brown : Color.Tan; // Change colors??
            BackColor = normalBackColor; // BackColor field inherited from PictureBox
        }
    }
}
