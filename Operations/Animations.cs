public static class Animations
{
    public static async Task SpinnerAnimation(
        int cycles = 6,
        int delay = 50,
        char[] frames = null)
    {
        Console.CursorVisible = false;
        Console.Clear();

        frames ??= new[] { '-', '\\', '|', '/' };

        for (int i = 0; i < cycles; i++)
        {
            foreach (char frame in frames)
            {
                Console.Write(frame);
                await Task.Delay(delay);

                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
        Console.Write(" "); 
        Console.CursorVisible = true;
    }
}
