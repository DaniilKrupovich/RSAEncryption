namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///1
            /*int d = 3; // Значение d
            int F = 40; // Значение F

            try
            {
                int e = ModInverse(d, F);
                Console.WriteLine($"Решение уравнения: e = {e}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            ////2
            long a = 0; // Значение которое нужно возвести в степень
            long e = 43; // Значение d
            long n = 77; // Значение N
            var arr = new[] { 2,16,18,10,19,0,25,6,18,20,16,12 };
            //var arr = new[] { 14,1,18,12,0,4,1,13,13,1,11 };
            var newArr = new[] { 2, 16, 18, 10, 19, 0, 25, 6, 18, 20, 16, 12 };
            //var newArr = new[] { 14, 1, 18, 12, 0, 4, 1, 13, 13, 1, 11 };
            Console.Write("Зашифрованная последовательность: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = arr[i];
                var result = (int)ModPow(a, e, n);
                arr[i] = result;
                Console.Write($"{result} ");
            }
            var d = 7;
            Console.Write("\nРасшифрованная последовательность: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = arr[i];
                var result = (int)ModPow(a, d, 55);
                newArr[i] = result;
                Console.Write($"{result} ");
            }


        }
        public static long ModPow(long a, long d, long N)
        {
            long result = 1;
            a = a % N;

            while (d > 0)
            {
                if ((d & 1) == 1)
                    result = (result * a) % N;

                d = d >> 1;
                a = (a * a) % N;
            }

            return result;
        }
        public static int ExtendedEuclidean(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int x1, y1;
            int d = ExtendedEuclidean(b % a, a, out x1, out y1);

            x = y1 - (b / a) * x1;
            y = x1;

            return d;
        }

        public static int ModInverse(int d, int F)
        {
            int x, y;
            int g = ExtendedEuclidean(d, F, out x, out y);

            if (g != 1)
            {
                throw new Exception("Inverse doesn't exist");
            }
            else
            {
                int res = (x % F + F) % F;
                return res;
            }
        }
    }

}
