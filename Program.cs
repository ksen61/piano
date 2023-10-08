class OctavePiano
{
    private static List<int[]> octaves = new List<int[]>
    {
        new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 },
        new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 },
    };

    private static int currentOctaveIndex = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Переключение между октавами F5 и F6");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            if (keyInfo.Key == ConsoleKey.F5)
            {
                currentOctaveIndex = 0;
                Console.WriteLine("Переключено на пятую октаву");
            }
            else if (keyInfo.Key == ConsoleKey.F6)
            {
                currentOctaveIndex = 1;
                Console.WriteLine("Переключено на шестую октаву");
            }
            else
            {
                PlayNote(keyInfo);
            }
        }
    }

    public static void PlayNote(ConsoleKeyInfo keyInfo)
    {
        int noteIndex = -1;

        switch (keyInfo.Key)
        {
            case ConsoleKey.A:
                noteIndex = 0;
                break;
            case ConsoleKey.Q:
                noteIndex = 1;
                break;
            case ConsoleKey.S:
                noteIndex = 2;
                break;
            case ConsoleKey.W:
                noteIndex = 3;
                break;
            case ConsoleKey.D:
                noteIndex = 4;
                break;
            case ConsoleKey.F:
                noteIndex = 5;
                break;
            case ConsoleKey.E:
                noteIndex = 6;
                break;
            case ConsoleKey.G:
                noteIndex = 7;
                break;
            case ConsoleKey.R:
                noteIndex = 8;
                break;
            case ConsoleKey.H:
                noteIndex = 9;
                break;
            case ConsoleKey.T:
                noteIndex = 10;
                break;
            case ConsoleKey.J:
                noteIndex = 11;
                break;
            default:
                break;
        }

        if (noteIndex >= 0)
        {
            int[] currentOctave = octaves[currentOctaveIndex];
            if (noteIndex < currentOctave.Length)
            {
                int frequency = currentOctave[noteIndex];
                Console.Beep(frequency, 300);
            }
        }
        Console.Clear();
    }
}
