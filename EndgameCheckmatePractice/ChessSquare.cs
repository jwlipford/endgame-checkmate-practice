using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    public class ChessSquare : System.Windows.Forms.PictureBox
    {
        public readonly byte COL, ROW;
        // Column and row, each from 0 to 7, starting from left/bottom

        private readonly Color BACK_COLOR_DISABLED, BACK_COLOR_ENABLED;
        // What base.BackColor should be, depending on whether this control is enabled

        public bool WhiteAttacked, BlackAttacked;
        // Whether at least one white/black piece is attacking this Square

        private ChessPiece piece;
        public ChessPiece Piece
        // The ChessPiece occupying this square, or null if empty
        {
            get
            {
                return this.piece;
            }
            set
            {
                this.piece = value;
                base.Image = (this.piece == null) ? null : this.piece.ICON;
            }
        }

        private readonly MainForm form;
        // The MainForm this PictureBox is in


        public void SetEnabled(bool enabled)
        // Sets base.Enabled, and sets base.BackColor depending on whether enabled
        {
            base.Enabled = enabled;
            base.BackColor = enabled ? this.BACK_COLOR_ENABLED : this.BACK_COLOR_DISABLED;
        }

        public ChessSquare(byte col, byte row, MainForm form)
        // Constructs a new ChessSquare with specified COL and ROW. Initializes several variables
        // with default values. Sets background color depending on COL and ROW.
        {
            this.COL = col;
            this.ROW = row;
            this.form = form;
            this.WhiteAttacked = false;
            this.BlackAttacked = false;
            this.Piece = null; // empty

            // Alternate assigning light and dark background colors
            if (COL % 2 == ROW % 2)
            {
                this.BACK_COLOR_DISABLED = Color.FromArgb(unchecked((int)0xFF663300)); // dark brown
                this.BACK_COLOR_ENABLED = Color.FromArgb(unchecked((int)0xFF000066));
            }
            else
            {
                this.BACK_COLOR_DISABLED = Color.FromArgb(unchecked((int)0xFFCC6600)); // light brown
                this.BACK_COLOR_ENABLED = Color.FromArgb(unchecked((int)0xFF0033CC));
            }
            
            SetEnabled(false);
            // Call after setting above colors. This method sets actual BackColor.

            this.Click += ChessSquare_Click;
        }

        private void ChessSquare_Click(object sender, EventArgs e)
        {
            if (this.Piece != null)
            {
                // Enable only those squares that this.Piece can move to or that have a white piece
                // other than this piece on them. Disable all others squares. Also set form
                // .SelectedPiece to this.Piece.
                this.piece.FindMoves(form.SQUARES);
                foreach (ChessSquare square in form.SQUARES)
                    if (square.Piece == null || !square.Piece.WHITE || square.Piece == this.Piece)
                        square.SetEnabled(false);
                    else
                        square.SetEnabled(true);
                foreach (ChessSquare square in this.piece.Moves)
                    square.SetEnabled(true);
                form.SelectedPiece = this.Piece;
            }
            else // this square is empty
            {
                // Move form.SelectedPiece to this square. Enable only those squares that have a
                // white piece on them. Set form.SelectedPiece to null.
                form.SelectedPiece.Move(newSquare: this);
                foreach (ChessSquare square in form.SQUARES)
                    if (square.Piece == null || !square.Piece.WHITE)
                        square.SetEnabled(false);
                    else
                        square.SetEnabled(true);
                form.SelectedPiece = null;


                // TEST
                form.AnalyzeAttacks();
            }
        }

        public override string ToString()
        {
            return "ChessSquare " + (char)('A' + COL) + (8 - ROW);
        }
    }
}
