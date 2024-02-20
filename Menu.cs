namespace EditorHTML;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen(50, 10);

    }

    public static void DrawScreen(int width, int height)
    {
        DrawColumn(width);
        DrawRow(width, height);
        DrawColumn(width);
    }

    public static void DrawColumn(int size)
    {
        Console.Write("+");

        for (int x = 0; x < size; x++)
            Console.Write("-");

        Console.Write("+\n");

    }

    public static void DrawRow(int width, int height)
    {
        for (int x = 0; x < height; x++)
        {
            Console.Write("|");
            for (int y = 0; y < width; y++)
                Console.Write(" ");

            Console.Write("|\n");
        }


    }

}