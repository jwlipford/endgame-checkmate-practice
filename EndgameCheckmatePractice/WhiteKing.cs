using System.Drawing;

namespace EndgameCheckmatePractice
{
    class WhiteKing : King
    {
        public override bool WHITE { get { return true; } }

        public override Image ICON
        {
            get { return Image.FromFile(@"..\..\images\white_king.png"); }
        }

        public WhiteKing(ChessSquare square) : base(square) { }
    }
}
