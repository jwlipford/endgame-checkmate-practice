using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    public partial class MainForm : Form
    {
        readonly Random RANDOM;
        
        public readonly ChessSquare[,] SQUARES;
        // After Form1 construction, SQUARES will hold 8*8=64 Squares, which are added to Panel
        // board

        int numMoves;
        // Number of moves White has played

        public List<ChessPiece> white;
        // White's pieces

        ChessPiece blackKing;
        // Black's king

        public ChessPiece SelectedPiece;

        public MainForm()
        {
            InitializeComponent();

            this.RANDOM = new Random();

            this.SQUARES = new ChessSquare[8, 8];
            for (byte c = 0; c < 8; ++c)
                for (byte r = 0; r < 8; ++r)
                {
                    this.SQUARES[c, r] = new ChessSquare(col: c, row: r, form: this);
                    board.Controls.Add(this.SQUARES[c, r]);
                    this.SQUARES[c, r].SetBounds(x: 64 * c, y: 64 * r, 64, 64);
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        // Closes application
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        // Removes all pieces from the board, and disables all squares
        {
            foreach (ChessSquare square in SQUARES)
            {
                square.Piece = null;
                square.SetEnabled(false);
            }

            // Free resources
            white = null;
            blackKing = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        // Resets pieces to their initial positions
        {
            MessageBox.Show("Not implemented");
        }

        private void Form1_Load(object sender, EventArgs e) { } // Do nothing

        public void AnalyzeAttacks()
        // Sets BlackAttacked and WhiteAttacked for all squares
        {
            foreach (ChessSquare square in SQUARES)
            {
                square.WhiteAttacked = false;
                square.BlackAttacked = false;
            }
            if (blackKing != null)
                blackKing.FindAttacks(SQUARES);
            foreach (ChessPiece piece in white)
                piece.FindAttacks(SQUARES);
        }

        private void btn_KQ_vs_K_Click(object sender, EventArgs e)
        // Start a game with white king and queen vs black king
        {
            MessageBox.Show("Not implemented");
        }

        private void btn_KR_vs_K_Click(object sender, EventArgs e)
        // Start a game with white king and rook vs black king
        {
            MessageBox.Show("Not implemented");
        }

        private void btn_KRR_vs_K_Click(object sender, EventArgs e)
        // Start a game with white king and two rooks vs black king
        {
            btnClear_Click(null, null);
            numMoves = 0;
            white = new List<ChessPiece>(capacity: 4);
            blackKing = null; // placeholder -- assign!

            white.Add(new WhiteKing(SQUARES[RANDOM.Next(8), RANDOM.Next(8)]));
            white.Add(new WhiteRook(SQUARES[RANDOM.Next(8), RANDOM.Next(8)]));
            white.Add(new WhiteRook(SQUARES[RANDOM.Next(8), RANDOM.Next(8)]));
            // If two land on same square, the second will replace the first, I think.
            // Add functionality to deal with this!

            foreach(ChessPiece piece in white)
                piece.Square.SetEnabled(true);
        }

        private void btn_KN_vs_K_Click(object sender, EventArgs e)
        {
            btnClear_Click(null, null);
            numMoves = 0;
            white = new List<ChessPiece>(capacity: 3);
            blackKing = null; // placeholder -- assign!

            white.Add(new WhiteKing(SQUARES[RANDOM.Next(8), RANDOM.Next(8)]));
            white.Add(new WhiteKnight(SQUARES[RANDOM.Next(8), RANDOM.Next(8)]));
            // If two land on same square, the second will replace the first, I think.
            // Add functionality to deal with this!

            foreach (ChessPiece piece in white)
                piece.Square.SetEnabled(true);
        }


    }
}
