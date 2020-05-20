using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteKing : King
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Properties.Resources.white_king; }
        }

        public WhiteKing(ChessSquare square) : base(square) { }
    }
}
