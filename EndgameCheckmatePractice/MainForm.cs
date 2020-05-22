using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    public partial class MainForm : Form
    {
        private readonly Random RANDOM;
        
        public readonly ChessSquare[,] SQUARES;
        // After Form1 construction, SQUARES will hold 8*8=64 Squares, which are added to Panel
        // board

        int numMoves;
        // Number of moves White has played

        public List<ChessPiece> White;
        // White's pieces

        public BlackKing BlackKing;
        // Black's king

        private List<ChessSquare> whiteStartSquares;

        private ChessSquare blackKingStartSquare;

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
            White = null;
            BlackKing = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        // Resets pieces to their initial positions
        {
            MessageBox.Show("Not implemented");
            return;

            // TODO: Deal with pieces that are captured

            numMoves = 0;
            BlackKing.Move(blackKingStartSquare);
            for (int i = 0; i < White.Count; ++i)
                White[i].Move(whiteStartSquares[i]);
            foreach (ChessSquare square in SQUARES)
                if (square.Piece != null && square.Piece.WHITE)
                    square.SetEnabled(true);
                else
                    square.SetEnabled(false);
        }


        // TODO: What if the user clicks this twice?
        private void btnNewGame_Click(object sender, EventArgs e)
        // Opens a NewGameForm
        {
            NewGameForm ngf = new NewGameForm(this);
            ngf.Show();
        }

        private ChessSquare[] randomSquares(byte length)
        // Generates an array with the specified length such that no square has the same
        // coordinates as another. length must not exceed 64.
        {
            if (length > 64)
                throw new ArgumentException("length > 64");
            ChessSquare[] squares = new ChessSquare[length];
            for (int i = 0; i < length; ++i)
            {
                bool cont = true;
                while (cont)
                {
                    squares[i] = SQUARES[RANDOM.Next(8), RANDOM.Next(8)];
                    cont = false;
                    for (int j = 0; j < i; ++j)
                        if (squares[i] == squares[j])
                        {
                            cont = true;
                            break;
                        }
                }
            }
            return squares;
        }

        public void AnalyzeAttacks()
        // Sets BlackAttacked and WhiteAttacked for all squares
        {
            foreach (ChessSquare square in SQUARES)
            {
                square.WhiteAttacked = false;
                square.BlackAttacked = false;
            }
            if (BlackKing != null)
                BlackKing.FindAttacks(SQUARES);
            foreach (ChessPiece piece in White)
                piece.FindAttacks(SQUARES);
        }

        public void StartNewGame(Type[] whitePieceTypes)
        // Starts a new game with a Black King and white pieces of Types whitePieceTypes. Each Type
        // in whitePieceTypes must be a subclass of ChessPiece, must not be abstract, and must be
        // white. Use this method when a button that says something like "King, Rook, and Rook vs
        // King" is clicked.
        {
            // Check whitePieceTypes for argument errors
            foreach (Type type in whitePieceTypes)
            {
                if (!type.IsSubclassOf(typeof(ChessPiece)))
                    throw new ArgumentException(
                        "Each type in whitePieceTypes must be a subclass of ChessPiece.");
                if (type.IsAbstract)
                    throw new ArgumentException("No type in whitePieceTypes may be abstract");
            }

            // Basic setup
            btnClear_Click(null, null);
            numMoves = 0;
            White = new List<ChessPiece>(capacity: whitePieceTypes.Length);
            byte numPieces = (byte)(whitePieceTypes.Length + 1); // +1 for Black King

            // Put pieces on random squares, but make sure Black King is not in checkmate or
            // stalemate
            ChessSquare[] initSquares = randomSquares(numPieces);
            BlackKing = new BlackKing(initSquares[0]);
            for (int i = 1; i < initSquares.Length; ++i)
                White.Add( // Dis wite heer bout to git complikated
                    (ChessPiece)(whitePieceTypes[i - 1]
                    .GetConstructor(types: new Type[] { typeof(ChessSquare) })
                    .Invoke(parameters: new object[] { initSquares[i] })));
            AnalyzeAttacks();
            BlackKing.FindMoves(SQUARES);
            while (BlackKing.Square.WhiteAttacked || BlackKing.Moves.Count == 0)
            {
                initSquares = randomSquares(numPieces);
                BlackKing.Move(initSquares[0]);
                for (int i = 1; i < initSquares.Length; ++i)
                    White[i - 1].Move(initSquares[i]);
                AnalyzeAttacks();
                BlackKing.FindMoves(SQUARES);
            }

            // Set start squares
            blackKingStartSquare = BlackKing.Square;
            whiteStartSquares = new List<ChessSquare>(capacity: whitePieceTypes.Length);
            foreach (ChessPiece piece in White)
                whiteStartSquares.Add(piece.Square);

            // Enable squares with white pieces
            foreach (ChessPiece piece in White)
                piece.Square.SetEnabled(true);
        }

        public void TakeBlackTurn(out bool gameOver)
        // Takes Black's turn, moving its king. Checks for and handles checkmate, stalemate, and
        // draw by lack of material. In these situations, sets gameOver to true; otherwise, sets it
        // to false. Does not enable/disable squares.
        {
            ++numMoves;
            AnalyzeAttacks();

            BlackKing.FindMoves(this.SQUARES);
            ChessSquare BlackKingChoice = BlackKing.ChooseMove();

            if (BlackKingChoice != null)
            {
                if (BlackKingChoice.Piece != null)
                    White.Remove(BlackKingChoice.Piece);
                BlackKing.Move(BlackKingChoice);

                if (White.Count == 1) // Draw by lack of material    // DUMMY -- extend this
                {
                    // TODO: Find how to increase font size (probably make a custom message-box form)
                    MessageBox.Show("Draw by lack of material 😞\nIn " + numMoves + " moves");
                    gameOver = true;
                }
                else
                {
                    AnalyzeAttacks();
                    gameOver = false;
                }
            }
            else // Black King cannot move, is in checkmate or stalemate
            {
                if (BlackKing.Square.WhiteAttacked)
                    //MessageBox.Show("Checkmate! 😁\nIn " + numMoves + " moves");
                    MessageBox.Show("Checkmate! 😁\nIn " + numMoves + " moves");
                else
                    MessageBox.Show("Stalemate 😞\nIn " + numMoves + " moves");
                gameOver = true;
            }
        }
    }
}
