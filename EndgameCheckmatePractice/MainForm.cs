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
    public partial class MainForm : Form
    {
        readonly Random RANDOM;
        
        public readonly ChessSquare[,] SQUARES;
        // After Form1 construction, SQUARES will hold 8*8=64 Squares, which are added to Panel
        // board

        int numMoves;
        // Number of moves White has played

        List<ChessPiece> white;
        // White's pieces

        ChessPiece blackKing;
        // Black's king

        public ChessPiece SelectedPiece;

        public MainForm()
        {
            InitializeComponent();

            this.RANDOM = new Random();

            this.SQUARES = new ChessSquare[8, 8];
            for(byte c = 0; c < 8; ++c)
                for(byte r = 0; r < 8; ++r)
                {
                    this.SQUARES[c, r] = new ChessSquare(col: c, row: r, form: this);
                    board.Controls.Add(this.SQUARES[c, r]);
                    this.SQUARES[c, r].SetBounds(x: 64 * c, y: 64 * r, 64, 64);
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

            ChessPiece whiteRook = new WhiteRook(SQUARES[RANDOM.Next(8), RANDOM.Next(8)]);
            whiteRook.Square.SetEnabled(true);

            // TEST CODE
            ChessPiece whiteRook2 = new WhiteRook(SQUARES[RANDOM.Next(8), RANDOM.Next(8)]);
            // If they land on same square, whiteRook (first one) will be gone, I think
            whiteRook2.Square.SetEnabled(true);
        }
    }
}
