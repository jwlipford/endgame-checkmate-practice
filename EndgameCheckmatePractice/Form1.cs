using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    public partial class Form1 : Form
    {
        ChessSquare[,] squares;
        // After Form1 construction, squares will hold 8*8=64 Squares, which are added to Panel
        // board

        int numMoves;
        // Number of moves White has played

        List<ChessPiece> white;
        // White's pieces

        ChessPiece blackKing;
        // Black's king

        public Form1()
        {
            InitializeComponent();

            squares = new ChessSquare[8, 8];
            for(byte c = 0; c < 8; ++c)
                for(byte r = 0; r < 8; ++r)
                {
                    squares[c, r] = new ChessSquare(col: c, row: r);
                    board.Controls.Add(squares[c, r]);
                    squares[c, r].SetBounds(x: 64 * c, y: 64 * r, 64, 64);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_KQ_vs_K_Click(object sender, EventArgs e)
        // Start a game with white king and queen vs black king
        {
            
        }

        private void btn_KR_vs_K_Click(object sender, EventArgs e)
        // Start a game with white king and rook vs black king
        {
            numMoves = 0;
            white = new List<ChessPiece>(capacity: 2);
            // Add to white
            blackKing = null; // placeholder -- assign!

            // TEST CODE
            Rook rook = new Rook(white: true, square: squares[4, 4]);
            rook.attack(squares);
        }
    }
}
