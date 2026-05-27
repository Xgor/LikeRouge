using System.Drawing;
using System.Numerics;

namespace LikeRouge;

internal class Map : IDrawable
{
    
    private Cell[,] _cells;
    private int _height;
    private int _width;
    private Rectangle _bounds;
    
    public Map(int width, int height)
    {
        _width = width;
        _height = height;

        _cells = new Cell[width, height];
        _bounds = new Rectangle(Position.X, Position.Y, width, height);
        _cells = new Cell[width, height];
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                _cells[x, y] = new Cell();
            }
        }
    }
    

    public Point Position { get; set; } = Point.Empty;
    public bool VisibleAtPosition(Point position)
    {
        return _bounds.Contains(position);
    }

    public Cell? GetCellAtPosition(Point position)
    {
        if (!VisibleAtPosition(position)) return null;

        return _cells[position.X, position.Y];
    }
}