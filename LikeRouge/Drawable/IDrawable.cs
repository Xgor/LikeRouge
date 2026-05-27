using System.Drawing;
using System.Numerics;

namespace LikeRouge;

public interface IDrawable
{
    Point Position { get; set; }

    public bool VisibleAtPosition(Point position);
    public Cell? GetCellAtPosition(Point position);
}