using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteFerz : ChessLeaper
    // This is a fairy piece! It's very weak. It moves 1 square diagonally. Though it does not
    // jump because it only moves 1 square, it can still be modeled as a leaper.
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_fairy_ferz; }
        }

        public WhiteFerz(ChessSquare square) : base(square) { }

        private static readonly sbyte[,] _POSSIBLE_RELATIVE_MOVES = new sbyte[4, 2]
        {
            {1,-1}, {1,1}, {-1,1}, {-1,-1}
        };

        protected override sbyte[,] POSSIBLE_RELATIVE_MOVES
        {
            get { return _POSSIBLE_RELATIVE_MOVES; }
        }
    }
}
