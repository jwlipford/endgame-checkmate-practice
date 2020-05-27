using EndgameCheckmatePractice.documents;
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

        private int numMoves;
        // Number of moves White has played

        public List<ChessPiece> White;
        // White's pieces

        public BlackKing BlackKing;
        // Black's king

        public ChessPiece SelectedPiece;
        // The piece the user most recently clicked, which will be moved if the user clicks a
        // square it can move to

        private Tuple<Type[], ChessSquare[], ChessSquare> startData;
        // Data about the game's start, for use when either Reset button is clicked. The elements
        // in the tuple should be:
        //   1. The original Types of the white pieces
        //   2. The squares the white pieces were originally on (in order corresponding to the
        //      order of the first element)
        //   3. The square the Black King was originally on
        // To avoid confusion about the purpose of these elements, they are contained inside this
        // tuple rather than stored as separate variables.

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

        private void clearBoard()
        // Removes all pieces from the board, and disables all squares.
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

        private void btnClear_Click(object sender, EventArgs e)
        // Removes all pieces from the board, disables all squares, and clears startData,
        // preventing resets
        {
            clearBoard();
            startData = null;
        }

        private void btnResetNP_Click(object sender, EventArgs e)
        // Restarts game with pieces in new positions
        {
            if (startData == null)
            {
                MessageBox.Show("No game to reset");
                return;
            }

            StartNewGame(startData.Item1);

            // After starting new game, pieces's original positions have changed, so update
            // startData.
            for (int i = 0; i < White.Count; ++i)
                startData.Item2[i] = White[i].Square;
            // startData.Item3, which unlike the other 2 elements is not an array, is immutable,
            // so overwrite the whole tuple with a new one to change Item3.
            startData = Tuple.Create(startData.Item1, startData.Item2, BlackKing.Square);
        }

        private void btnResetOP_Click(object sender, EventArgs e)
        // Restarts game with pieces in their original positions
        {
            if (startData == null)
            {
                MessageBox.Show("No game to reset");
                return;
            }

            clearBoard();
            BlackKing = new BlackKing(startData.Item3);
            White = new List<ChessPiece>(capacity: startData.Item2.Length);
            for (int i = 0; i < startData.Item1.Length; ++i)
                White.Add(
                    (ChessPiece)(startData.Item1[i]
                    .GetConstructor(types: new Type[] { typeof(ChessSquare) })
                    .Invoke(parameters: new object[] { startData.Item2[i] })));
            foreach (ChessPiece piece in White)
                piece.Square.SetEnabled(true);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        // Opens a NewGameForm
        {
            NewGameForm ngf = new NewGameForm(this);
            ngf.Show();
        }

        public void btnHowToPlay_Click(object sender, EventArgs e)
        // Opens How To Play instructions
        {
            LargeTextInfoForm ltif =
                new LargeTextInfoForm("How to Play", Properties.Resources.How_To_Play);
            ltif.Show();
        }

        public void btnRPS_Click(object sender, EventArgs e)
        // Open Recommended Piece Sets document
        {
            LargeTextInfoForm ltif = new LargeTextInfoForm(
                "Recommended Pieces Sets", Properties.Resources.Recommended_Piece_Sets, 350);
            ltif.Show();
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
        // white. In case there are already pieces on the board, the board is cleared first.
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
            clearBoard();
            numMoves = 0;
            White = new List<ChessPiece>(capacity: whitePieceTypes.Length);
            byte numPieces = (byte)(whitePieceTypes.Length + 1); // +1 for Black King

            // Put pieces on random squares, but make sure Black King is not in checkmate or
            // stalemate
            ChessSquare[] initSquares = randomSquares(numPieces);
            BlackKing = new BlackKing(initSquares[0]);
            for (int i = 1; i < initSquares.Length; ++i)
                White.Add( // Dis wite heer bout to git complikated :)
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

            // Set startData
            startData = Tuple.Create(whitePieceTypes, new ChessSquare[White.Count], BlackKing.Square);
            for (int i = 0; i < White.Count; ++i)
                startData.Item2[i] = White[i].Square;

            // Enable squares with white pieces
            foreach (ChessPiece piece in White)
                piece.Square.SetEnabled(true);
        }

        public void TakeBlackTurn(out bool gameOver)
        // Takes Black's turn, moving its king. Checks for and handles checkmate and stalemate.
        // Handles draw for King vs King but not for any other situation such as King and Bishop
        // vs King. In checkmate, stalemate, or draw, sets gameOver to true; otherwise, sets it to
        // false. Does not enable/disable squares.
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

                if (White.Count == 1) // Draw by lack of material
                {
                    // This would be slightly better with a custom message box with a bigger font.
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
                    MessageBox.Show("Checkmate! 😁\nIn " + numMoves + " moves");
                else
                    MessageBox.Show("Stalemate 😞\nIn " + numMoves + " moves");
                gameOver = true;
            }
        }
    }
}
