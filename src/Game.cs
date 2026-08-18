using demo_rpg.Entities;
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

            Warrior warrior = new Warrior();
            Raylib.DrawText($"Class: Warrior\nMaxHP: {warrior.Health.MaxHP}\n" +
                $"Stength: {warrior.Stats.Strength}\n" +
                $"Intelligence: {warrior.Stats.Intelligence}",
                12, 12, 20, Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
