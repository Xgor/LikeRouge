namespace LikeRouge;

public class Cell
{
   public char Symbol => '.';

   public ConsoleColor BackgroundColor = ConsoleColor.Black;
   
   public ConsoleColor Color = ConsoleColor.DarkRed;
   
   
   public void Draw()
   {
      Console.BackgroundColor = BackgroundColor;
      Console.ForegroundColor = Color;
      Console.Write(Symbol);
   }
}