using GuildaOO.UI.Components;
using System;

namespace GuildaOO.UI
{
    partial class PianoConsole : ConsoleBase
    {
        private void PrintYellow(Direction direction)
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 50;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(direction.ToString());
        }

        private void Beep(Direction direction)
        {
            Console.Beep((int)direction * 10, 300);
        }
    }
}
