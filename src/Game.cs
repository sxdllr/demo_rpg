using Raylib_cs;

internal static class Game
{
    [System.STAThread]
    public static void Main()
    {
        Raylib.InitWindow(800, 800, "demo_rpg");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);


            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
