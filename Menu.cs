namespace EditorHTML;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen(50, 10);
        WriteOptions();

        var option = short.Parse(Console.ReadLine());

    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("============================");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma opção abaixo:");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("[1] Novo Arquivo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("[2] Abrir");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("[0] Sair");
        Console.SetCursorPosition(3, 8);
        Console.Write("Opção: ");
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