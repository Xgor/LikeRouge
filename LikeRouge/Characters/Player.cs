using System.Drawing;
using System.Numerics;

namespace LikeRouge;

public class Player :  Character
{

   public Player()
   {
      Sprite = new Cell('@');
      Sprite.Color = ConsoleColor.White;
      
   }

   public bool UseInput(ConsoleKey input)
   {
      switch (input)
      {
         // TODO Check walls and enemies later
         case ConsoleKey.W:
         case ConsoleKey.UpArrow:
            Position = new Point(Position.X,Position.Y- 1);
            return true;
         case ConsoleKey.S:
         case ConsoleKey.DownArrow:
            Position = new Point(Position.X,Position.Y+ 1);
            return true;
         case ConsoleKey.A:
         case ConsoleKey.LeftArrow:
            Position = new Point(Position.X-1,Position.Y);
            return true;
         case ConsoleKey.D:
         case ConsoleKey.RightArrow:
            Position = new Point(Position.X+1,Position.Y);
            return true;
      }
      
      return false;
   }
}