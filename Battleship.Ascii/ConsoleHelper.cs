using System;

namespace Battleship.Ascii
{
    static class ConsoleHelper {
    public static void DrawTitle()
    {
                    Console.Title = "Battleship";
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Clear();

                    Console.WriteLine("                                     |__");
                    Console.WriteLine(@"                                     |\/");
                    Console.WriteLine("                                     ---");
                    Console.WriteLine("                                     / | [");
                    Console.WriteLine("                              !      | |||");
                    Console.WriteLine("                            _/|     _/|-++'");
                    Console.WriteLine("                        +  +--|    |--|--|_ |-");
                    Console.WriteLine(@"                     { /|__|  |/\__|  |--- |||__/");
                    Console.WriteLine(@"                    +---------------___[}-_===_.'____                 /\");
                    Console.WriteLine(@"                ____`-' ||___-{]_| _[}-  |     |_[___\==--            \/   _");
                    Console.WriteLine(@" __..._____--==/___]_|__|_____________________________[___\==--____,------' .7");
                    Console.WriteLine(@"|                        Welcome to Battleship                         BB-61/");
                    Console.WriteLine(@" \_________________________________________________________________________|");
                    Console.WriteLine();
    }

    public static void DrawStartGame(){
        	Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("                  __");
			Console.WriteLine(@"                 /  \");
			Console.WriteLine("           .-.  |    |");
			Console.WriteLine(@"   *    _.-'  \  \__/");
			Console.WriteLine(@"    \.-'       \");
			Console.WriteLine("   /          _/");
			Console.WriteLine(@"  |      _  /""");
			Console.WriteLine(@"  |     /_\'");
			Console.WriteLine(@"   \    \_/");
			Console.WriteLine(@"    """"""""");
    }

    public static void DrawExplode()
    {
            Console.ForegroundColor = ConsoleColor.Red;
        	Console.WriteLine(@"                \         .  ./");
			Console.WriteLine(@"              \      .:"";'.:..""   /");
			Console.WriteLine(@"                  (M^^.^~~:.'"").");
			Console.WriteLine(@"            -   (/  .    . . \ \)  -");
			Console.WriteLine(@"               ((| :. ~ ^  :. .|))");
			Console.WriteLine(@"            -   (\- |  \ /  |  /)  -");
			Console.WriteLine(@"                 -\  \     /  /-");
			Console.WriteLine(@"                   \  \   /  /");
    }

    public static void DrawMiss()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"                      _           _     ");
        Console.WriteLine(@"                     | |         | |    ");
        Console.WriteLine(@"            ___ _ __ | | __ _ ___| |__  ");
        Console.WriteLine(@"           / __| '_ \| |/ _` / __| '_ \ ");
        Console.WriteLine(@"           \__ \ |_) | | (_| \__ \ | | |");
        Console.WriteLine(@"           |___/ .__/|_|\__,_|___/_| |_|");
        Console.WriteLine(@"               | |                      ");
        Console.WriteLine(@"               |_|                      ");
    }
}
}