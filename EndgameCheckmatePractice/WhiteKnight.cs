using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteKnight : ChessLeaper
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_knight; }
        }

        public WhiteKnight(ChessSquare square) : base(square) { }

        private static readonly sbyte[,] _POSSIBLE_RELATIVE_MOVES = new sbyte[8, 2]
        {
            {2,-1}, {2,1}, {1,2}, {-1,2}, {-2,1}, {-2,-1}, {-1,-2}, {1,-2}
        };

        protected override sbyte[,] POSSIBLE_RELATIVE_MOVES
        {
            get { return _POSSIBLE_RELATIVE_MOVES; }
        }
    }
}
