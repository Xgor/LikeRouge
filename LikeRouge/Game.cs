using System.Drawing;

namespace LikeRouge;

public class Game
{
    private Map _map;
    private Player _player;
    
    private const int _height = 10;
    private const int _width = 10;

    internal void Run()
    {
        Init();
        while (true)
        {
            Update();
            Draw();
            Thread.Sleep(100);
        }
    }

    internal void Init()
    {
        _map = new Map(_width, _height);
        _player = new Player();
    }

    internal void Update()
    {
        
    }

    internal void Draw()
    {
        Console.Clear();
        for (int y = 0; y < _height; y++)
        {
            for(int x = 0; x < _width; x++) 
            {
                Point p = new Point(x, y);
                if(_map.VisibleAtPosition(p))
                    _map.GetCellAtPosition(p).Draw();
            }
            Console.WriteLine();
        }
    }
}


