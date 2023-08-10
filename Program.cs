namespace RumfangBeregner
{
    internal class Program
    {
        public static double Length { get; set; }
        public static double Width { get; set; }
        public static double Height { get; set; }

        static void Main()
        {
            // Checking if the three strings can be parsed to double
            Console.Clear(); Console.Write("Input a length value: ");
            string LengthInput = Console.ReadLine()!; Console.WriteLine();
            if (double.TryParse(LengthInput, out double OutLength)) { Length = OutLength; } else { Invalid(); }

            Console.Write("Input a width value: ");
            string WidthInput = Console.ReadLine()!; Console.WriteLine();
            if (double.TryParse(WidthInput, out double OutWidth)) { Width = OutWidth; } else { Invalid(); }

            Console.Write("Input a height value: ");
            string HeightInput = Console.ReadLine()!; Console.WriteLine();
            if (double.TryParse(HeightInput, out double OutHeight)) { Height = OutHeight; } else { Invalid(); }


            // Outputting answer to console
            float Volume = (float)(Height * Width * Length);
            Console.WriteLine($"The volume of the rectangle you have specified is {Volume}.");
            Console.ReadKey();
            Main();

            // Value could not be turned to double
            static void Invalid()
            {
                Console.Clear();
                Console.WriteLine("Invalid value");
                Console.ReadKey();
                Console.Clear();
                Length = 0; Width = 0; Height = 0;
                Main();
            }
        }
    }
}