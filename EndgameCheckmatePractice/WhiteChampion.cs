using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteChampion : ChessLeaper
    // This is a fairy piece! It's from Omega Chess.
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_fairy_champion; }
        }

        public WhiteChampion(ChessSquare square) : base(square) { }

        private static readonly sbyte[,] _POSSIBLE_RELATIVE_MOVES = new sbyte[12, 2]
        {
            {1,0}, {2,0}, {0,1}, {0,2}, {-1,0}, {-2,0}, {0,-1}, {0,-2},
            {2,-2}, {2,2}, {-2,2}, {-2,-2}
        };

        protected override sbyte[,] POSSIBLE_RELATIVE_MOVES
        {
            get { return _POSSIBLE_RELATIVE_MOVES; }
        }
    }
}
