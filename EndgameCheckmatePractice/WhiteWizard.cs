using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteWizard : ChessLeaper
    // This is a fairy piece! It's from Omega Chess.
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_fairy_wizard; }
        }

        public WhiteWizard(ChessSquare square) : base(square) { }

        private static readonly sbyte[,] _POSSIBLE_RELATIVE_MOVES = new sbyte[12, 2]
        {
            {3,-1}, {3,1}, {1,3}, {-1,3}, {-3,1}, {-3,-1}, {-1,-3}, {1,-3},
            {1,-1}, {1,1}, {-1,1}, {-1,-1}
        };
    
        protected override sbyte[,] POSSIBLE_RELATIVE_MOVES
        {
            get { return _POSSIBLE_RELATIVE_MOVES; }
        }
    }
}
