using System.Drawing;

namespace LikeRouge;

public interface IDrawable
{
    Point Position { get; set; }

    public bool VisibleAtPosition(Point position);
    public Cell? GetCellAtPosition(Point position);
}