using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;

namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/W_Pawn.png") },
            { PieceType.Bishop, LoadImage("Assets/W_Bishop.png") },
            { PieceType.Knight, LoadImage("Assets/W_Knight.png") },
            { PieceType.Rook, LoadImage("Assets/W_Rook.png") },
            { PieceType.King, LoadImage("Assets/W_King.png") },
            { PieceType.Queen, LoadImage("Assets/W_Queen.png") }
        };

        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/B_Pawn.png") },
            { PieceType.Bishop, LoadImage("Assets/B_Bishop.png") },
            { PieceType.Knight, LoadImage("Assets/B_Knight.png") },
            { PieceType.Rook, LoadImage("Assets/B_Rook.png") },
            { PieceType.King, LoadImage("Assets/B_King.png") },
            { PieceType.Queen, LoadImage("Assets/B_Queen.png") }
        };

        private static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }

        private static ImageSource GetImage(Player color, PieceType type)
        {
            return color switch
            {
                Player.White => whiteSources[type],
                Player.Black => blackSources[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }

            return GetImage(piece.Color, piece.Type);
        }
    }
}
