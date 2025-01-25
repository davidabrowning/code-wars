namespace PileOfCubes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] inputs = { 1071225, 91716553919377 };
            long[] answers =
            {
                findNb(inputs[0]),
                findNb(inputs[1])
            };

            Console.WriteLine($"findNb({inputs[0]})-->{answers[0]}");
            Console.WriteLine($"findNb({inputs[1]})-->{answers[1]}");
        }

        public static long findNb(long m)
        {
            int cubesOnThisLevel = 0;
            long area = 0;
            long targetArea = m;
            while (area < targetArea)
            {
                cubesOnThisLevel++;
                area += (long) Math.Pow(cubesOnThisLevel, 3);
            }
            if (area == targetArea)
            {
                return cubesOnThisLevel;
            }
            else
            {
                return -1;
            }
        }
    }
}
