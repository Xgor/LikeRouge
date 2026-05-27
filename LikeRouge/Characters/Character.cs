using System.Drawing;
using System.Numerics;

namespace LikeRouge;

public abstract class Character : IDrawable 
{
    public Point Position { get; set; }

    protected Cell Sprite { get; set; }
    
    public bool VisibleAtPosition(Point position)
        => position == Position;

    public Cell? GetCellAtPosition(Point position)
    {
        return position == Position ? Sprite : null;
    }
}