﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace EndgameCheckmatePractice
{
    public partial class NewGameForm : Form
    {
        private readonly MainForm mainForm;
        // The Form from which this Form was opened

        private int numPieces;
        // The total number of white pieces currently indicated on this Form

        private readonly NumericUpDown[] nuds;
        private readonly Type[] pieceTypes;
        // These parallel arrays represent the NumericUpDowns in this Form and their corresponding
        // ChessPiece Types.

        public NewGameForm(MainForm mainForm)
        {
            InitializeComponent();

            toolTip.SetToolTip(pbWK, "King");
            toolTip.SetToolTip(pbWQ, "Queen");
            toolTip.SetToolTip(pbWR, "Rook");
            toolTip.SetToolTip(pbWB, "Bishop");
            toolTip.SetToolTip(pbWN, "Knight");
            toolTip.SetToolTip(pbWMann, "Mann");
            toolTip.SetToolTip(pbWWazir, "Wazir");
            toolTip.SetToolTip(pbWFerz, "Ferz");
            toolTip.SetToolTip(pbWChampion, "Champion");
            toolTip.SetToolTip(pbWWizard, "Wizard");
            toolTip.SetToolTip(pbBK, "King");

            this.mainForm = mainForm;
            numPieces = 1;

            nuds = new NumericUpDown[]
            {
                nudQueen, nudRook, nudBishop, nudKnight,
                nudMann, nudWazir, nudFerz, nudChampion, nudWizard
            };

            pieceTypes = new Type[]
            {
                typeof(WhiteQueen), typeof(WhiteRook), typeof(WhiteBishop), typeof(WhiteKnight),
                typeof(WhiteMann), typeof(WhiteWazir), typeof(WhiteFerz), typeof(WhiteChampion),
                typeof(WhiteWizard),
            };

            foreach (NumericUpDown nud in nuds)
                nud.ValueChanged += countPieces;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        // Closes this Window
        {
            this.Close();
        }

        private void btnRPC_Click(object sender, EventArgs e)
        // Open Recommended Piece Sets document
        {
            mainForm.btnRPS_Click(null, null);
        }

        private void countPieces(object sender, EventArgs e)
        // Counts the number of pieces -- the sum of the numbers in the NumericUpDown boxes, plus
        // one for the White King. Sets numPieces and lblNumPieces.Text accordingly. Also sets
        // lblNumPieces.ForeColor and btnClick.Enabled depending on whether the number of pieces is
        // too big.
        {
            numPieces = 1;
            foreach (NumericUpDown nud in nuds)
                numPieces += (int)nud.Value;

            lblNumPieces.Text = "Number of pieces: " + numPieces;
            if (numPieces < 2 || 8 < numPieces) // numPieces should be in range [2,8]
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
        // Tells the MainForm to start a new game with the indicated pieces, and closes this Form
        {
            // When this method is called, numPieces should be in range [2,8] because btnStart
            // should have been disabled if so. However, check anyway.
            if (numPieces < 2 || 8 < numPieces)
                throw new Exception("numPieces not in range [2,8]");

            Type[] whitePieceTypes = new Type[numPieces];
            int i = 0;
            whitePieceTypes[i] = typeof(WhiteKing);
            for (int j = 0; j < nuds.Length; ++j)
            {
                for (int k = 0; k < nuds[j].Value; ++k)
                {
                    ++i;
                    whitePieceTypes[i] = pieceTypes[j];
                }
            }

            mainForm.StartNewGame(whitePieceTypes);
            this.Close();
        }
    }
}
