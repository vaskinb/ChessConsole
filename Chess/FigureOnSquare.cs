/// <summary>
/// Сlass figures on the square of chessboard
/// </summary>

namespace ChessRules
{
    class FigureOnSquare
    {
        public Figure figure { get; private set; }
        public Square square { get; private set; }

        public FigureOnSquare(Figure figure, Square square)
        {
            this.figure = figure;
            this.square = square;
        }

    }
}
