namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujund palun :3");

            string g = Console.ReadLine();

            if (g == "Teemant")
            {
                Teemant();
            }
            if (g == "Kolmnurk")
            {
                Kolmnurk();
            }
            if (g == "Ruut")
            {
                Ruut();
            }
            if (g == "Ristkülik")
            {
                Ristkülik();
            }



        }
        static void Teemant()
        {
            Console.WriteLine("Sisesta pikkus:");
            int i, j, r;
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta laius:");
            i = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }


            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }
        }
        static void Kolmnurk()
        {
            Console.Write("Sisesta kõrgus: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta laius: ");
            int width = Convert.ToInt32(Console.ReadLine());
            double c, e;

            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write("*");


                }
                for (int column = 0; column < width; column++)
                    Console.Write("*");
                Console.Write("\n");

            }
            Console.WriteLine("Kolmnurga ümbermõõt on:");
            c = Math.Sqrt(height * height + width * width);
            Console.WriteLine(c + height + width);
            Console.WriteLine("Kolmnurga pindala on:");
            e = height * width;
            Console.WriteLine(e / 2);
        }
        static void Ruut()
        {
            int Size;

            Console.WriteLine("Sisesta külje pikkus:");
            Size = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < Size; row++)
            {
                for (int column = 0; column < Size; column++)
                {
                    Console.Write("*" + " ");
                }

                Console.WriteLine();
                Console.WriteLine("");
            }
            Console.WriteLine("Ruudu ümbermõõt on:");
            Console.WriteLine(Size * 4);
            Console.WriteLine("Ruudu pindala on:");
            Console.WriteLine(Size * Size);
        }
        static void Ristkülik()
        {
            Console.WriteLine("Sisestage kõrgus:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisestage laius:");
            int width = Convert.ToInt32(Console.ReadLine());
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Ristküliku ümbermõõt on:");
            Console.WriteLine(height * 2 + width * 2);
            Console.WriteLine("Ristküliku pindala");
            Console.WriteLine(height * width);
        }
    }
}




