using System;
using System.Text;


namespace Input
{
    class Input
    {
        static string line = null;
        static int index = 0;
        static int lenght = 0;

        private static void ReadLine()
        {
            line = Console.ReadLine();

            if (line == null)
            {
                throw new Exception("Čitanie za koncom súboru");
            }
            index = 0;
            lenght = line.Length;
        }

        private static void SkipSpaces()
        {
            while (index < lenght && line[index] == ' ')
            {
                index++;
            }

        }

        private static string NextWord()
        {
            if (line == null)
            {
                ReadLine();
            }
            SkipSpaces();
            while (index == lenght)
            {
                ReadLine();
                SkipSpaces();
            }
            StringBuilder word = new StringBuilder("");

            while (index < lenght && line[index] != ' ')
            {
                word.Append(line[index++]);


            }
            return word.ToString();
        }

        public static int ReadInt() => Convert.ToInt32(NextWord());
        public static double ReadDouble() => Convert.ToDouble(NextWord());
    }
}
