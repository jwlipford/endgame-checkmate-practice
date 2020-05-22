using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteWazir : ChessLeaper
    // This is a fairy piece! It's very weak. It moves 1 square orthogonally. Though it does not
    // jump because it only moves 1 square, it can still be modeled as a leaper.
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_fairy_wazir; }
        }

        public WhiteWazir(ChessSquare square) : base(square) { }

        private static readonly sbyte[,] _POSSIBLE_RELATIVE_MOVES = new sbyte[4, 2]
        {
            {1,0}, {0,1}, {-1,0}, {0,-1}
        };

        protected override sbyte[,] POSSIBLE_RELATIVE_MOVES
        {
            get { return _POSSIBLE_RELATIVE_MOVES; }
        }
    }
}
