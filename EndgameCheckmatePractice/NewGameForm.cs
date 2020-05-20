using System;
using System.Drawing;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    public partial class NewGameForm : Form
    {
        private MainForm mainForm;
        // The Form from which this Form was opened
        
        private byte numPieces;
        // The total number of white pieces currently indicated on this Form
        
        public NewGameForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            numPieces = 1;

            nudQueen.ValueChanged += countPieces;
            nudRook.ValueChanged += countPieces;
            nudBishop.ValueChanged += countPieces;
            nudKnight.ValueChanged += countPieces;
        }

        private void NewGameForm_Load(object sender, EventArgs e) { } // Do nothing

        private void btnCancel_Click(object sender, EventArgs e)
        // Closes this Window
        {
            this.Close();
        }

        private void countPieces(object sender, EventArgs e)
        // Counts the number of pieces -- the sum of the numbers in the NumericUpDown boxes, plus
        // one for the White King. Sets numPieces and lblNumPieces.Text accordingly. Also sets
        // lblNumPieces.ForeColor and btnClick.Enabled depending on whether the number of pieces is
        // too big.
        {
            numPieces = 
                (byte)(1 + nudQueen.Value + nudRook.Value + nudBishop.Value + nudKnight.Value);
            lblNumPieces.Text = "Number of pieces: " + numPieces;
            if (numPieces > 8) // The player can have up to 8 pieces
            {
                lblNumPieces.ForeColor = Color.Maroon;
                btnStart.Enabled = false;
            }
            else
            {
                lblNumPieces.ForeColor = Color.DarkGreen;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        // Tells the MainForm to start a new game with the indicated pieces, and closes this Form.
        {
            // When this method is called, numPieces should not exceed 8 because btnStart should
            // have been disabled if so. However, check anyway.
            if (numPieces > 8)
                throw new Exception("numPieces > 8");

            Type[] whitePieceTypes = new Type[numPieces];
            int i = 0;
            whitePieceTypes[i] = typeof(WhiteKing);
            for (int j = 0; j < nudQueen.Value; ++j)
            {
                ++i;
                whitePieceTypes[i] = typeof(WhiteQueen);
            }
            for (int j = 0; j < nudRook.Value; ++j)
            {
                ++i;
                whitePieceTypes[i] = typeof(WhiteRook);
            }
            for (int j = 0; j < nudBishop.Value; ++j)
            {
                ++i;
                whitePieceTypes[i] = typeof(WhiteBishop);
            }
            for (int j = 0; j < nudKnight.Value; ++j)
            {
                ++i;
                whitePieceTypes[i] = typeof(WhiteKnight);
            }

            mainForm.StartNewGame(whitePieceTypes);
            this.Close();
        }
    }
}
