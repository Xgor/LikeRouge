namespace LikeRouge;

public class Cell
{
   public char Symbol { get; set; } = '.';

   public ConsoleColor BackgroundColor = ConsoleColor.Black;
   
   public ConsoleColor Color = ConsoleColor.DarkRed;

   public Cell(char symbol)
   {
      Symbol = symbol;
   }
   
   public void Draw()
   {
      Console.BackgroundColor = BackgroundColor;
      Console.ForegroundColor = Color;
      Console.Write(Symbol);
   }
}